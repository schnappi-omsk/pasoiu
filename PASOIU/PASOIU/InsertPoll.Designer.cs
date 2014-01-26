namespace PASOIU
{
    partial class InsertPoll
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
            this.pollNameLabel = new System.Windows.Forms.Label();
            this.pollNameField = new System.Windows.Forms.TextBox();
            this.insertQuestionLabel = new System.Windows.Forms.Label();
            this.insertQuestionList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionTextField = new System.Windows.Forms.TextBox();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.fillFormLabel = new System.Windows.Forms.Label();
            this.alternativesLabel = new System.Windows.Forms.Label();
            this.alternativesList = new System.Windows.Forms.ListBox();
            this.addAlternativeLabel = new System.Windows.Forms.Label();
            this.addAlternativeField = new System.Windows.Forms.TextBox();
            this.addAlternativeBtn = new System.Windows.Forms.Button();
            this.savePoll = new System.Windows.Forms.Button();
            this.removeAlternativeBtn = new System.Windows.Forms.Button();
            this.saveQuestionBtn = new System.Windows.Forms.Button();
            this.hintLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pollNameLabel
            // 
            this.pollNameLabel.AutoSize = true;
            this.pollNameLabel.Location = new System.Drawing.Point(12, 34);
            this.pollNameLabel.Name = "pollNameLabel";
            this.pollNameLabel.Size = new System.Drawing.Size(228, 13);
            this.pollNameLabel.TabIndex = 0;
            this.pollNameLabel.Text = "Название анкеты (должно быть уникально)";
            // 
            // pollNameField
            // 
            this.pollNameField.Location = new System.Drawing.Point(255, 31);
            this.pollNameField.Name = "pollNameField";
            this.pollNameField.Size = new System.Drawing.Size(302, 20);
            this.pollNameField.TabIndex = 1;
            this.pollNameField.TextChanged += new System.EventHandler(this.pollNameField_TextChanged);
            // 
            // insertQuestionLabel
            // 
            this.insertQuestionLabel.AutoSize = true;
            this.insertQuestionLabel.Location = new System.Drawing.Point(12, 77);
            this.insertQuestionLabel.Name = "insertQuestionLabel";
            this.insertQuestionLabel.Size = new System.Drawing.Size(115, 13);
            this.insertQuestionLabel.TabIndex = 2;
            this.insertQuestionLabel.Text = "Добавление вопроса";
            // 
            // insertQuestionList
            // 
            this.insertQuestionList.FormattingEnabled = true;
            this.insertQuestionList.Items.AddRange(new object[] {
            "С текстовым вводом",
            "С выбором альтернативы"});
            this.insertQuestionList.Location = new System.Drawing.Point(255, 69);
            this.insertQuestionList.Name = "insertQuestionList";
            this.insertQuestionList.Size = new System.Drawing.Size(302, 21);
            this.insertQuestionList.TabIndex = 3;
            this.insertQuestionList.SelectedIndexChanged += new System.EventHandler(this.insertQuestionList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hintLbl);
            this.panel1.Controls.Add(this.saveQuestionBtn);
            this.panel1.Controls.Add(this.removeAlternativeBtn);
            this.panel1.Controls.Add(this.addAlternativeBtn);
            this.panel1.Controls.Add(this.addAlternativeField);
            this.panel1.Controls.Add(this.addAlternativeLabel);
            this.panel1.Controls.Add(this.alternativesList);
            this.panel1.Controls.Add(this.alternativesLabel);
            this.panel1.Controls.Add(this.questionTextField);
            this.panel1.Controls.Add(this.questionTextLabel);
            this.panel1.Controls.Add(this.fillFormLabel);
            this.panel1.Location = new System.Drawing.Point(15, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 344);
            this.panel1.TabIndex = 4;
            // 
            // questionTextField
            // 
            this.questionTextField.Location = new System.Drawing.Point(6, 75);
            this.questionTextField.Name = "questionTextField";
            this.questionTextField.Size = new System.Drawing.Size(533, 20);
            this.questionTextField.TabIndex = 2;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(3, 59);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(82, 13);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // fillFormLabel
            // 
            this.fillFormLabel.AutoSize = true;
            this.fillFormLabel.Location = new System.Drawing.Point(3, 10);
            this.fillFormLabel.Name = "fillFormLabel";
            this.fillFormLabel.Size = new System.Drawing.Size(259, 13);
            this.fillFormLabel.TabIndex = 0;
            this.fillFormLabel.Text = "Заполните форму и нажмите \"Сохранить вопрос\"";
            // 
            // alternativesLabel
            // 
            this.alternativesLabel.AutoSize = true;
            this.alternativesLabel.Location = new System.Drawing.Point(3, 110);
            this.alternativesLabel.Name = "alternativesLabel";
            this.alternativesLabel.Size = new System.Drawing.Size(80, 13);
            this.alternativesLabel.TabIndex = 3;
            this.alternativesLabel.Text = "Альтернативы";
            // 
            // alternativesList
            // 
            this.alternativesList.FormattingEnabled = true;
            this.alternativesList.Location = new System.Drawing.Point(6, 126);
            this.alternativesList.Name = "alternativesList";
            this.alternativesList.Size = new System.Drawing.Size(219, 186);
            this.alternativesList.TabIndex = 4;
            // 
            // addAlternativeLabel
            // 
            this.addAlternativeLabel.AutoSize = true;
            this.addAlternativeLabel.Location = new System.Drawing.Point(237, 126);
            this.addAlternativeLabel.Name = "addAlternativeLabel";
            this.addAlternativeLabel.Size = new System.Drawing.Size(166, 13);
            this.addAlternativeLabel.TabIndex = 5;
            this.addAlternativeLabel.Text = "Текст альтернативы для ввода";
            // 
            // addAlternativeField
            // 
            this.addAlternativeField.Location = new System.Drawing.Point(240, 142);
            this.addAlternativeField.Name = "addAlternativeField";
            this.addAlternativeField.Size = new System.Drawing.Size(299, 20);
            this.addAlternativeField.TabIndex = 6;
            // 
            // addAlternativeBtn
            // 
            this.addAlternativeBtn.Location = new System.Drawing.Point(379, 168);
            this.addAlternativeBtn.Name = "addAlternativeBtn";
            this.addAlternativeBtn.Size = new System.Drawing.Size(160, 23);
            this.addAlternativeBtn.TabIndex = 7;
            this.addAlternativeBtn.Text = "Добавить альтернативу";
            this.addAlternativeBtn.UseVisualStyleBackColor = true;
            this.addAlternativeBtn.Click += new System.EventHandler(this.addAlternativeBtn_Click);
            // 
            // savePoll
            // 
            this.savePoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePoll.Location = new System.Drawing.Point(394, 470);
            this.savePoll.Name = "savePoll";
            this.savePoll.Size = new System.Drawing.Size(163, 23);
            this.savePoll.TabIndex = 5;
            this.savePoll.Text = "Внести анкету";
            this.savePoll.UseVisualStyleBackColor = true;
            this.savePoll.Click += new System.EventHandler(this.savePoll_Click);
            // 
            // removeAlternativeBtn
            // 
            this.removeAlternativeBtn.Location = new System.Drawing.Point(150, 318);
            this.removeAlternativeBtn.Name = "removeAlternativeBtn";
            this.removeAlternativeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeAlternativeBtn.TabIndex = 8;
            this.removeAlternativeBtn.Text = "Удалить";
            this.removeAlternativeBtn.UseVisualStyleBackColor = true;
            // 
            // saveQuestionBtn
            // 
            this.saveQuestionBtn.Location = new System.Drawing.Point(379, 318);
            this.saveQuestionBtn.Name = "saveQuestionBtn";
            this.saveQuestionBtn.Size = new System.Drawing.Size(160, 23);
            this.saveQuestionBtn.TabIndex = 9;
            this.saveQuestionBtn.Text = "Сохранить вопрос";
            this.saveQuestionBtn.UseVisualStyleBackColor = true;
            this.saveQuestionBtn.Click += new System.EventHandler(this.saveQuestionBtn_Click);
            // 
            // hintLbl
            // 
            this.hintLbl.AutoSize = true;
            this.hintLbl.Location = new System.Drawing.Point(3, 34);
            this.hintLbl.Name = "hintLbl";
            this.hintLbl.Size = new System.Drawing.Size(336, 13);
            this.hintLbl.TabIndex = 10;
            this.hintLbl.Text = "По завершению добавления вопросов нажмите \"Внести анкету\"";
            // 
            // InsertPoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 505);
            this.Controls.Add(this.savePoll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.insertQuestionList);
            this.Controls.Add(this.insertQuestionLabel);
            this.Controls.Add(this.pollNameField);
            this.Controls.Add(this.pollNameLabel);
            this.Name = "InsertPoll";
            this.Text = "Добавление анкеты";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pollNameLabel;
        private System.Windows.Forms.TextBox pollNameField;
        private System.Windows.Forms.Label insertQuestionLabel;
        private System.Windows.Forms.ComboBox insertQuestionList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox questionTextField;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label fillFormLabel;
        private System.Windows.Forms.TextBox addAlternativeField;
        private System.Windows.Forms.Label addAlternativeLabel;
        private System.Windows.Forms.ListBox alternativesList;
        private System.Windows.Forms.Label alternativesLabel;
        private System.Windows.Forms.Button addAlternativeBtn;
        private System.Windows.Forms.Button savePoll;
        private System.Windows.Forms.Button removeAlternativeBtn;
        private System.Windows.Forms.Label hintLbl;
        private System.Windows.Forms.Button saveQuestionBtn;
    }
}