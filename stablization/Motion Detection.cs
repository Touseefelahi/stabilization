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

namespace WindowsFormsApplication1
{
    public partial class Motion_detection : Form
    {
        Mat frame_in,frame_copy,frame_gray,frame_gray_prev,frame_difference,element_dilate,element_erode;
        Capture cam;
        byte blur_size = 7, canny_th1 = 20, canny_th2 = 255;
        float blur_x = 1f;
        bool flag_motion = false;
        public int CvSize ,dilation_size = 1,erosion_size=1;

      

        private bool captureInProgress;

        private void ProcessFrame(object sender, EventArgs arg)
        {
            
            frame_in = cam.QueryFrame();

            if (flag_motion)
            {
                frame_copy = frame_in.Clone();
   
                CvInvoke.CvtColor(frame_copy, frame_gray, ColorConversion.Bgr2Gray);
                CvInvoke.AbsDiff(frame_gray, frame_gray_prev, frame_difference);
                frame_gray_prev.Dispose();
                frame_gray_prev = frame_gray.Clone();
                CvInvoke.Threshold(frame_difference, frame_difference, canny_th1, canny_th2, ThresholdType.Binary);
                CvInvoke.GaussianBlur(frame_difference, frame_difference, new Size(blur_size, blur_size), blur_x, blur_x);
                CvInvoke.Threshold(frame_difference, frame_difference, canny_th1, canny_th2, ThresholdType.Binary);

                if(erosion_size>0)CvInvoke.Erode(frame_difference, frame_difference, element_erode,new Point (1,1),1,BorderType.Default,new MCvScalar(0));

                if(dilation_size>0)CvInvoke.Dilate(frame_difference, frame_difference, element_dilate,new Point(1, 1), 1, BorderType.Default, new MCvScalar(0));

                Image<Bgr, Byte> frame_display = frame_difference.ToImage<Bgr,Byte>();
                frame_copy.Dispose();
        
                if (imageBox1.Image != null)
                {
                    imageBox1.Image.Dispose();
                }
                imageBox1.Image = frame_display;    

            }
            else
            {
                if (imageBox1.Image != null)
                {
                    imageBox1.Image.Dispose();
                }
                imageBox1.Image = frame_in;
            }

        }

        public Motion_detection()
        {
            InitializeComponent();
            frame_gray_prev = new Mat(480, 640, DepthType.Cv8U, 1);
            frame_gray_prev.SetTo(new MCvScalar(0));

            frame_gray = new Mat(480, 640, DepthType.Cv8U, 1);
            frame_gray.SetTo(new MCvScalar(0));

            frame_difference = new Mat(480, 640, DepthType.Cv8U, 1);
            frame_difference.SetTo(new MCvScalar(0));
            element_dilate = CvInvoke.GetStructuringElement(0, new Size(2 * dilation_size + 1, 2 * dilation_size + 1), new Point(dilation_size, dilation_size));
            element_erode = CvInvoke.GetStructuringElement(0, new Size(2 * erosion_size + 1, 2 * erosion_size + 1), new Point(erosion_size, erosion_size));


        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if (cam == null)
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
            }

            if (cam != null)
            {
                if (captureInProgress)
                {
                    bt_start.Text = "Start!"; //
                    Application.Idle -= ProcessFrame;
                }
                else
                {

                    bt_start.Text = "Stop";
                    Application.Idle += ProcessFrame;
                }
                captureInProgress = !captureInProgress;
            }

        }

        private void bt_edges_Click(object sender, EventArgs e)
        {
            flag_motion = !flag_motion;
            if (flag_motion) bt_edges.Text = "Edges off";
            else bt_edges.Text = "Edges on"; //
        }

        #region Track_bars
        private void trackBar_th1_Scroll(object sender, EventArgs e)
        {
            canny_th1 = (byte)trackBar_th1.Value;
            textBox_thlower.Text = Convert.ToString(canny_th1);
        }
   
        private void trackBar_blur_Scroll(object sender, EventArgs e)
        {
            blur_size = (byte)trackBar_blur.Value;
            if (blur_size % 2 == 0) blur_size += 1;
            textBox_blursize.Text = Convert.ToString(blur_size);
        }

        private void trackBar_blurx_Scroll(object sender, EventArgs e)
        {
            blur_x = (float)(1 + trackBar_blurx.Value / 10.0);
            textBox_blurx.Text = Convert.ToString(blur_x);
        }

        private void trackBar_dilate_Scroll(object sender, EventArgs e)
        {
            dilation_size =  trackBar_dilate.Value;
            textBox_dilate.Text = Convert.ToString(dilation_size);
            element_dilate = CvInvoke.GetStructuringElement(0, new Size(2 * dilation_size + 1, 2 * dilation_size + 1), new Point(dilation_size, dilation_size));

        }

        private void trackBar_erode_Scroll(object sender, EventArgs e)
        {
            erosion_size = trackBar_erode.Value;
            textBox_erode.Text = Convert.ToString(erosion_size);
            element_erode = CvInvoke.GetStructuringElement(0, new Size(2 * erosion_size + 1, 2 * erosion_size + 1), new Point(erosion_size, erosion_size));

        }

        #endregion
    }
}
