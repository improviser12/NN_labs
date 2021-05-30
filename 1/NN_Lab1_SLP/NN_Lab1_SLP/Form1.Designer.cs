namespace NN_Lab1_SLP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bLearn = new System.Windows.Forms.Button();
            this.lLearnRate = new System.Windows.Forms.Label();
            this.tblearnrate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbdeserror = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbrw1 = new System.Windows.Forms.TextBox();
            this.tbrt = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbrw2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbrw3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.Name = "given";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Lime;
            series2.Name = "min";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Fuchsia;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 5;
            series3.MarkerColor = System.Drawing.Color.Red;
            series3.Name = "SLP(learning)";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.Name = "SLP(testing)";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1365, 564);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // bLearn
            // 
            this.bLearn.Location = new System.Drawing.Point(1539, 799);
            this.bLearn.Name = "bLearn";
            this.bLearn.Size = new System.Drawing.Size(193, 48);
            this.bLearn.TabIndex = 1;
            this.bLearn.Text = "Learn";
            this.bLearn.UseVisualStyleBackColor = true;
            this.bLearn.Click += new System.EventHandler(this.bLearn_Click);
            // 
            // lLearnRate
            // 
            this.lLearnRate.AutoSize = true;
            this.lLearnRate.Location = new System.Drawing.Point(12, 613);
            this.lLearnRate.Name = "lLearnRate";
            this.lLearnRate.Size = new System.Drawing.Size(121, 17);
            this.lLearnRate.TabIndex = 2;
            this.lLearnRate.Text = "The learning rate:";
            // 
            // tblearnrate
            // 
            this.tblearnrate.Location = new System.Drawing.Point(139, 610);
            this.tblearnrate.Name = "tblearnrate";
            this.tblearnrate.Size = new System.Drawing.Size(70, 22);
            this.tblearnrate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desired error:";
            // 
            // tbdeserror
            // 
            this.tbdeserror.Location = new System.Drawing.Point(139, 647);
            this.tbdeserror.Name = "tbdeserror";
            this.tbdeserror.Size = new System.Drawing.Size(70, 22);
            this.tbdeserror.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 698);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rand w1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 731);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rand w2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 797);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rand T:";
            // 
            // tbrw1
            // 
            this.tbrw1.Enabled = false;
            this.tbrw1.Location = new System.Drawing.Point(88, 698);
            this.tbrw1.Name = "tbrw1";
            this.tbrw1.Size = new System.Drawing.Size(67, 22);
            this.tbrw1.TabIndex = 9;
            // 
            // tbrt
            // 
            this.tbrt.Enabled = false;
            this.tbrt.Location = new System.Drawing.Point(88, 794);
            this.tbrt.Name = "tbrt";
            this.tbrt.Size = new System.Drawing.Size(67, 22);
            this.tbrt.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1254, 613);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(478, 180);
            this.listBox1.TabIndex = 12;
            // 
            // tbrw2
            // 
            this.tbrw2.Enabled = false;
            this.tbrw2.Location = new System.Drawing.Point(88, 730);
            this.tbrw2.Name = "tbrw2";
            this.tbrw2.Size = new System.Drawing.Size(67, 22);
            this.tbrw2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 762);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rand w3:";
            // 
            // tbrw3
            // 
            this.tbrw3.Enabled = false;
            this.tbrw3.Location = new System.Drawing.Point(88, 762);
            this.tbrw3.Name = "tbrw3";
            this.tbrw3.Size = new System.Drawing.Size(67, 22);
            this.tbrw3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1251, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data desired:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 593);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data learning:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(583, 613);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(649, 180);
            this.listBox2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1398, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data testing:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(1401, 46);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(331, 532);
            this.listBox3.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 859);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbrw3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbrt);
            this.Controls.Add(this.tbrw2);
            this.Controls.Add(this.tbrw1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdeserror);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblearnrate);
            this.Controls.Add(this.lLearnRate);
            this.Controls.Add(this.bLearn);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Delta rule SLP";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bLearn;
        private System.Windows.Forms.Label lLearnRate;
        private System.Windows.Forms.TextBox tblearnrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbdeserror;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbrw1;
        private System.Windows.Forms.TextBox tbrt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbrw2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbrw3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox3;
    }
}

