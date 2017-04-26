namespace EEPrep
{
    partial class WelcomingScreen
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
            this.WelcomingLabel = new System.Windows.Forms.Label();
            this.WelcomingLabel2 = new System.Windows.Forms.Label();
            this.StudentButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.WelcomingPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomingLabel
            // 
            this.WelcomingLabel.AutoSize = true;
            this.WelcomingLabel.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomingLabel.Location = new System.Drawing.Point(152, 32);
            this.WelcomingLabel.Name = "WelcomingLabel";
            this.WelcomingLabel.Size = new System.Drawing.Size(356, 44);
            this.WelcomingLabel.TabIndex = 1;
            this.WelcomingLabel.Text = "Welcome To Your";
            this.WelcomingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WelcomingLabel2
            // 
            this.WelcomingLabel2.AutoSize = true;
            this.WelcomingLabel2.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomingLabel2.Location = new System.Drawing.Point(88, 305);
            this.WelcomingLabel2.Name = "WelcomingLabel2";
            this.WelcomingLabel2.Size = new System.Drawing.Size(470, 44);
            this.WelcomingLabel2.TabIndex = 3;
            this.WelcomingLabel2.Text = "Exit Exam Preparation \r\n";
            // 
            // StudentButton
            // 
            this.StudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentButton.Location = new System.Drawing.Point(793, 220);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(126, 38);
            this.StudentButton.TabIndex = 5;
            this.StudentButton.Text = "Student Login";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(248, 417);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(110, 28);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // WelcomingPictureBox
            // 
            this.WelcomingPictureBox.Image = global::EEPrep.Properties.Resources.EEPrepLogo;
            this.WelcomingPictureBox.Location = new System.Drawing.Point(160, 91);
            this.WelcomingPictureBox.Name = "WelcomingPictureBox";
            this.WelcomingPictureBox.Size = new System.Drawing.Size(310, 200);
            this.WelcomingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WelcomingPictureBox.TabIndex = 2;
            this.WelcomingPictureBox.TabStop = false;
            // 
            // WelcomingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(966, 510);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.WelcomingLabel2);
            this.Controls.Add(this.WelcomingPictureBox);
            this.Controls.Add(this.WelcomingLabel);
            this.Name = "WelcomingScreen";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.WelcomingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WelcomingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomingLabel;
        private System.Windows.Forms.PictureBox WelcomingPictureBox;
        private System.Windows.Forms.Label WelcomingLabel2;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button aboutButton;
    }
}