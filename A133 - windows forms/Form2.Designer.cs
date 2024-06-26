namespace A133___windows_forms
{
    partial class CreateQuiz
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
            this.QuizNameGroup = new System.Windows.Forms.GroupBox();
            this.QuizQuestionsGroup = new System.Windows.Forms.GroupBox();
            this.QuizNameText = new System.Windows.Forms.TextBox();
            this.QuestionNumberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AnsAText = new System.Windows.Forms.TextBox();
            this.AnsDText = new System.Windows.Forms.TextBox();
            this.AnsCText = new System.Windows.Forms.TextBox();
            this.AnsBText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CorrectAnsCombo = new System.Windows.Forms.ComboBox();
            this.AddQBtn = new System.Windows.Forms.Button();
            this.ClearQ = new System.Windows.Forms.Button();
            this.mmReturn = new System.Windows.Forms.Button();
            this.QuizNameGroup.SuspendLayout();
            this.QuizQuestionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuizNameGroup
            // 
            this.QuizNameGroup.Controls.Add(this.QuizNameText);
            this.QuizNameGroup.Location = new System.Drawing.Point(12, 12);
            this.QuizNameGroup.Name = "QuizNameGroup";
            this.QuizNameGroup.Size = new System.Drawing.Size(296, 84);
            this.QuizNameGroup.TabIndex = 0;
            this.QuizNameGroup.TabStop = false;
            this.QuizNameGroup.Text = "Quiz Name";
            // 
            // QuizQuestionsGroup
            // 
            this.QuizQuestionsGroup.Controls.Add(this.CorrectAnsCombo);
            this.QuizQuestionsGroup.Controls.Add(this.label8);
            this.QuizQuestionsGroup.Controls.Add(this.AnsBText);
            this.QuizQuestionsGroup.Controls.Add(this.AnsCText);
            this.QuizQuestionsGroup.Controls.Add(this.AnsDText);
            this.QuizQuestionsGroup.Controls.Add(this.AnsAText);
            this.QuizQuestionsGroup.Controls.Add(this.label7);
            this.QuizQuestionsGroup.Controls.Add(this.label6);
            this.QuizQuestionsGroup.Controls.Add(this.label5);
            this.QuizQuestionsGroup.Controls.Add(this.label4);
            this.QuizQuestionsGroup.Controls.Add(this.label3);
            this.QuizQuestionsGroup.Controls.Add(this.QuestionText);
            this.QuizQuestionsGroup.Controls.Add(this.label2);
            this.QuizQuestionsGroup.Controls.Add(this.label1);
            this.QuizQuestionsGroup.Controls.Add(this.QuestionNumberText);
            this.QuizQuestionsGroup.Location = new System.Drawing.Point(10, 102);
            this.QuizQuestionsGroup.Name = "QuizQuestionsGroup";
            this.QuizQuestionsGroup.Size = new System.Drawing.Size(779, 341);
            this.QuizQuestionsGroup.TabIndex = 1;
            this.QuizQuestionsGroup.TabStop = false;
            this.QuizQuestionsGroup.Text = "QuizQuestions";
            // 
            // QuizNameText
            // 
            this.QuizNameText.Location = new System.Drawing.Point(20, 38);
            this.QuizNameText.Name = "QuizNameText";
            this.QuizNameText.Size = new System.Drawing.Size(232, 20);
            this.QuizNameText.TabIndex = 0;
            // 
            // QuestionNumberText
            // 
            this.QuestionNumberText.Location = new System.Drawing.Point(114, 60);
            this.QuestionNumberText.Name = "QuestionNumberText";
            this.QuestionNumberText.Size = new System.Drawing.Size(219, 20);
            this.QuestionNumberText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question";
            // 
            // QuestionText
            // 
            this.QuestionText.Location = new System.Drawing.Point(114, 117);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(215, 20);
            this.QuestionText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Answers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "B";
            // 
            // AnsAText
            // 
            this.AnsAText.Location = new System.Drawing.Point(118, 162);
            this.AnsAText.Name = "AnsAText";
            this.AnsAText.Size = new System.Drawing.Size(211, 20);
            this.AnsAText.TabIndex = 9;
            // 
            // AnsDText
            // 
            this.AnsDText.Location = new System.Drawing.Point(118, 267);
            this.AnsDText.Name = "AnsDText";
            this.AnsDText.Size = new System.Drawing.Size(211, 20);
            this.AnsDText.TabIndex = 10;
            // 
            // AnsCText
            // 
            this.AnsCText.Location = new System.Drawing.Point(118, 234);
            this.AnsCText.Name = "AnsCText";
            this.AnsCText.Size = new System.Drawing.Size(211, 20);
            this.AnsCText.TabIndex = 11;
            // 
            // AnsBText
            // 
            this.AnsBText.Location = new System.Drawing.Point(118, 200);
            this.AnsBText.Name = "AnsBText";
            this.AnsBText.Size = new System.Drawing.Size(211, 20);
            this.AnsBText.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Correct Answer";
            // 
            // CorrectAnsCombo
            // 
            this.CorrectAnsCombo.FormattingEnabled = true;
            this.CorrectAnsCombo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CorrectAnsCombo.Location = new System.Drawing.Point(133, 306);
            this.CorrectAnsCombo.Name = "CorrectAnsCombo";
            this.CorrectAnsCombo.Size = new System.Drawing.Size(121, 21);
            this.CorrectAnsCombo.TabIndex = 14;
            // 
            // AddQBtn
            // 
            this.AddQBtn.Location = new System.Drawing.Point(331, 30);
            this.AddQBtn.Name = "AddQBtn";
            this.AddQBtn.Size = new System.Drawing.Size(142, 23);
            this.AddQBtn.TabIndex = 15;
            this.AddQBtn.Text = "Add Question";
            this.AddQBtn.UseVisualStyleBackColor = true;
            this.AddQBtn.Click += new System.EventHandler(this.AddQBtn_Click);
            // 
            // ClearQ
            // 
            this.ClearQ.Location = new System.Drawing.Point(499, 30);
            this.ClearQ.Name = "ClearQ";
            this.ClearQ.Size = new System.Drawing.Size(75, 23);
            this.ClearQ.TabIndex = 16;
            this.ClearQ.Text = "Clear";
            this.ClearQ.UseVisualStyleBackColor = true;
            this.ClearQ.Click += new System.EventHandler(this.ClearQ_Click);
            // 
            // mmReturn
            // 
            this.mmReturn.Location = new System.Drawing.Point(606, 30);
            this.mmReturn.Name = "mmReturn";
            this.mmReturn.Size = new System.Drawing.Size(75, 23);
            this.mmReturn.TabIndex = 17;
            this.mmReturn.Text = "Close Creator";
            this.mmReturn.UseVisualStyleBackColor = true;
            this.mmReturn.Click += new System.EventHandler(this.mmReturn_Click);
            // 
            // CreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mmReturn);
            this.Controls.Add(this.ClearQ);
            this.Controls.Add(this.AddQBtn);
            this.Controls.Add(this.QuizQuestionsGroup);
            this.Controls.Add(this.QuizNameGroup);
            this.Name = "CreateQuiz";
            this.Text = "Form2";
            this.QuizNameGroup.ResumeLayout(false);
            this.QuizNameGroup.PerformLayout();
            this.QuizQuestionsGroup.ResumeLayout(false);
            this.QuizQuestionsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox QuizNameGroup;
        private System.Windows.Forms.TextBox QuizNameText;
        private System.Windows.Forms.GroupBox QuizQuestionsGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestionNumberText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AnsBText;
        private System.Windows.Forms.TextBox AnsCText;
        private System.Windows.Forms.TextBox AnsDText;
        private System.Windows.Forms.TextBox AnsAText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuestionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CorrectAnsCombo;
        private System.Windows.Forms.Button AddQBtn;
        private System.Windows.Forms.Button ClearQ;
        private System.Windows.Forms.Button mmReturn;
    }
}