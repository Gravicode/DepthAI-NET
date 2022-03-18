namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.TxtInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox1
            // 
            this.PicBox1.Location = new System.Drawing.Point(12, 12);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(300, 300);
            this.PicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox1.TabIndex = 0;
            this.PicBox1.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(318, 242);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(94, 29);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(318, 277);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(94, 29);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "S&top";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // TxtInfo
            // 
            this.TxtInfo.Location = new System.Drawing.Point(318, 12);
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(265, 224);
            this.TxtInfo.TabIndex = 4;
            this.TxtInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.PicBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PicBox1;
        private Button BtnStart;
        private Button BtnStop;
        private RichTextBox TxtInfo;
    }
}