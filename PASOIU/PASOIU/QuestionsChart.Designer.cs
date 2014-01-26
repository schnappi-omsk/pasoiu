namespace PASOIU
{
    partial class QuestionsChart
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
            this.pollLbl = new System.Windows.Forms.Label();
            this.pollNameCombo = new System.Windows.Forms.ComboBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionList = new System.Windows.Forms.ComboBox();
            this.alternativesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.alternativesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pollLbl
            // 
            this.pollLbl.AutoSize = true;
            this.pollLbl.Location = new System.Drawing.Point(12, 9);
            this.pollLbl.Name = "pollLbl";
            this.pollLbl.Size = new System.Drawing.Size(43, 13);
            this.pollLbl.TabIndex = 0;
            this.pollLbl.Text = "Анкета";
            // 
            // pollNameCombo
            // 
            this.pollNameCombo.FormattingEnabled = true;
            this.pollNameCombo.Location = new System.Drawing.Point(61, 6);
            this.pollNameCombo.Name = "pollNameCombo";
            this.pollNameCombo.Size = new System.Drawing.Size(470, 21);
            this.pollNameCombo.TabIndex = 1;
            this.pollNameCombo.SelectedIndexChanged += new System.EventHandler(this.pollNameCombo_SelectedIndexChanged);
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Location = new System.Drawing.Point(12, 50);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(44, 13);
            this.questionLbl.TabIndex = 2;
            this.questionLbl.Text = "Вопрос";
            // 
            // questionList
            // 
            this.questionList.FormattingEnabled = true;
            this.questionList.Location = new System.Drawing.Point(61, 47);
            this.questionList.Name = "questionList";
            this.questionList.Size = new System.Drawing.Size(470, 21);
            this.questionList.TabIndex = 3;
            this.questionList.SelectedIndexChanged += new System.EventHandler(this.questionList_SelectedIndexChanged);
            // 
            // alternativesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.alternativesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.alternativesChart.Legends.Add(legend1);
            this.alternativesChart.Location = new System.Drawing.Point(15, 74);
            this.alternativesChart.Name = "alternativesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.alternativesChart.Series.Add(series1);
            this.alternativesChart.Size = new System.Drawing.Size(516, 330);
            this.alternativesChart.TabIndex = 4;
            this.alternativesChart.Text = "chart1";
            // 
            // QuestionsChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 416);
            this.Controls.Add(this.alternativesChart);
            this.Controls.Add(this.questionList);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.pollNameCombo);
            this.Controls.Add(this.pollLbl);
            this.Name = "QuestionsChart";
            this.Text = "Диаграмма по альтернативам";
            ((System.ComponentModel.ISupportInitialize)(this.alternativesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pollLbl;
        private System.Windows.Forms.ComboBox pollNameCombo;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.ComboBox questionList;
        private System.Windows.Forms.DataVisualization.Charting.Chart alternativesChart;
    }
}