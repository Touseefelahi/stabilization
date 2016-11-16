namespace WindowsFormsApplication1
{
    partial class Motion_detection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_edges = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.borderPanel1 = new Microsoft.TeamFoundation.Client.BorderPanel();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.trackBar_th1 = new System.Windows.Forms.TrackBar();
            this.trackBar_blur = new System.Windows.Forms.TrackBar();
            this.trackBar_blurx = new System.Windows.Forms.TrackBar();
            this.label_th0 = new System.Windows.Forms.Label();
            this.label_blur = new System.Windows.Forms.Label();
            this.label_blurx = new System.Windows.Forms.Label();
            this.textBox_thlower = new System.Windows.Forms.TextBox();
            this.textBox_blursize = new System.Windows.Forms.TextBox();
            this.textBox_blurx = new System.Windows.Forms.TextBox();
            this.textBox_erode = new System.Windows.Forms.TextBox();
            this.label_Erode = new System.Windows.Forms.Label();
            this.trackBar_erode = new System.Windows.Forms.TrackBar();
            this.textBox_dilate = new System.Windows.Forms.TextBox();
            this.label_dilate = new System.Windows.Forms.Label();
            this.trackBar_dilate = new System.Windows.Forms.TrackBar();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blurx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_erode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_dilate)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(18, 500);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 70);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_edges
            // 
            this.bt_edges.Location = new System.Drawing.Point(99, 500);
            this.bt_edges.Name = "bt_edges";
            this.bt_edges.Size = new System.Drawing.Size(75, 70);
            this.bt_edges.TabIndex = 4;
            this.bt_edges.Text = "Motion Detection";
            this.bt_edges.UseVisualStyleBackColor = true;
            this.bt_edges.Click += new System.EventHandler(this.bt_edges_Click);
            // 
            // borderPanel1
            // 
            this.borderPanel1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.borderPanel1.BorderPadding = new System.Windows.Forms.Padding(0);
            this.borderPanel1.BorderSides = ((Microsoft.TeamFoundation.Client.BorderPanel.Sides)((((Microsoft.TeamFoundation.Client.BorderPanel.Sides.Top | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Bottom)
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Left)
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Right)));
            this.borderPanel1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel1.Controls.Add(this.imageBox1);
            this.borderPanel1.InnerColor = System.Drawing.SystemColors.Control;
            this.borderPanel1.Location = new System.Drawing.Point(3, 3);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(644, 484);
            this.borderPanel1.TabIndex = 5;
            this.borderPanel1.UseInnerColor = false;
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBox1.Location = new System.Drawing.Point(2, 2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 480);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // trackBar_th1
            // 
            this.trackBar_th1.Location = new System.Drawing.Point(246, 491);
            this.trackBar_th1.Maximum = 255;
            this.trackBar_th1.Name = "trackBar_th1";
            this.trackBar_th1.Size = new System.Drawing.Size(352, 45);
            this.trackBar_th1.TabIndex = 6;
            this.trackBar_th1.Value = 20;
            this.trackBar_th1.Scroll += new System.EventHandler(this.trackBar_th1_Scroll);
            // 
            // trackBar_blur
            // 
            this.trackBar_blur.Location = new System.Drawing.Point(246, 522);
            this.trackBar_blur.Maximum = 21;
            this.trackBar_blur.Name = "trackBar_blur";
            this.trackBar_blur.Size = new System.Drawing.Size(352, 45);
            this.trackBar_blur.TabIndex = 8;
            this.trackBar_blur.Scroll += new System.EventHandler(this.trackBar_blur_Scroll);
            // 
            // trackBar_blurx
            // 
            this.trackBar_blurx.Location = new System.Drawing.Point(246, 550);
            this.trackBar_blurx.Maximum = 20;
            this.trackBar_blurx.Name = "trackBar_blurx";
            this.trackBar_blurx.Size = new System.Drawing.Size(352, 45);
            this.trackBar_blurx.TabIndex = 9;
            this.trackBar_blurx.Scroll += new System.EventHandler(this.trackBar_blurx_Scroll);
            // 
            // label_th0
            // 
            this.label_th0.AutoSize = true;
            this.label_th0.Location = new System.Drawing.Point(193, 497);
            this.label_th0.Name = "label_th0";
            this.label_th0.Size = new System.Drawing.Size(52, 13);
            this.label_th0.TabIndex = 12;
            this.label_th0.Text = "Senstivity";
            // 
            // label_blur
            // 
            this.label_blur.AutoSize = true;
            this.label_blur.Location = new System.Drawing.Point(197, 526);
            this.label_blur.Name = "label_blur";
            this.label_blur.Size = new System.Drawing.Size(48, 13);
            this.label_blur.TabIndex = 15;
            this.label_blur.Text = "Blur Size";
            // 
            // label_blurx
            // 
            this.label_blurx.AutoSize = true;
            this.label_blurx.Location = new System.Drawing.Point(207, 554);
            this.label_blurx.Name = "label_blurx";
            this.label_blurx.Size = new System.Drawing.Size(35, 13);
            this.label_blurx.TabIndex = 16;
            this.label_blurx.Text = "Blur X";
            // 
            // textBox_thlower
            // 
            this.textBox_thlower.Location = new System.Drawing.Point(604, 494);
            this.textBox_thlower.Name = "textBox_thlower";
            this.textBox_thlower.Size = new System.Drawing.Size(36, 20);
            this.textBox_thlower.TabIndex = 18;
            // 
            // textBox_blursize
            // 
            this.textBox_blursize.Location = new System.Drawing.Point(604, 526);
            this.textBox_blursize.Name = "textBox_blursize";
            this.textBox_blursize.Size = new System.Drawing.Size(36, 20);
            this.textBox_blursize.TabIndex = 21;
            // 
            // textBox_blurx
            // 
            this.textBox_blurx.Location = new System.Drawing.Point(604, 552);
            this.textBox_blurx.Name = "textBox_blurx";
            this.textBox_blurx.Size = new System.Drawing.Size(36, 20);
            this.textBox_blurx.TabIndex = 22;
            // 
            // textBox_erode
            // 
            this.textBox_erode.Location = new System.Drawing.Point(604, 580);
            this.textBox_erode.Name = "textBox_erode";
            this.textBox_erode.Size = new System.Drawing.Size(36, 20);
            this.textBox_erode.TabIndex = 25;
            // 
            // label_Erode
            // 
            this.label_Erode.AutoSize = true;
            this.label_Erode.Location = new System.Drawing.Point(207, 582);
            this.label_Erode.Name = "label_Erode";
            this.label_Erode.Size = new System.Drawing.Size(35, 13);
            this.label_Erode.TabIndex = 24;
            this.label_Erode.Text = "Erode";
            // 
            // trackBar_erode
            // 
            this.trackBar_erode.Location = new System.Drawing.Point(246, 578);
            this.trackBar_erode.Maximum = 20;
            this.trackBar_erode.Name = "trackBar_erode";
            this.trackBar_erode.Size = new System.Drawing.Size(352, 45);
            this.trackBar_erode.TabIndex = 23;
            this.trackBar_erode.Value = 1;
            this.trackBar_erode.Scroll += new System.EventHandler(this.trackBar_erode_Scroll);
            // 
            // textBox_dilate
            // 
            this.textBox_dilate.Location = new System.Drawing.Point(604, 609);
            this.textBox_dilate.Name = "textBox_dilate";
            this.textBox_dilate.Size = new System.Drawing.Size(36, 20);
            this.textBox_dilate.TabIndex = 28;
            // 
            // label_dilate
            // 
            this.label_dilate.AutoSize = true;
            this.label_dilate.Location = new System.Drawing.Point(207, 611);
            this.label_dilate.Name = "label_dilate";
            this.label_dilate.Size = new System.Drawing.Size(34, 13);
            this.label_dilate.TabIndex = 27;
            this.label_dilate.Text = "Dilate";
            // 
            // trackBar_dilate
            // 
            this.trackBar_dilate.Location = new System.Drawing.Point(246, 607);
            this.trackBar_dilate.Maximum = 20;
            this.trackBar_dilate.Name = "trackBar_dilate";
            this.trackBar_dilate.Size = new System.Drawing.Size(352, 45);
            this.trackBar_dilate.TabIndex = 26;
            this.trackBar_dilate.Value = 1;
            this.trackBar_dilate.Scroll += new System.EventHandler(this.trackBar_dilate_Scroll);
            // 
            // Optical_Flow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 645);
            this.Controls.Add(this.textBox_dilate);
            this.Controls.Add(this.label_dilate);
            this.Controls.Add(this.trackBar_dilate);
            this.Controls.Add(this.textBox_erode);
            this.Controls.Add(this.label_Erode);
            this.Controls.Add(this.trackBar_erode);
            this.Controls.Add(this.textBox_blurx);
            this.Controls.Add(this.textBox_blursize);
            this.Controls.Add(this.textBox_thlower);
            this.Controls.Add(this.label_blurx);
            this.Controls.Add(this.label_blur);
            this.Controls.Add(this.label_th0);
            this.Controls.Add(this.trackBar_blurx);
            this.Controls.Add(this.trackBar_blur);
            this.Controls.Add(this.trackBar_th1);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.bt_edges);
            this.Controls.Add(this.bt_start);
            this.Name = "Optical_Flow";
            this.Text = "Motion Detection";
            this.borderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blurx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_erode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_dilate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_edges;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.TeamFoundation.Client.BorderPanel borderPanel1;
        private System.Windows.Forms.TrackBar trackBar_th1;
        private System.Windows.Forms.TrackBar trackBar_blur;
        private System.Windows.Forms.TrackBar trackBar_blurx;
        private System.Windows.Forms.Label label_th0;
        private System.Windows.Forms.Label label_blur;
        private System.Windows.Forms.Label label_blurx;
        private System.Windows.Forms.TextBox textBox_thlower;
        private System.Windows.Forms.TextBox textBox_blursize;
        private System.Windows.Forms.TextBox textBox_blurx;
        private System.Windows.Forms.TextBox textBox_erode;
        private System.Windows.Forms.Label label_Erode;
        private System.Windows.Forms.TrackBar trackBar_erode;
        private System.Windows.Forms.TextBox textBox_dilate;
        private System.Windows.Forms.Label label_dilate;
        private System.Windows.Forms.TrackBar trackBar_dilate;
    }
}

