using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Features2D;
using Emgu.CV.Util;

namespace stabilization
{
    public partial class stabilization : Form
    {
        private Image<Bgr, byte> inputImage,stabilizedImage;
        private Image<Gray, byte> inputGrayImage, inputGrayImagePrevious;
        private Matrix<float> rigidTransform;
        private FastDetector fastDetector;
        private Capture cam;
        private uint errorCount;
        private VectorOfKeyPoint vectors;
        private bool captureInProgress;

        public stabilization()
        {
            InitializeComponent();
            inputImage = new Image<Bgr, byte>(640, 480);
            stabilizedImage = new Image<Bgr, byte>(640, 480);

            inputGrayImage = new Image<Gray, byte>(inputImage.Size);
            inputGrayImagePrevious = new Image<Gray, byte>(inputImage.Size);
            fastDetector = new FastDetector();
            errorCount = 0;
            initializingTransform();
        }
        
        private void processFrame(object sender, EventArgs arg)
        {          
            try
            {
                cam.Retrieve(inputImage, 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error");
            }
            CvInvoke.CvtColor(inputImage, inputGrayImage, ColorConversion.Bgr2Gray, 0);      

            if (checkBoxOpticalFlow.Checked)
            {
                opticalFlow();               
            }
            imageBoxOutput.Image = stabilizedImage;
            imageBoxInput.Image = inputImage;   
        }

        private void opticalFlow()
        {
            var a = new MCvTermCriteria(100);
            byte[] status;
            float[] errors;
            PointF[] corners;
            var vectors2 = vector2Point(vectors);
            
            CvInvoke.CalcOpticalFlowPyrLK(inputGrayImagePrevious, inputGrayImage, vectors2,
                new Size(10, 10), 2, a, out corners, out status, out errors);
            var matches = countNonZero(status);

            if (checkBoxStabilized.Checked)
            {
                if (matches < status.Count() * 0.9||matches<200)
                {
                    labelErrors.Text = "Error " + Convert.ToString(++errorCount);
                    updateReference(null, null);
                    return;
                }
                labelStatus.Text = "Found =" + Convert.ToString(matches);
                labelTotal.Text = "Total =" + Convert.ToString(errors.Count());
                try
                {
                    var newRigidTransform = CvInvoke.EstimateRigidTransform(vectors2, corners, false);                 
                    var newRigidTransform33 = transformTo3D(newRigidTransform);
                    rigidTransform *= newRigidTransform33;                   
                    var rigidTransform3 = new Matrix<float>(3,3);
                    CvInvoke.Invert(rigidTransform, rigidTransform3, DecompMethod.Svd);                
                    var rigidTransform2D = transformTo2D(rigidTransform3);
                    CvInvoke.WarpAffine(inputImage, stabilizedImage, rigidTransform2D,
                        new Size(),Inter.Linear,Warp.Default,BorderType.Constant);                                  

                    //   checkBoxStabilized.Checked = false;
                    //   updateMatrices(rigidTransform2D,newRigidTransform33);
                    refreshKeyPoints(corners,status,matches);
                    inputGrayImage.CopyTo(inputGrayImagePrevious);
                    //   initializingTransform(); 
                }
                catch (Exception)
                {
                    labelErrors.Text = "Error "+Convert.ToString(++errorCount);
                 //   updateReference(null,null);
                }
               
            }
        }

        private void updateMatrices(Matrix<float> rigidTransform2D, Matrix<float> newRigidTransform33)
        {
            labelTransRigid00.Text = Convert.ToString(rigidTransform.Data[0, 0]);
            labelTransRigid01.Text = Convert.ToString(rigidTransform.Data[0, 1]);
            labelTransRigid02.Text = Convert.ToString(rigidTransform.Data[0, 2]);
            labelTransRigid10.Text = Convert.ToString(rigidTransform.Data[1, 0]);
            labelTransRigid11.Text = Convert.ToString(rigidTransform.Data[1, 1]);
            labelTransRigid12.Text = Convert.ToString(rigidTransform.Data[1, 2]);

            labelSumTransformRigid.Text = Convert.ToString
                (
                rigidTransform.Data[0, 0] +
                rigidTransform.Data[0, 1] +
                rigidTransform.Data[0, 2] +
                rigidTransform.Data[1, 0] +
                rigidTransform.Data[1, 1] +
                rigidTransform.Data[1, 2]
                );

            labelTransform00.Text = Convert.ToString(rigidTransform2D.Data[0, 0]);
            labelTransform01.Text = Convert.ToString(rigidTransform2D.Data[0, 1]);
            labelTransform02.Text = Convert.ToString(rigidTransform2D.Data[0, 2]);
            labelTransform10.Text = Convert.ToString(rigidTransform2D.Data[1, 0]);
            labelTransform11.Text = Convert.ToString(rigidTransform2D.Data[1, 1]);
            labelTransform12.Text = Convert.ToString(rigidTransform2D.Data[1, 2]);

            labelSumTransform.Text = Convert.ToString
                (
                rigidTransform2D.Data[0, 0] +
                rigidTransform2D.Data[0, 1] +
                rigidTransform2D.Data[0, 2] +
                rigidTransform2D.Data[1, 0] +
                rigidTransform2D.Data[1, 1] +
                rigidTransform2D.Data[1, 2]
                );

            labelTrans3300.Text = Convert.ToString(newRigidTransform33.Data[0, 0]);
            labelTrans3301.Text = Convert.ToString(newRigidTransform33.Data[0, 1]);
            labelTrans3302.Text = Convert.ToString(newRigidTransform33.Data[0, 2]);
            labelTrans3310.Text = Convert.ToString(newRigidTransform33.Data[1, 0]);
            labelTrans3311.Text = Convert.ToString(newRigidTransform33.Data[1, 1]);
            labelTrans3312.Text = Convert.ToString(newRigidTransform33.Data[1, 2]);

            labelSumTransform33.Text = Convert.ToString
                (
                newRigidTransform33.Data[0, 0] +
                newRigidTransform33.Data[0, 1] +
                newRigidTransform33.Data[0, 2] +
                newRigidTransform33.Data[1, 0] +
                newRigidTransform33.Data[1, 1] +
                newRigidTransform33.Data[1, 2]
                );
        }

        private void refreshKeyPoints(PointF[] corners2,byte[] status,int matches)
        {
            vectors.Clear();
            var j = 0;
            var a = new MKeyPoint[matches];
            for (int i = 0; i < corners2.Count(); i++)
            {
                if (status[i] == 1)
                {                 
                    a[j].Point.X = corners2[i].X;
                    a[j].Point.Y = corners2[i].Y;                  
                    j++;
                }
            }
            vectors.Push(a);
        }

        private static Matrix<float> transformTo2D(Matrix<float> rigidTransform)
        {
            float[,] target = {
                            {rigidTransform.Data[0,0],rigidTransform.Data[0,1],rigidTransform.Data[0,2]},
                            {rigidTransform.Data[1,0],rigidTransform.Data[1,1],rigidTransform.Data[1,2]},
                       };
            var r = new Matrix<float>(target);
            return r;
        }

        private void initializingTransform()
        {
            float[,] target = {
                            {1f,0,0},
                            {0,1f,0},
                            {0, 0,1f},
                       };
            rigidTransform = new Matrix<float>(target);
        }

        private static Matrix<float> transformTo3D(Mat newRigidTransform)
        {
            var nrtImage = newRigidTransform.ToImage<Gray, float>();

            float[,] target = {
                            {nrtImage.Data[0,0,0], nrtImage.Data[0,1,0],nrtImage.Data[0,2,0]},
                            {nrtImage.Data[1,0,0], nrtImage.Data[1,1,0],nrtImage.Data[1,2,0]},
                            {0, 0,1f},
                       };
            var r = new Matrix<float>(target);
            return r;
        }

        private static ushort countNonZero(byte[] status2)
        {
            ushort nonZero=0;
            for (int i = 0; i < status2.Count(); i++)
            {
                if (status2[i] != 0)
                {
                    nonZero++;
                }
            }
            return nonZero;
        }

        private static PointF[] vector2Point(VectorOfKeyPoint corners)
        {
            var result=new PointF[corners.Size];
            for (int i = 0; i < corners.Size; i++)
            {
                result[i].X = corners[i].Point.X;
                result[i].Y = corners[i].Point.Y;
            }
            return result;
        }

        private void updateReference(object sender, EventArgs e)
        {
            var keypoints = fastDetector.Detect(inputGrayImage, null);
            vectors = new VectorOfKeyPoint(keypoints);
            var aa = vectors.Size;
            inputGrayImage.CopyTo(inputGrayImagePrevious);

          //  for (int i = 0; i < aa; i++)
          //  {
          //      CvInvoke.Circle(inputGrayImage, new Point((int)vectors[i].Point.X, (int)vectors[i].Point.Y), 2, new MCvScalar(0, 0, 255));
          //  }
           
            imageBoxOutput.Image = inputGrayImage;
            initializingTransform();
        }

        private void startClick(object sender, EventArgs e)
        {
            try
            {
                cam = new Capture();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
                Close();
            }


            if (cam != null)
            {
                if (captureInProgress)
                {
                    bt_start.Text = "Start!"; //
                    Application.Idle -= processFrame;
                    cam.Stop();
                    cam.Dispose();
                }
                else
                {
                    bt_start.Text = "Stop";
                    Application.Idle += processFrame;
                }
                captureInProgress = !captureInProgress;
            }

        }
    
    }
}
