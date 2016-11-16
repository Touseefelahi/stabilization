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

namespace stabilization
{
    public partial class stabilization : Form
    {
        private Image<Bgr, byte> inputImage;
        private Image<Gray, byte> inputGrayImage;
        private Image<Gray, float> outputCornerImage;
        private Capture cam;
        private bool captureInProgress;

        public stabilization()
        {
            InitializeComponent();
            inputImage = new Image<Bgr, byte>(640, 480);
            inputGrayImage = new Image<Gray, byte>(inputImage.Size);
            outputCornerImage = new Image<Gray, float>(inputImage.Size);
        }

        private void processFrame(object sender, EventArgs arg)
        {
            cam.Retrieve(inputImage, 3);
           
            CvInvoke.CvtColor(inputImage, inputGrayImage, ColorConversion.Bgr2Gray, 0);            
            CvInvoke.CornerHarris(inputGrayImage,outputCornerImage, 3);
      
            CvInvoke.Normalize(outputCornerImage, outputCornerImage, 0, 255, NormType.MinMax, DepthType.Cv32F);         
           
            imageBoxInput.Image = inputGrayImage;
            imageBoxOutput.Image = outputCornerImage;
        }

        private void startClick(object sender, EventArgs e)
        {
            cam = new Capture();
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
                    Application.Idle -= processFrame;
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
