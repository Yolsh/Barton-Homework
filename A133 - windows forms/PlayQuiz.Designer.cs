namespace A133___windows_forms
{
    partial class PlayQuiz
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
            this.FilenameText = new System.Windows.Forms.TextBox();
            this.EnterFilename = new System.Windows.Forms.Button();
            this.CheckAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilenameText
            // 
            this.FilenameText.Location = new System.Drawing.Point(169, 41);
            this.FilenameText.Name = "FilenameText";
            this.FilenameText.Size = new System.Drawing.Size(203, 20);
            this.FilenameText.TabIndex = 0;
            // 
            // EnterFilename
            // 
            this.EnterFilename.Location = new System.Drawing.Point(32, 41);
            this.EnterFilename.Name = "EnterFilename";
            this.EnterFilename.Size = new System.Drawing.Size(106, 20);
            this.EnterFilename.TabIndex = 1;
            this.EnterFilename.Text = "enter filename";
            this.EnterFilename.UseVisualStyleBackColor = true;
            this.EnterFilename.Click += new System.EventHandler(this.EnterFilename_Click);
            // 
            // CheckAns
            // 
            this.CheckAns.Location = new System.Drawing.Point(640, 38);
            this.CheckAns.Name = "CheckAns";
            this.CheckAns.Size = new System.Drawing.Size(148, 23);
            this.CheckAns.TabIndex = 2;
            this.CheckAns.Text = "Check Answers";
            this.CheckAns.UseVisualStyleBackColor = true;
            this.CheckAns.Visible = false;
            this.CheckAns.Click += new System.EventHandler(this.CheckAns_Click);
            // 
            // PlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckAns);
            this.Controls.Add(this.EnterFilename);
            this.Controls.Add(this.FilenameText);
            this.Name = "PlayQuiz";
            this.Text = "PlayQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilenameText;
        private System.Windows.Forms.Button EnterFilename;
        private System.Windows.Forms.Button CheckAns;
    }
}