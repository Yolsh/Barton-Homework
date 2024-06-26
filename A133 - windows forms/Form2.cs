using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A133___windows_forms
{
    public partial class CreateQuiz : Form
    {
        public CreateQuiz()
        {
            InitializeComponent();
        }

        private void AddQBtn_Click(object sender, EventArgs e)
        {
            string filename = QuizNameText.Text;
            bool append = true;
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(QuestionNumberText.Text);
                sw.WriteLine(QuestionText.Text);
                sw.WriteLine(AnsAText.Text);
                sw.WriteLine(AnsBText.Text);
                sw.WriteLine(AnsCText.Text);
                sw.WriteLine(AnsDText.Text);
                sw.WriteLine(CorrectAnsCombo.Text);
            }

            MessageBox.Show("Question Added");
        }

        private void ClearQ_Click(object sender, EventArgs e)
        {
            QuestionNumberText.Clear();
            QuestionText.Clear();
            AnsAText.Clear();
            AnsBText.Clear();
            AnsCText.Clear();
            AnsDText.Clear();
            CorrectAnsCombo.SelectedIndex = -1;
        }

        private void mmReturn_Click(object sender, EventArgs e)
        {
            Forms.MM.Show();
            this.Hide();
        }
    }
}
