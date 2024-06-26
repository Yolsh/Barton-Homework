namespace A133___console_forms_and_charts
{
    partial class MyConsoleForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.LeftChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LeftChartDesc = new System.Windows.Forms.Label();
            this.RightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RightChartDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftChart
            // 
            chartArea1.Name = "ChartArea1";
            this.LeftChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LeftChart.Legends.Add(legend1);
            this.LeftChart.Location = new System.Drawing.Point(12, 12);
            this.LeftChart.Name = "LeftChart";
            this.LeftChart.Size = new System.Drawing.Size(492, 364);
            this.LeftChart.TabIndex = 1;
            this.LeftChart.Text = "chart1";
            this.LeftChart.Visible = false;
            // 
            // LeftChartDesc
            // 
            this.LeftChartDesc.AutoSize = true;
            this.LeftChartDesc.Location = new System.Drawing.Point(633, 178);
            this.LeftChartDesc.Name = "LeftChartDesc";
            this.LeftChartDesc.Size = new System.Drawing.Size(35, 13);
            this.LeftChartDesc.TabIndex = 2;
            this.LeftChartDesc.Text = "label1";
            this.LeftChartDesc.Visible = false;
            // 
            // RightChart
            // 
            chartArea2.Name = "ChartArea1";
            this.RightChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.RightChart.Legends.Add(legend2);
            this.RightChart.Location = new System.Drawing.Point(296, 12);
            this.RightChart.Name = "RightChart";
            this.RightChart.Size = new System.Drawing.Size(492, 364);
            this.RightChart.TabIndex = 3;
            this.RightChart.Text = "chart1";
            this.RightChart.Visible = false;
            // 
            // RightChartDesc
            // 
            this.RightChartDesc.AutoSize = true;
            this.RightChartDesc.Location = new System.Drawing.Point(78, 163);
            this.RightChartDesc.Name = "RightChartDesc";
            this.RightChartDesc.Size = new System.Drawing.Size(35, 13);
            this.RightChartDesc.TabIndex = 4;
            this.RightChartDesc.Text = "label1";
            this.RightChartDesc.Visible = false;
            // 
            // MyConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RightChartDesc);
            this.Controls.Add(this.RightChart);
            this.Controls.Add(this.LeftChartDesc);
            this.Controls.Add(this.LeftChart);
            this.Name = "MyConsoleForm";
            this.Text = "MyConsoleForm";
            this.Load += new System.EventHandler(this.MyConsoleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart LeftChart;
        private System.Windows.Forms.Label LeftChartDesc;
        private System.Windows.Forms.DataVisualization.Charting.Chart RightChart;
        private System.Windows.Forms.Label RightChartDesc;
    }
}