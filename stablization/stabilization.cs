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
using Emgu.CV.XFeatures2D;
namespace stabilization
{
    public partial class stabilization : Form
    {
        private Image<Bgr, byte> inputImage,stabilizedImage;
        private Image<Gray, byte> inputGrayImage, inputGrayImagePrevious,imageReference,imageCurrentFrame,imageShifted;
        private Matrix<float> rigidTransform;
        //private FastDetector fastDetector;
        private SIFT fastDetector;
        private Capture cam;
        private uint errorCount;
        private VectorOfKeyPoint vectors;
        private bool captureInProgress;

        public stabilization()
        {
            InitializeComponent();
            inputImage = new Image<Bgr, byte>(640, 480);
            stabilizedImage = new Image<Bgr, byte>(640, 480);
            imageReference = new Image<Gray, byte>(inputImage.Size);
            imageCurrentFrame = new Image<Gray, byte>(inputImage.Size);
            imageShifted = new Image<Gray, byte>(inputImage.Size);
            inputGrayImage = new Image<Gray, byte>(inputImage.Size);
            inputGrayImagePrevious = new Image<Gray, byte>(inputImage.Size);
            fastDetector = new SIFT();
            errorCount = 0;
            imageBoxInput2.Location = new Point(0, 0);
            imageBoxInput2.Parent = imageBoxResult;
            initializingTransform();
            
        }
        
        private void processFrame(object sender, EventArgs arg)
        {          
            cam.Retrieve(inputImage, 3);            
            CvInvoke.CvtColor(inputImage, inputGrayImage, ColorConversion.Bgr2Gray, 0);    
            if (checkBoxOpticalFlow.Checked)
            {
                opticalFlow();               
            }
            imageBoxLiveFeed.Image = inputImage;   
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
                    //   updateMatrices(rigidTransform2D);
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

        private void updateMatrices(Matrix<float> rigidTransform2D)
        {
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

        private void buttonCapture2_Click(object sender, EventArgs e)
        {
            inputGrayImage.CopyTo(imageCurrentFrame);
            imageBoxInput2.Image = imageCurrentFrame;
        }
        
        private void buttonShift_Click(object sender, EventArgs e)
        {
            buttonCapture2_Click(null, null);
          
            var rigidTransformReturn = transformScene(imageReference, imageCurrentFrame);

            CvInvoke.WarpAffine(imageCurrentFrame, imageShifted, rigidTransformReturn,
                   new Size(), Inter.Linear, Warp.Default, BorderType.Constant);
            updateMatrices(rigidTransformReturn);
            imageBoxResult.Image = imageReference;
            var flagErrorImage = false;
            if (rigidTransformReturn.Data[0, 0] + rigidTransformReturn[1,0]== 1.00f)
            {
                flagErrorImage = true;
            }
            var imageCurrentFrameTransparent = transparentImageConverter(imageShifted, (byte)opacity.Value,flagErrorImage);
            imageBoxInput2.Image = imageCurrentFrameTransparent;
        
        }

        private static Image<Bgra, byte> transparentImageConverter(Image<Gray, byte> imageCurrentFrame, byte v, bool flagErrorImage)
        {
            var transparentImage = new Image<Bgra, byte>(imageCurrentFrame.Size);
            
                for (int r = 0; r < imageCurrentFrame.Rows; r++)
                {
                    for (int c = 0; c < imageCurrentFrame.Cols; c++)
                    {
                        transparentImage.Data[r, c, 0] = imageCurrentFrame.Data[r, c, 0];
                        transparentImage.Data[r, c, 1] = imageCurrentFrame.Data[r, c, 0];
                    if (flagErrorImage)
                    {
                        transparentImage.Data[r, c, 2] = 255;
                    }
                    else
                    {
                        transparentImage.Data[r, c, 2] = imageCurrentFrame.Data[r, c, 0];
                    }
                        transparentImage.Data[r, c, 3] = (byte)v;
                    }
                }
                return transparentImage;
           
        }

        public static Matrix<float> transformScene(Image<Gray, byte> imageReference, Image<Gray, byte> imageCurrentFrame)
        {
            using (var fastDetector = new FastDetector())
            {
                var keypoints = fastDetector.Detect(imageReference, null);
                var vectors = new VectorOfKeyPoint(keypoints);
                var aa = vectors.Size;
                var a = new MCvTermCriteria(100);
                byte[] status;
                float[] errors;
                PointF[] corners;
                var vectors2 = vector2Point(vectors);
                CvInvoke.CalcOpticalFlowPyrLK(imageReference, imageCurrentFrame, vectors2,
                    new Size(10, 10), 2, a, out corners, out status, out errors);
                var matches = countNonZero(status);
                try
                {
                    var newRigidTransform = CvInvoke.EstimateRigidTransform(vectors2, corners, false);
                    var newRigidTransform33 = transformTo3D(newRigidTransform);
                    var rigidTransform3 = new Matrix<float>(3, 3);
                    CvInvoke.Invert(newRigidTransform33, rigidTransform3, DecompMethod.Svd);
                    var rigidTransform2D = transformTo2D(rigidTransform3);
                    return rigidTransform2D;
                }
                catch (Exception)
                {
                    float[,] target = {
                         {1f,0,0},
                         {0,1f,0},
                    };
                    var rigidTransform = new Matrix<float>(target);
                    return rigidTransform;
                }
            }
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

        private void buttonCapture1_Click(object sender, EventArgs e)
        {
            inputGrayImage.CopyTo(imageReference);
            imageBoxInput1.Image = imageReference;
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
           
            imageBoxInput2.Image = inputGrayImage;
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
