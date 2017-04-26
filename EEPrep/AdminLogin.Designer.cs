namespace EEPrep
{
    partial class AdminLogin
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
            this.unameTextbox = new System.Windows.Forms.TextBox();
            this.pWordTextbox = new System.Windows.Forms.TextBox();
            this.AdminUserName = new System.Windows.Forms.Label();
            this.pwordLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unameTextbox
            // 
            this.unameTextbox.Location = new System.Drawing.Point(388, 172);
            this.unameTextbox.Name = "unameTextbox";
            this.unameTextbox.Size = new System.Drawing.Size(134, 20);
            this.unameTextbox.TabIndex = 0;
            // 
            // pWordTextbox
            // 
            this.pWordTextbox.Location = new System.Drawing.Point(388, 257);
            this.pWordTextbox.Name = "pWordTextbox";
            this.pWordTextbox.Size = new System.Drawing.Size(134, 20);
            this.pWordTextbox.TabIndex = 1;
            // 
            // AdminUserName
            // 
            this.AdminUserName.AutoSize = true;
            this.AdminUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUserName.Location = new System.Drawing.Point(261, 172);
            this.AdminUserName.Name = "AdminUserName";
            this.AdminUserName.Size = new System.Drawing.Size(91, 20);
            this.AdminUserName.TabIndex = 2;
            this.AdminUserName.Text = "Username";
            // 
            // pwordLabel
            // 
            this.pwordLabel.AutoSize = true;
            this.pwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwordLabel.Location = new System.Drawing.Point(266, 257);
            this.pwordLabel.Name = "pwordLabel";
            this.pwordLabel.Size = new System.Drawing.Size(86, 20);
            this.pwordLabel.TabIndex = 3;
            this.pwordLabel.Text = "Password";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(413, 316);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(84, 29);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(902, 507);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.pwordLabel);
            this.Controls.Add(this.AdminUserName);
            this.Controls.Add(this.pWordTextbox);
            this.Controls.Add(this.unameTextbox);
            this.Name = "AdminLogin";
            this.Text = "Administrator Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unameTextbox;
        private System.Windows.Forms.TextBox pWordTextbox;
        private System.Windows.Forms.Label AdminUserName;
        private System.Windows.Forms.Label pwordLabel;
        private System.Windows.Forms.Button NextButton;
    }
}