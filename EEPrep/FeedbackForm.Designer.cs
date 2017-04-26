namespace EEPrep
{
    partial class FeedbackForm
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
            this.quesAttemptlabel = new System.Windows.Forms.Label();
            this.quesCorrLabel = new System.Windows.Forms.Label();
            this.topicDescripLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quesAttemptlabel
            // 
            this.quesAttemptlabel.AutoSize = true;
            this.quesAttemptlabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesAttemptlabel.Location = new System.Drawing.Point(120, 79);
            this.quesAttemptlabel.Name = "quesAttemptlabel";
            this.quesAttemptlabel.Size = new System.Drawing.Size(330, 23);
            this.quesAttemptlabel.TabIndex = 0;
            this.quesAttemptlabel.Text = "Number of Questions Attempted";
            // 
            // quesCorrLabel
            // 
            this.quesCorrLabel.AutoSize = true;
            this.quesCorrLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesCorrLabel.Location = new System.Drawing.Point(195, 148);
            this.quesCorrLabel.Name = "quesCorrLabel";
            this.quesCorrLabel.Size = new System.Drawing.Size(255, 23);
            this.quesCorrLabel.TabIndex = 1;
            this.quesCorrLabel.Text = "Number You Got Correct";
            // 
            // topicDescripLabel
            // 
            this.topicDescripLabel.AutoSize = true;
            this.topicDescripLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicDescripLabel.Location = new System.Drawing.Point(139, 209);
            this.topicDescripLabel.Name = "topicDescripLabel";
            this.topicDescripLabel.Size = new System.Drawing.Size(311, 23);
            this.topicDescripLabel.TabIndex = 2;
            this.topicDescripLabel.Text = "Topics for Incorrect Questions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "A copy of your results will be emailed to you ";
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(783, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topicDescripLabel);
            this.Controls.Add(this.quesCorrLabel);
            this.Controls.Add(this.quesAttemptlabel);
            this.Name = "FeedbackForm";
            this.Text = "Quiz Performance Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quesAttemptlabel;
        private System.Windows.Forms.Label quesCorrLabel;
        private System.Windows.Forms.Label topicDescripLabel;
        private System.Windows.Forms.Label label1;
    }
}