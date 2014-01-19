namespace PASOIU
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.анкетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исследованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеИсследованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативыПоВопросамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнаяДиаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИсследованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.анкетаToolStripMenuItem,
            this.исследованиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // анкетаToolStripMenuItem
            // 
            this.анкетаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ввестиToolStripMenuItem,
            this.выбратьToolStripMenuItem});
            this.анкетаToolStripMenuItem.Name = "анкетаToolStripMenuItem";
            this.анкетаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.анкетаToolStripMenuItem.Text = "Анкета";
            // 
            // ввестиToolStripMenuItem
            // 
            this.ввестиToolStripMenuItem.Name = "ввестиToolStripMenuItem";
            this.ввестиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ввестиToolStripMenuItem.Text = "Выбрать";
            this.ввестиToolStripMenuItem.Click += new System.EventHandler(this.ввестиToolStripMenuItem_Click);
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выбратьToolStripMenuItem.Text = "Ввести";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // исследованиеToolStripMenuItem
            // 
            this.исследованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеИсследованиеToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.удалитьИсследованиеToolStripMenuItem});
            this.исследованиеToolStripMenuItem.Name = "исследованиеToolStripMenuItem";
            this.исследованиеToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.исследованиеToolStripMenuItem.Text = "Исследование";
            // 
            // новоеИсследованиеToolStripMenuItem
            // 
            this.новоеИсследованиеToolStripMenuItem.Name = "новоеИсследованиеToolStripMenuItem";
            this.новоеИсследованиеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.новоеИсследованиеToolStripMenuItem.Text = "Новое исследование";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.альтернативыПоВопросамToolStripMenuItem,
            this.вертикальнаяДиаграммаToolStripMenuItem,
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // альтернативыПоВопросамToolStripMenuItem
            // 
            this.альтернативыПоВопросамToolStripMenuItem.Name = "альтернативыПоВопросамToolStripMenuItem";
            this.альтернативыПоВопросамToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.альтернативыПоВопросамToolStripMenuItem.Text = "Альтернативы по вопросам";
            // 
            // вертикальнаяДиаграммаToolStripMenuItem
            // 
            this.вертикальнаяДиаграммаToolStripMenuItem.Name = "вертикальнаяДиаграммаToolStripMenuItem";
            this.вертикальнаяДиаграммаToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.вертикальнаяДиаграммаToolStripMenuItem.Text = "Вертикальная диаграмма";
            // 
            // статистикаПоВопросамЧисловогоТипаToolStripMenuItem
            // 
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem.Name = "статистикаПоВопросамЧисловогоТипаToolStripMenuItem";
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem.Text = "Статистика по вопросам числового типа";
            // 
            // удалитьИсследованиеToolStripMenuItem
            // 
            this.удалитьИсследованиеToolStripMenuItem.Name = "удалитьИсследованиеToolStripMenuItem";
            this.удалитьИсследованиеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.удалитьИсследованиеToolStripMenuItem.Text = "Удалить исследование";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 430);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "АРМ \"Социолог\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem анкетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исследованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеИсследованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативыПоВопросамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальнаяДиаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаПоВопросамЧисловогоТипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИсследованиеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

