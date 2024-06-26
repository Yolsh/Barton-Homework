using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A133___console_forms_and_charts
{
    public partial class MyConsoleForm : Form
    {
        private int[] Xvals;
        private int[] Yvals;
        private string Desc;
        private bool LH;

        public MyConsoleForm(int[] xvals, int[] yvals, string Desc, bool LH)
        {
            InitializeComponent();
            Xvals = xvals;
            Yvals = yvals;
            this.Desc = Desc;
            this.LH = LH;
        }

        private void MyConsoleForm_Load(object sender, EventArgs e)
        {
            if (LH)
            {
                LeftChart.Series.Add("UserData");
                LeftChart.Series["UserData"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                for (int i = 0; i < Xvals.Length; i++)
                {
                    LeftChart.Series["UserData"].Points.AddXY(Xvals[i], Yvals[i]);
                }
                LeftChartDesc.Text = Desc;
                LeftChart.Visible = true;
                LeftChartDesc.Visible = true;
            }
            else
            {
                RightChart.Series.Add("UserData");
                RightChart.Series["UserData"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                for (int i = 0; i < Xvals.Length; i++)
                {
                    RightChart.Series["UserData"].Points.AddXY(Xvals[i], Yvals[i]);
                }
                RightChartDesc.Text = Desc;
                RightChart.Visible = true;
                RightChartDesc.Visible = true;
            }
        }
    }
}
