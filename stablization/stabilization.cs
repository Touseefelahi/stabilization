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
        private Image<Bgr, byte> inputImage;
        private Image<Gray, byte> inputGrayImage, inputGrayImagePrevious;
        private FastDetector fastDetector;
        private Capture cam;
        private VectorOfKeyPoint vectors;
        private bool captureInProgress;

        public stabilization()
        {
            InitializeComponent();
            inputImage = new Image<Bgr, byte>(640, 480);
            inputGrayImage = new Image<Gray, byte>(inputImage.Size);
            inputGrayImagePrevious = new Image<Gray, byte>(inputImage.Size);
            fastDetector = new FastDetector();
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
            imageBoxOutput.Image = inputGrayImagePrevious;
            imageBoxInput.Image = inputImage;   
        }

        private void opticalFlow()
        {
            var a = new MCvTermCriteria(100);
            byte[] status2;
            float[] errors2;
            PointF[] corners2;
            var vectors2 = vector2Point(vectors);
            var keypoints = fastDetector.Detect(inputGrayImage, null);
            var corners = new VectorOfKeyPoint(keypoints);
            corners2 = vector2Point(corners);

            CvInvoke.CalcOpticalFlowPyrLK(inputGrayImagePrevious, inputGrayImage, vectors2, new Size(10, 10), 3, a, out corners2, out status2, out errors2);
            var matches = countNonZero(status2);
            labelStatus.Text = "Found =" + Convert.ToString(matches);
            labelTotal.Text = "Total =" + Convert.ToString(errors2.Count());
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

        private void detect_Click(object sender, EventArgs e)
        {
            var keypoints = fastDetector.Detect(inputGrayImage, null);
            vectors = new VectorOfKeyPoint(keypoints);
            inputGrayImage.CopyTo(inputGrayImagePrevious);
            var aa = vectors.Size;
            for (int i = 0; i < aa; i++)
            {
                CvInvoke.Circle(inputGrayImage, new Point((int)vectors[i].Point.X, (int)vectors[i].Point.Y), 2, new MCvScalar(0, 0, 255));
            }
            inputGrayImage.CopyTo(inputGrayImagePrevious);
            imageBoxOutput.Image = inputGrayImage;
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
