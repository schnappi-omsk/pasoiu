namespace PASOIU
{
    partial class PollForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PollForm));
            this.pollNameLabel = new System.Windows.Forms.Label();
            this.pollNameList = new System.Windows.Forms.ComboBox();
            this.selectPollButton = new System.Windows.Forms.Button();
            this.pollPanel = new System.Windows.Forms.Panel();
            this.questionsHeader = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.printPoll = new System.Drawing.Printing.PrintDocument();
            this.previewPoll = new System.Windows.Forms.PrintPreviewDialog();
            this.printBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pollNameLabel
            // 
            this.pollNameLabel.AutoSize = true;
            this.pollNameLabel.Location = new System.Drawing.Point(31, 28);
            this.pollNameLabel.Name = "pollNameLabel";
            this.pollNameLabel.Size = new System.Drawing.Size(80, 13);
            this.pollNameLabel.TabIndex = 0;
            this.pollNameLabel.Text = "Выбор анкеты";
            // 
            // pollNameList
            // 
            this.pollNameList.FormattingEnabled = true;
            this.pollNameList.Location = new System.Drawing.Point(117, 25);
            this.pollNameList.Name = "pollNameList";
            this.pollNameList.Size = new System.Drawing.Size(466, 21);
            this.pollNameList.TabIndex = 1;
            // 
            // selectPollButton
            // 
            this.selectPollButton.Location = new System.Drawing.Point(589, 23);
            this.selectPollButton.Name = "selectPollButton";
            this.selectPollButton.Size = new System.Drawing.Size(75, 23);
            this.selectPollButton.TabIndex = 2;
            this.selectPollButton.Text = "Выбрать";
            this.selectPollButton.UseVisualStyleBackColor = true;
            this.selectPollButton.Click += new System.EventHandler(this.selectPollButton_Click);
            // 
            // pollPanel
            // 
            this.pollPanel.AutoScroll = true;
            this.pollPanel.Location = new System.Drawing.Point(12, 88);
            this.pollPanel.Name = "pollPanel";
            this.pollPanel.Size = new System.Drawing.Size(675, 400);
            this.pollPanel.TabIndex = 3;
            // 
            // questionsHeader
            // 
            this.questionsHeader.AutoSize = true;
            this.questionsHeader.Location = new System.Drawing.Point(12, 72);
            this.questionsHeader.Name = "questionsHeader";
            this.questionsHeader.Size = new System.Drawing.Size(371, 13);
            this.questionsHeader.TabIndex = 4;
            this.questionsHeader.Text = "Вопросы (если необходимо, заполните ответы и нажмите \"Отправить\")";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(612, 494);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // printPoll
            // 
            this.printPoll.DocumentName = "Анкета";
            this.printPoll.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPoll_PrintPage);
            // 
            // previewPoll
            // 
            this.previewPoll.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previewPoll.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previewPoll.ClientSize = new System.Drawing.Size(400, 300);
            this.previewPoll.Document = this.printPoll;
            this.previewPoll.Enabled = true;
            this.previewPoll.Icon = ((System.Drawing.Icon)(resources.GetObject("previewPoll.Icon")));
            this.previewPoll.Name = "previewPoll";
            this.previewPoll.Visible = false;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(525, 494);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(81, 23);
            this.printBtn.TabIndex = 6;
            this.printBtn.Text = "Бланк";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(12, 494);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(99, 23);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Удалить анкету";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // PollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 533);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.questionsHeader);
            this.Controls.Add(this.pollPanel);
            this.Controls.Add(this.selectPollButton);
            this.Controls.Add(this.pollNameList);
            this.Controls.Add(this.pollNameLabel);
            this.Name = "PollForm";
            this.Text = "Анкета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pollNameLabel;
        private System.Windows.Forms.ComboBox pollNameList;
        private System.Windows.Forms.Button selectPollButton;
        private System.Windows.Forms.Panel pollPanel;
        private System.Windows.Forms.Label questionsHeader;
        private System.Windows.Forms.Button sendButton;
        private System.Drawing.Printing.PrintDocument printPoll;
        private System.Windows.Forms.PrintPreviewDialog previewPoll;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button removeBtn;
    }
}