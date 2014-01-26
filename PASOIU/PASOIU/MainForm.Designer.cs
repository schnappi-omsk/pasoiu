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
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативыПоВопросамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнаяДиаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.variantLbl = new System.Windows.Forms.Label();
            this.studentLbl = new System.Windows.Forms.Label();
            this.workNameLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.ввестиToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ввестиToolStripMenuItem.Text = "Выбрать";
            this.ввестиToolStripMenuItem.Click += new System.EventHandler(this.ввестиToolStripMenuItem_Click);
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выбратьToolStripMenuItem.Text = "Ввести";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // исследованиеToolStripMenuItem
            // 
            this.исследованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem});
            this.исследованиеToolStripMenuItem.Name = "исследованиеToolStripMenuItem";
            this.исследованиеToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.исследованиеToolStripMenuItem.Text = "Исследование";
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
            this.альтернативыПоВопросамToolStripMenuItem.Click += new System.EventHandler(this.альтернативыПоВопросамToolStripMenuItem_Click);
            // 
            // вертикальнаяДиаграммаToolStripMenuItem
            // 
            this.вертикальнаяДиаграммаToolStripMenuItem.Name = "вертикальнаяДиаграммаToolStripMenuItem";
            this.вертикальнаяДиаграммаToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.вертикальнаяДиаграммаToolStripMenuItem.Text = "Вертикальная диаграмма";
            this.вертикальнаяДиаграммаToolStripMenuItem.Click += new System.EventHandler(this.вертикальнаяДиаграммаToolStripMenuItem_Click);
            // 
            // статистикаПоВопросамЧисловогоТипаToolStripMenuItem
            // 
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem.Name = "статистикаПоВопросамЧисловогоТипаToolStripMenuItem";
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem.Text = "Статистика по вопросам числового типа";
            this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem.Click += new System.EventHandler(this.статистикаПоВопросамЧисловогоТипаToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.workNameLbl);
            this.panel1.Controls.Add(this.studentLbl);
            this.panel1.Controls.Add(this.variantLbl);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 430);
            this.panel1.TabIndex = 1;
            // 
            // variantLbl
            // 
            this.variantLbl.AutoSize = true;
            this.variantLbl.Location = new System.Drawing.Point(707, 409);
            this.variantLbl.Name = "variantLbl";
            this.variantLbl.Size = new System.Drawing.Size(58, 13);
            this.variantLbl.TabIndex = 0;
            this.variantLbl.Text = "Вариант 1";
            // 
            // studentLbl
            // 
            this.studentLbl.AutoSize = true;
            this.studentLbl.Location = new System.Drawing.Point(578, 396);
            this.studentLbl.Name = "studentLbl";
            this.studentLbl.Size = new System.Drawing.Size(187, 13);
            this.studentLbl.TabIndex = 1;
            this.studentLbl.Text = "Выполнил Алексеев О.С., ku092aos";
            // 
            // workNameLbl
            // 
            this.workNameLbl.AutoSize = true;
            this.workNameLbl.Location = new System.Drawing.Point(455, 383);
            this.workNameLbl.Name = "workNameLbl";
            this.workNameLbl.Size = new System.Drawing.Size(310, 13);
            this.workNameLbl.TabIndex = 2;
            this.workNameLbl.Text = "Курсовой проект по дисциплине \"Проектирование АСОИУ\"";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem анкетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исследованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативыПоВопросамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальнаяДиаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаПоВопросамЧисловогоТипаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label workNameLbl;
        private System.Windows.Forms.Label studentLbl;
        private System.Windows.Forms.Label variantLbl;
    }
}

