using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A133___windows_forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Forms.CQ.Show();
            this.Hide();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Forms.PQ.Show();
            this.Hide();
        }
    }
}
