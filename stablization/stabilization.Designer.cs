namespace stabilization
{
    partial class stabilization
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
            this.imageBoxInput1 = new Emgu.CV.UI.ImageBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageBoxInput2 = new Emgu.CV.UI.ImageBox();
            this.detect = new System.Windows.Forms.Button();
            this.checkBoxOpticalFlow = new System.Windows.Forms.CheckBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.checkBoxStabilized = new System.Windows.Forms.CheckBox();
            this.labelErrors = new System.Windows.Forms.Label();
            this.labelTransform00 = new System.Windows.Forms.Label();
            this.labelTransform01 = new System.Windows.Forms.Label();
            this.labelTransform02 = new System.Windows.Forms.Label();
            this.labelTransform12 = new System.Windows.Forms.Label();
            this.labelTransform11 = new System.Windows.Forms.Label();
            this.labelTransform10 = new System.Windows.Forms.Label();
            this.labelSumTransform = new System.Windows.Forms.Label();
            this.imageBoxResult = new Emgu.CV.UI.ImageBox();
            this.buttonCapture1 = new System.Windows.Forms.Button();
            this.buttonCapture2 = new System.Windows.Forms.Button();
            this.buttonShift = new System.Windows.Forms.Button();
            this.imageBoxLiveFeed = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLiveFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBoxInput1
            // 
            this.imageBoxInput1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBoxInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxInput1.Location = new System.Drawing.Point(5, 5);
            this.imageBoxInput1.Name = "imageBoxInput1";
            this.imageBoxInput1.Size = new System.Drawing.Size(640, 480);
            this.imageBoxInput1.TabIndex = 2;
            this.imageBoxInput1.TabStop = false;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(660, 890);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 70);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.startClick);
            // 
            // imageBoxInput2
            // 
            this.imageBoxInput2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBoxInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxInput2.Location = new System.Drawing.Point(5, 491);
            this.imageBoxInput2.Name = "imageBoxInput2";
            this.imageBoxInput2.Size = new System.Drawing.Size(640, 480);
            this.imageBoxInput2.TabIndex = 3;
            this.imageBoxInput2.TabStop = false;
            // 
            // detect
            // 
            this.detect.Location = new System.Drawing.Point(741, 890);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(75, 70);
            this.detect.TabIndex = 4;
            this.detect.Text = "update";
            this.detect.UseVisualStyleBackColor = true;
            this.detect.Click += new System.EventHandler(this.updateReference);
            // 
            // checkBoxOpticalFlow
            // 
            this.checkBoxOpticalFlow.AutoSize = true;
            this.checkBoxOpticalFlow.Location = new System.Drawing.Point(822, 890);
            this.checkBoxOpticalFlow.Name = "checkBoxOpticalFlow";
            this.checkBoxOpticalFlow.Size = new System.Drawing.Size(81, 17);
            this.checkBoxOpticalFlow.TabIndex = 5;
            this.checkBoxOpticalFlow.Text = "OpticalFlow";
            this.checkBoxOpticalFlow.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(1178, 890);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1178, 915);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total";
            // 
            // checkBoxStabilized
            // 
            this.checkBoxStabilized.AutoSize = true;
            this.checkBoxStabilized.Location = new System.Drawing.Point(822, 913);
            this.checkBoxStabilized.Name = "checkBoxStabilized";
            this.checkBoxStabilized.Size = new System.Drawing.Size(65, 17);
            this.checkBoxStabilized.TabIndex = 8;
            this.checkBoxStabilized.Text = "Stabilize";
            this.checkBoxStabilized.UseVisualStyleBackColor = true;
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(1178, 938);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(34, 13);
            this.labelErrors.TabIndex = 9;
            this.labelErrors.Text = "Errors";
            // 
            // labelTransform00
            // 
            this.labelTransform00.AutoSize = true;
            this.labelTransform00.Location = new System.Drawing.Point(657, 493);
            this.labelTransform00.Name = "labelTransform00";
            this.labelTransform00.Size = new System.Drawing.Size(13, 13);
            this.labelTransform00.TabIndex = 10;
            this.labelTransform00.Text = "0";
            // 
            // labelTransform01
            // 
            this.labelTransform01.AutoSize = true;
            this.labelTransform01.Location = new System.Drawing.Point(747, 493);
            this.labelTransform01.Name = "labelTransform01";
            this.labelTransform01.Size = new System.Drawing.Size(13, 13);
            this.labelTransform01.TabIndex = 11;
            this.labelTransform01.Text = "0";
            // 
            // labelTransform02
            // 
            this.labelTransform02.AutoSize = true;
            this.labelTransform02.Location = new System.Drawing.Point(837, 493);
            this.labelTransform02.Name = "labelTransform02";
            this.labelTransform02.Size = new System.Drawing.Size(13, 13);
            this.labelTransform02.TabIndex = 12;
            this.labelTransform02.Text = "0";
            // 
            // labelTransform12
            // 
            this.labelTransform12.AutoSize = true;
            this.labelTransform12.Location = new System.Drawing.Point(837, 518);
            this.labelTransform12.Name = "labelTransform12";
            this.labelTransform12.Size = new System.Drawing.Size(13, 13);
            this.labelTransform12.TabIndex = 15;
            this.labelTransform12.Text = "0";
            // 
            // labelTransform11
            // 
            this.labelTransform11.AutoSize = true;
            this.labelTransform11.Location = new System.Drawing.Point(747, 518);
            this.labelTransform11.Name = "labelTransform11";
            this.labelTransform11.Size = new System.Drawing.Size(13, 13);
            this.labelTransform11.TabIndex = 14;
            this.labelTransform11.Text = "0";
            // 
            // labelTransform10
            // 
            this.labelTransform10.AutoSize = true;
            this.labelTransform10.Location = new System.Drawing.Point(657, 518);
            this.labelTransform10.Name = "labelTransform10";
            this.labelTransform10.Size = new System.Drawing.Size(13, 13);
            this.labelTransform10.TabIndex = 13;
            this.labelTransform10.Text = "0";
            // 
            // labelSumTransform
            // 
            this.labelSumTransform.AutoSize = true;
            this.labelSumTransform.Location = new System.Drawing.Point(868, 508);
            this.labelSumTransform.Name = "labelSumTransform";
            this.labelSumTransform.Size = new System.Drawing.Size(13, 13);
            this.labelSumTransform.TabIndex = 28;
            this.labelSumTransform.Text = "0";
            // 
            // imageBoxResult
            // 
            this.imageBoxResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxResult.Location = new System.Drawing.Point(651, 5);
            this.imageBoxResult.Name = "imageBoxResult";
            this.imageBoxResult.Size = new System.Drawing.Size(640, 480);
            this.imageBoxResult.TabIndex = 29;
            this.imageBoxResult.TabStop = false;
            // 
            // buttonCapture1
            // 
            this.buttonCapture1.Location = new System.Drawing.Point(660, 724);
            this.buttonCapture1.Name = "buttonCapture1";
            this.buttonCapture1.Size = new System.Drawing.Size(75, 70);
            this.buttonCapture1.TabIndex = 4;
            this.buttonCapture1.Text = "Capture Reference";
            this.buttonCapture1.UseVisualStyleBackColor = true;
            this.buttonCapture1.Click += new System.EventHandler(this.buttonCapture1_Click);
            // 
            // buttonCapture2
            // 
            this.buttonCapture2.Location = new System.Drawing.Point(741, 724);
            this.buttonCapture2.Name = "buttonCapture2";
            this.buttonCapture2.Size = new System.Drawing.Size(75, 70);
            this.buttonCapture2.TabIndex = 4;
            this.buttonCapture2.Text = "Capture Current Frame";
            this.buttonCapture2.UseVisualStyleBackColor = true;
            this.buttonCapture2.Click += new System.EventHandler(this.buttonCapture2_Click);
            // 
            // buttonShift
            // 
            this.buttonShift.Location = new System.Drawing.Point(822, 724);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(75, 70);
            this.buttonShift.TabIndex = 4;
            this.buttonShift.Text = "Shift";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // imageBoxLiveFeed
            // 
            this.imageBoxLiveFeed.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBoxLiveFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxLiveFeed.Location = new System.Drawing.Point(973, 491);
            this.imageBoxLiveFeed.Name = "imageBoxLiveFeed";
            this.imageBoxLiveFeed.Size = new System.Drawing.Size(318, 239);
            this.imageBoxLiveFeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxLiveFeed.TabIndex = 30;
            this.imageBoxLiveFeed.TabStop = false;
            // 
            // stabilization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 972);
            this.Controls.Add(this.imageBoxLiveFeed);
            this.Controls.Add(this.imageBoxResult);
            this.Controls.Add(this.labelSumTransform);
            this.Controls.Add(this.labelTransform12);
            this.Controls.Add(this.labelTransform11);
            this.Controls.Add(this.labelTransform10);
            this.Controls.Add(this.labelTransform02);
            this.Controls.Add(this.labelTransform01);
            this.Controls.Add(this.labelTransform00);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.checkBoxStabilized);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.checkBoxOpticalFlow);
            this.Controls.Add(this.buttonCapture1);
            this.Controls.Add(this.buttonCapture2);
            this.Controls.Add(this.buttonShift);
            this.Controls.Add(this.detect);
            this.Controls.Add(this.imageBoxInput1);
            this.Controls.Add(this.imageBoxInput2);
            this.Controls.Add(this.bt_start);
            this.Name = "stabilization";
            this.Text = "Image Stabilization";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLiveFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxInput1;
        private System.Windows.Forms.Button bt_start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Emgu.CV.UI.ImageBox imageBoxInput2;
        private System.Windows.Forms.Button detect;
        private System.Windows.Forms.CheckBox checkBoxOpticalFlow;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.CheckBox checkBoxStabilized;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Label labelTransform00;
        private System.Windows.Forms.Label labelTransform01;
        private System.Windows.Forms.Label labelTransform02;
        private System.Windows.Forms.Label labelTransform12;
        private System.Windows.Forms.Label labelTransform11;
        private System.Windows.Forms.Label labelTransform10;
        private System.Windows.Forms.Label labelSumTransform;
        private Emgu.CV.UI.ImageBox imageBoxResult;
        private System.Windows.Forms.Button buttonCapture1;
        private System.Windows.Forms.Button buttonCapture2;
        private System.Windows.Forms.Button buttonShift;
        private Emgu.CV.UI.ImageBox imageBoxLiveFeed;
    }
}

