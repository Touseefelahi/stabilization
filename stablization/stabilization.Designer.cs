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
            this.imageBoxInput = new Emgu.CV.UI.ImageBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageBoxOutput = new Emgu.CV.UI.ImageBox();
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
            this.labelTrans3312 = new System.Windows.Forms.Label();
            this.labelTrans3311 = new System.Windows.Forms.Label();
            this.labelTrans3310 = new System.Windows.Forms.Label();
            this.labelTrans3302 = new System.Windows.Forms.Label();
            this.labelTrans3301 = new System.Windows.Forms.Label();
            this.labelTrans3300 = new System.Windows.Forms.Label();
            this.labelTransRigid12 = new System.Windows.Forms.Label();
            this.labelTransRigid11 = new System.Windows.Forms.Label();
            this.labelTransRigid10 = new System.Windows.Forms.Label();
            this.labelTransRigid02 = new System.Windows.Forms.Label();
            this.labelTransRigid01 = new System.Windows.Forms.Label();
            this.labelTransRigid00 = new System.Windows.Forms.Label();
            this.labelSumTransform = new System.Windows.Forms.Label();
            this.labelSumTransformRigid = new System.Windows.Forms.Label();
            this.labelSumTransform33 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBoxInput
            // 
            this.imageBoxInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxInput.Location = new System.Drawing.Point(5, 5);
            this.imageBoxInput.Name = "imageBoxInput";
            this.imageBoxInput.Size = new System.Drawing.Size(640, 480);
            this.imageBoxInput.TabIndex = 2;
            this.imageBoxInput.TabStop = false;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(5, 491);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 70);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.startClick);
            // 
            // imageBoxOutput
            // 
            this.imageBoxOutput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxOutput.Location = new System.Drawing.Point(651, 5);
            this.imageBoxOutput.Name = "imageBoxOutput";
            this.imageBoxOutput.Size = new System.Drawing.Size(640, 480);
            this.imageBoxOutput.TabIndex = 3;
            this.imageBoxOutput.TabStop = false;
            // 
            // detect
            // 
            this.detect.Location = new System.Drawing.Point(86, 491);
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
            this.checkBoxOpticalFlow.Location = new System.Drawing.Point(167, 507);
            this.checkBoxOpticalFlow.Name = "checkBoxOpticalFlow";
            this.checkBoxOpticalFlow.Size = new System.Drawing.Size(81, 17);
            this.checkBoxOpticalFlow.TabIndex = 5;
            this.checkBoxOpticalFlow.Text = "OpticalFlow";
            this.checkBoxOpticalFlow.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(1216, 493);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1216, 518);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total";
            // 
            // checkBoxStabilized
            // 
            this.checkBoxStabilized.AutoSize = true;
            this.checkBoxStabilized.Location = new System.Drawing.Point(167, 530);
            this.checkBoxStabilized.Name = "checkBoxStabilized";
            this.checkBoxStabilized.Size = new System.Drawing.Size(65, 17);
            this.checkBoxStabilized.TabIndex = 8;
            this.checkBoxStabilized.Text = "Stabilize";
            this.checkBoxStabilized.UseVisualStyleBackColor = true;
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(1216, 541);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(34, 13);
            this.labelErrors.TabIndex = 9;
            this.labelErrors.Text = "Errors";
            // 
            // labelTransform00
            // 
            this.labelTransform00.AutoSize = true;
            this.labelTransform00.Location = new System.Drawing.Point(942, 507);
            this.labelTransform00.Name = "labelTransform00";
            this.labelTransform00.Size = new System.Drawing.Size(13, 13);
            this.labelTransform00.TabIndex = 10;
            this.labelTransform00.Text = "0";
            // 
            // labelTransform01
            // 
            this.labelTransform01.AutoSize = true;
            this.labelTransform01.Location = new System.Drawing.Point(1032, 507);
            this.labelTransform01.Name = "labelTransform01";
            this.labelTransform01.Size = new System.Drawing.Size(13, 13);
            this.labelTransform01.TabIndex = 11;
            this.labelTransform01.Text = "0";
            // 
            // labelTransform02
            // 
            this.labelTransform02.AutoSize = true;
            this.labelTransform02.Location = new System.Drawing.Point(1122, 507);
            this.labelTransform02.Name = "labelTransform02";
            this.labelTransform02.Size = new System.Drawing.Size(13, 13);
            this.labelTransform02.TabIndex = 12;
            this.labelTransform02.Text = "0";
            // 
            // labelTransform12
            // 
            this.labelTransform12.AutoSize = true;
            this.labelTransform12.Location = new System.Drawing.Point(1122, 532);
            this.labelTransform12.Name = "labelTransform12";
            this.labelTransform12.Size = new System.Drawing.Size(13, 13);
            this.labelTransform12.TabIndex = 15;
            this.labelTransform12.Text = "0";
            // 
            // labelTransform11
            // 
            this.labelTransform11.AutoSize = true;
            this.labelTransform11.Location = new System.Drawing.Point(1032, 532);
            this.labelTransform11.Name = "labelTransform11";
            this.labelTransform11.Size = new System.Drawing.Size(13, 13);
            this.labelTransform11.TabIndex = 14;
            this.labelTransform11.Text = "0";
            // 
            // labelTransform10
            // 
            this.labelTransform10.AutoSize = true;
            this.labelTransform10.Location = new System.Drawing.Point(942, 532);
            this.labelTransform10.Name = "labelTransform10";
            this.labelTransform10.Size = new System.Drawing.Size(13, 13);
            this.labelTransform10.TabIndex = 13;
            this.labelTransform10.Text = "0";
            // 
            // labelTrans3312
            // 
            this.labelTrans3312.AutoSize = true;
            this.labelTrans3312.Location = new System.Drawing.Point(456, 534);
            this.labelTrans3312.Name = "labelTrans3312";
            this.labelTrans3312.Size = new System.Drawing.Size(13, 13);
            this.labelTrans3312.TabIndex = 21;
            this.labelTrans3312.Text = "0";
            // 
            // labelTrans3311
            // 
            this.labelTrans3311.AutoSize = true;
            this.labelTrans3311.Location = new System.Drawing.Point(366, 534);
            this.labelTrans3311.Name = "labelTrans3311";
            this.labelTrans3311.Size = new System.Drawing.Size(13, 13);
            this.labelTrans3311.TabIndex = 20;
            this.labelTrans3311.Text = "0";
            // 
            // labelTrans3310
            // 
            this.labelTrans3310.AutoSize = true;
            this.labelTrans3310.Location = new System.Drawing.Point(276, 534);
            this.labelTrans3310.Name = "labelTrans3310";
            this.labelTrans3310.Size = new System.Drawing.Size(13, 13);
            this.labelTrans3310.TabIndex = 19;
            this.labelTrans3310.Text = "0";
            // 
            // labelTrans3302
            // 
            this.labelTrans3302.AutoSize = true;
            this.labelTrans3302.Location = new System.Drawing.Point(456, 509);
            this.labelTrans3302.Name = "labelTrans3302";
            this.labelTrans3302.Size = new System.Drawing.Size(13, 13);
            this.labelTrans3302.TabIndex = 18;
            this.labelTrans3302.Text = "0";
            // 
            // labelTrans3301
            // 
            this.labelTrans3301.AutoSize = true;
            this.labelTrans3301.Location = new System.Drawing.Point(366, 509);
            this.labelTrans3301.Name = "labelTrans3301";
            this.labelTrans3301.Size = new System.Drawing.Size(13, 13);
            this.labelTrans3301.TabIndex = 17;
            this.labelTrans3301.Text = "0";
            // 
            // labelTrans3300
            // 
            this.labelTrans3300.AutoSize = true;
            this.labelTrans3300.Location = new System.Drawing.Point(276, 509);
            this.labelTrans3300.Name = "labelTrans3300";
            this.labelTrans3300.Size = new System.Drawing.Size(13, 13);
            this.labelTrans3300.TabIndex = 16;
            this.labelTrans3300.Text = "0";
            // 
            // labelTransRigid12
            // 
            this.labelTransRigid12.AutoSize = true;
            this.labelTransRigid12.Location = new System.Drawing.Point(783, 532);
            this.labelTransRigid12.Name = "labelTransRigid12";
            this.labelTransRigid12.Size = new System.Drawing.Size(13, 13);
            this.labelTransRigid12.TabIndex = 27;
            this.labelTransRigid12.Text = "0";
            // 
            // labelTransRigid11
            // 
            this.labelTransRigid11.AutoSize = true;
            this.labelTransRigid11.Location = new System.Drawing.Point(693, 532);
            this.labelTransRigid11.Name = "labelTransRigid11";
            this.labelTransRigid11.Size = new System.Drawing.Size(13, 13);
            this.labelTransRigid11.TabIndex = 26;
            this.labelTransRigid11.Text = "0";
            // 
            // labelTransRigid10
            // 
            this.labelTransRigid10.AutoSize = true;
            this.labelTransRigid10.Location = new System.Drawing.Point(603, 532);
            this.labelTransRigid10.Name = "labelTransRigid10";
            this.labelTransRigid10.Size = new System.Drawing.Size(13, 13);
            this.labelTransRigid10.TabIndex = 25;
            this.labelTransRigid10.Text = "0";
            // 
            // labelTransRigid02
            // 
            this.labelTransRigid02.AutoSize = true;
            this.labelTransRigid02.Location = new System.Drawing.Point(783, 507);
            this.labelTransRigid02.Name = "labelTransRigid02";
            this.labelTransRigid02.Size = new System.Drawing.Size(13, 13);
            this.labelTransRigid02.TabIndex = 24;
            this.labelTransRigid02.Text = "0";
            // 
            // labelTransRigid01
            // 
            this.labelTransRigid01.AutoSize = true;
            this.labelTransRigid01.Location = new System.Drawing.Point(693, 507);
            this.labelTransRigid01.Name = "labelTransRigid01";
            this.labelTransRigid01.Size = new System.Drawing.Size(13, 13);
            this.labelTransRigid01.TabIndex = 23;
            this.labelTransRigid01.Text = "0";
            // 
            // labelTransRigid00
            // 
            this.labelTransRigid00.AutoSize = true;
            this.labelTransRigid00.Location = new System.Drawing.Point(603, 507);
            this.labelTransRigid00.Name = "labelTransRigid00";
            this.labelTransRigid00.Size = new System.Drawing.Size(13, 13);
            this.labelTransRigid00.TabIndex = 22;
            this.labelTransRigid00.Text = "0";
            // 
            // labelSumTransform
            // 
            this.labelSumTransform.AutoSize = true;
            this.labelSumTransform.Location = new System.Drawing.Point(1153, 522);
            this.labelSumTransform.Name = "labelSumTransform";
            this.labelSumTransform.Size = new System.Drawing.Size(13, 13);
            this.labelSumTransform.TabIndex = 28;
            this.labelSumTransform.Text = "0";
            // 
            // labelSumTransformRigid
            // 
            this.labelSumTransformRigid.AutoSize = true;
            this.labelSumTransformRigid.Location = new System.Drawing.Point(822, 522);
            this.labelSumTransformRigid.Name = "labelSumTransformRigid";
            this.labelSumTransformRigid.Size = new System.Drawing.Size(13, 13);
            this.labelSumTransformRigid.TabIndex = 28;
            this.labelSumTransformRigid.Text = "0";
            // 
            // labelSumTransform33
            // 
            this.labelSumTransform33.AutoSize = true;
            this.labelSumTransform33.Location = new System.Drawing.Point(491, 522);
            this.labelSumTransform33.Name = "labelSumTransform33";
            this.labelSumTransform33.Size = new System.Drawing.Size(13, 13);
            this.labelSumTransform33.TabIndex = 28;
            this.labelSumTransform33.Text = "0";
            // 
            // stabilization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 567);
            this.Controls.Add(this.labelSumTransform33);
            this.Controls.Add(this.labelSumTransformRigid);
            this.Controls.Add(this.labelSumTransform);
            this.Controls.Add(this.labelTransRigid12);
            this.Controls.Add(this.labelTransRigid11);
            this.Controls.Add(this.labelTransRigid10);
            this.Controls.Add(this.labelTransRigid02);
            this.Controls.Add(this.labelTransRigid01);
            this.Controls.Add(this.labelTransRigid00);
            this.Controls.Add(this.labelTrans3312);
            this.Controls.Add(this.labelTrans3311);
            this.Controls.Add(this.labelTrans3310);
            this.Controls.Add(this.labelTrans3302);
            this.Controls.Add(this.labelTrans3301);
            this.Controls.Add(this.labelTrans3300);
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
            this.Controls.Add(this.detect);
            this.Controls.Add(this.imageBoxInput);
            this.Controls.Add(this.imageBoxOutput);
            this.Controls.Add(this.bt_start);
            this.Name = "stabilization";
            this.Text = "Image Stabilization";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxInput;
        private System.Windows.Forms.Button bt_start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Emgu.CV.UI.ImageBox imageBoxOutput;
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
        private System.Windows.Forms.Label labelTrans3312;
        private System.Windows.Forms.Label labelTrans3311;
        private System.Windows.Forms.Label labelTrans3310;
        private System.Windows.Forms.Label labelTrans3302;
        private System.Windows.Forms.Label labelTrans3301;
        private System.Windows.Forms.Label labelTrans3300;
        private System.Windows.Forms.Label labelTransRigid12;
        private System.Windows.Forms.Label labelTransRigid11;
        private System.Windows.Forms.Label labelTransRigid10;
        private System.Windows.Forms.Label labelTransRigid02;
        private System.Windows.Forms.Label labelTransRigid01;
        private System.Windows.Forms.Label labelTransRigid00;
        private System.Windows.Forms.Label labelSumTransform;
        private System.Windows.Forms.Label labelSumTransformRigid;
        private System.Windows.Forms.Label labelSumTransform33;
    }
}

