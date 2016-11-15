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
            // stabilization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 567);
            this.Controls.Add(this.imageBoxInput);
            this.Controls.Add(this.imageBoxOutput);
            this.Controls.Add(this.bt_start);
            this.Name = "stabilization";
            this.Text = "Image Stabilization";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxInput;
        private System.Windows.Forms.Button bt_start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Emgu.CV.UI.ImageBox imageBoxOutput;
    }
}

