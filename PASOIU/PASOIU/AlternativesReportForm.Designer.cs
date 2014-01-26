namespace PASOIU
{
    partial class AlternativesReportForm
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
            this.pollNameLbl = new System.Windows.Forms.Label();
            this.pollNameCombo = new System.Windows.Forms.ComboBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionList = new System.Windows.Forms.ComboBox();
            this.alternativesReportGrid = new System.Windows.Forms.DataGridView();
            this.alternativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alternativesReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pollNameLbl
            // 
            this.pollNameLbl.AutoSize = true;
            this.pollNameLbl.Location = new System.Drawing.Point(12, 9);
            this.pollNameLbl.Name = "pollNameLbl";
            this.pollNameLbl.Size = new System.Drawing.Size(43, 13);
            this.pollNameLbl.TabIndex = 0;
            this.pollNameLbl.Text = "Анкета";
            // 
            // pollNameCombo
            // 
            this.pollNameCombo.FormattingEnabled = true;
            this.pollNameCombo.Location = new System.Drawing.Point(61, 6);
            this.pollNameCombo.Name = "pollNameCombo";
            this.pollNameCombo.Size = new System.Drawing.Size(424, 21);
            this.pollNameCombo.TabIndex = 1;
            this.pollNameCombo.SelectedIndexChanged += new System.EventHandler(this.pollNameCombo_SelectedIndexChanged);
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
            this.questionList.Size = new System.Drawing.Size(424, 21);
            this.questionList.TabIndex = 3;
            this.questionList.SelectedIndexChanged += new System.EventHandler(this.questionList_SelectedIndexChanged);
            // 
            // alternativesReportGrid
            // 
            this.alternativesReportGrid.AllowUserToAddRows = false;
            this.alternativesReportGrid.AllowUserToDeleteRows = false;
            this.alternativesReportGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alternativesReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alternativesReportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alternativeName,
            this.Frequency,
            this.Percentage});
            this.alternativesReportGrid.Location = new System.Drawing.Point(15, 83);
            this.alternativesReportGrid.Name = "alternativesReportGrid";
            this.alternativesReportGrid.ReadOnly = true;
            this.alternativesReportGrid.Size = new System.Drawing.Size(466, 370);
            this.alternativesReportGrid.TabIndex = 4;
            // 
            // alternativeName
            // 
            this.alternativeName.HeaderText = "Альтернатива";
            this.alternativeName.Name = "alternativeName";
            this.alternativeName.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Частота (число ответов)";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // Percentage
            // 
            this.Percentage.HeaderText = "Доля от числа опрошенных";
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            // 
            // AlternativesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 490);
            this.Controls.Add(this.alternativesReportGrid);
            this.Controls.Add(this.questionList);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.pollNameCombo);
            this.Controls.Add(this.pollNameLbl);
            this.Name = "AlternativesReportForm";
            this.Text = "Таблица альтернатив по вопросу";
            ((System.ComponentModel.ISupportInitialize)(this.alternativesReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pollNameLbl;
        private System.Windows.Forms.ComboBox pollNameCombo;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.ComboBox questionList;
        private System.Windows.Forms.DataGridView alternativesReportGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
    }
}