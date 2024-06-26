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
    public partial class PlayQuiz : Form
    {
        public struct QuizQuestion
        {
            public int QuestionNumber;
            public string Question;
            public string A;
            public string B;
            public string C;
            public string D;
            public char Ans;
        }

        public List<QuizQuestion> Quiz = new List<QuizQuestion>();
        public List<GroupBox> gbs = new List<GroupBox>();

        public PlayQuiz()
        {
            InitializeComponent();
        }

        private void EnterFilename_Click(object sender, EventArgs e)
        {
            string filename = FilenameText.Text;
            QuizQuestion tempQ;

            using (StreamReader sr = new StreamReader(filename))
            {
                while(!sr.EndOfStream)
                {
                    tempQ = new QuizQuestion();
                    tempQ.QuestionNumber = int.Parse(sr.ReadLine());
                    tempQ.Question = sr.ReadLine();
                    tempQ.A = sr.ReadLine();
                    tempQ.B = sr.ReadLine();
                    tempQ.C = sr.ReadLine();
                    tempQ.D = sr.ReadLine();
                    tempQ.Ans = char.Parse(sr.ReadLine());
                    Quiz.Add(tempQ);
                }
            }

            EnterFilename.Visible = false;
            FilenameText.Visible = false;
            CheckAns.Visible = true;

            int count = 0;
            foreach (QuizQuestion Q in Quiz)
            {
                GroupBox g = new GroupBox();
                g.Name = "g" + count;
                g.BackColor = Color.Beige;
                g.Text = $"Question: {count}";
                g.Location = new Point(10, 30 + count*200);
                g.Size = new Size(360, 150);

                gbs.Add(g);

                count++;
            }

            foreach (QuizQuestion Q in Quiz)
            {
                Label l = new Label();
                l.Name = Q.QuestionNumber + "label";
                l.Text = Q.Question;
                l.Location = new Point(15, 15);
                l.Size = new Size(300, 60);

                Label ansL = new Label();
                ansL.Name = Q.QuestionNumber + "Anslabel";
                ansL.Text = "Answer: ";
                ansL.Location = new Point(15, 90);

                ComboBox comb = new ComboBox();
                comb.Name = Q.QuestionNumber + "Ans";
                comb.Location = new Point(125, 90);
                comb.Items.Add(Q.A);
                comb.Items.Add(Q.B);
                comb.Items.Add(Q.C);
                comb.Items.Add(Q.D);

                gbs[Q.QuestionNumber - 1].Controls.Add(l);
                gbs[Q.QuestionNumber - 1].Controls.Add(ansL);
                gbs[Q.QuestionNumber - 1].Controls.Add(comb);
                this.Controls.Add(gbs[Q.QuestionNumber - 1]);
            }
        }

        private void CheckAns_Click(object sender, EventArgs e)
        {
            int count = 0;
            int score = 0;
            foreach (GroupBox gb in gbs)
            {
                foreach (ComboBox cb in gb.Controls.OfType<ComboBox>())
                {
                    if (cb.SelectedIndex == (int)Quiz[count].Ans - 65)
                    {
                        score++;
                    }
                    count++;
                }
            }

            MessageBox.Show($"You Scored: {score}/{gbs.Count()}");
        }
    }
}
