namespace PASOIU
{
    partial class QuestionStatisticsForm
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
            this.pollLabel = new System.Windows.Forms.Label();
            this.pollList = new System.Windows.Forms.ComboBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionList = new System.Windows.Forms.ComboBox();
            this.statsGrid = new System.Windows.Forms.DataGridView();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pollLabel
            // 
            this.pollLabel.AutoSize = true;
            this.pollLabel.Location = new System.Drawing.Point(12, 9);
            this.pollLabel.Name = "pollLabel";
            this.pollLabel.Size = new System.Drawing.Size(43, 13);
            this.pollLabel.TabIndex = 0;
            this.pollLabel.Text = "Анкета";
            // 
            // pollList
            // 
            this.pollList.FormattingEnabled = true;
            this.pollList.Location = new System.Drawing.Point(61, 6);
            this.pollList.Name = "pollList";
            this.pollList.Size = new System.Drawing.Size(417, 21);
            this.pollList.TabIndex = 1;
            this.pollList.SelectedIndexChanged += new System.EventHandler(this.pollList_SelectedIndexChanged);
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Location = new System.Drawing.Point(12, 46);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(44, 13);
            this.questionLbl.TabIndex = 2;
            this.questionLbl.Text = "Вопрос";
            // 
            // questionList
            // 
            this.questionList.FormattingEnabled = true;
            this.questionList.Location = new System.Drawing.Point(61, 43);
            this.questionList.Name = "questionList";
            this.questionList.Size = new System.Drawing.Size(417, 21);
            this.questionList.TabIndex = 3;
            this.questionList.SelectedIndexChanged += new System.EventHandler(this.questionList_SelectedIndexChanged);
            // 
            // statsGrid
            // 
            this.statsGrid.AllowUserToAddRows = false;
            this.statsGrid.AllowUserToDeleteRows = false;
            this.statsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Min,
            this.Average,
            this.Max});
            this.statsGrid.Location = new System.Drawing.Point(15, 83);
            this.statsGrid.Name = "statsGrid";
            this.statsGrid.ReadOnly = true;
            this.statsGrid.Size = new System.Drawing.Size(463, 401);
            this.statsGrid.TabIndex = 4;
            // 
            // Min
            // 
            this.Min.HeaderText = "Минимум";
            this.Min.Name = "Min";
            this.Min.ReadOnly = true;
            // 
            // Average
            // 
            this.Average.HeaderText = "Среднее";
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            // 
            // Max
            // 
            this.Max.HeaderText = "Максимум";
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            // 
            // QuestionStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 496);
            this.Controls.Add(this.statsGrid);
            this.Controls.Add(this.questionList);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.pollList);
            this.Controls.Add(this.pollLabel);
            this.Name = "QuestionStatisticsForm";
            this.Text = "Статистика по числовым вопросам";
            ((System.ComponentModel.ISupportInitialize)(this.statsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pollLabel;
        private System.Windows.Forms.ComboBox pollList;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.ComboBox questionList;
        private System.Windows.Forms.DataGridView statsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
    }
}