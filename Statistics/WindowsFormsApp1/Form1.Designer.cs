
namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listRaw = new System.Windows.Forms.ListBox();
            this.listSorted = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.histogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(58, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Elements";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtSize.Location = new System.Drawing.Point(282, 22);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(140, 30);
            this.txtSize.TabIndex = 1;
            // 
            // txtLower
            // 
            this.txtLower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtLower.Location = new System.Drawing.Point(282, 58);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(140, 30);
            this.txtLower.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(58, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lower Limit";
            // 
            // txtUpper
            // 
            this.txtUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtUpper.Location = new System.Drawing.Point(282, 94);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(140, 30);
            this.txtUpper.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(58, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Upper Limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label4.Location = new System.Drawing.Point(58, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Raw Dataset";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listRaw
            // 
            this.listRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.listRaw.FormattingEnabled = true;
            this.listRaw.ItemHeight = 25;
            this.listRaw.Location = new System.Drawing.Point(60, 230);
            this.listRaw.Name = "listRaw";
            this.listRaw.Size = new System.Drawing.Size(120, 204);
            this.listRaw.TabIndex = 7;
            // 
            // listSorted
            // 
            this.listSorted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.listSorted.FormattingEnabled = true;
            this.listSorted.ItemHeight = 25;
            this.listSorted.Location = new System.Drawing.Point(299, 230);
            this.listSorted.Name = "listSorted";
            this.listSorted.Size = new System.Drawing.Size(120, 204);
            this.listSorted.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(294, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sorted Dataset";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMean
            // 
            this.txtMean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtMean.Location = new System.Drawing.Point(299, 440);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(123, 30);
            this.txtMean.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(58, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mean";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMedian
            // 
            this.txtMedian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtMedian.Location = new System.Drawing.Point(299, 476);
            this.txtMedian.Name = "txtMedian";
            this.txtMedian.Size = new System.Drawing.Size(123, 30);
            this.txtMedian.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label7.Location = new System.Drawing.Point(58, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Median";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMode
            // 
            this.txtMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtMode.Location = new System.Drawing.Point(299, 512);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(123, 30);
            this.txtMode.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(58, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mode";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.MintCream;
            this.btnGenerate.Location = new System.Drawing.Point(60, 142);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 34);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(96)))), ((int)(((byte)(206)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.MintCream;
            this.btnCalculate.Location = new System.Drawing.Point(282, 142);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 34);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // histogramChart
            // 
            this.histogramChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.histogramChart.BorderlineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.AxisX.LineColor = System.Drawing.Color.MintCream;
            chartArea1.AxisX.Title = "Numbers";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.MintCream;
            chartArea1.AxisY.LineColor = System.Drawing.Color.MintCream;
            chartArea1.AxisY.Title = "Frequency";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.MintCream;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.Silver;
            chartArea1.BorderColor = System.Drawing.Color.MintCream;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.histogramChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.MintCream;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.DimGray;
            legend1.TitleSeparatorColor = System.Drawing.Color.DarkGray;
            this.histogramChart.Legends.Add(legend1);
            this.histogramChart.Location = new System.Drawing.Point(489, 12);
            this.histogramChart.Name = "histogramChart";
            this.histogramChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Label = "Random Variable";
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            this.histogramChart.Series.Add(series1);
            this.histogramChart.Size = new System.Drawing.Size(699, 530);
            this.histogramChart.TabIndex = 18;
            this.histogramChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.MintCream;
            title1.Name = "Title1";
            title1.Text = "Histogram of Random Variable";
            this.histogramChart.Titles.Add(title1);
            this.histogramChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.histogramChart);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMedian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listSorted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listRaw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Basic Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listRaw;
        private System.Windows.Forms.ListBox listSorted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramChart;
    }
}

