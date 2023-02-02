namespace Лаба7_New_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.подсчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делениеМатрицыНаПроизведениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьМатрицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подсчётыToolStripMenuItem,
            this.печатьМатрицыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // подсчётыToolStripMenuItem
            // 
            this.подсчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem,
            this.делениеМатрицыНаПроизведениеToolStripMenuItem});
            this.подсчётыToolStripMenuItem.Name = "подсчётыToolStripMenuItem";
            this.подсчётыToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.подсчётыToolStripMenuItem.Text = "Подсчёты";
            // 
            // нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem
            // 
            this.нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem.Name = "нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem";
            this.нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem.Size = new System.Drawing.Size(513, 26);
            this.нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem.Text = "Нахождение произведения максимальных элементов строк";
            this.нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem.Click += new System.EventHandler(this.нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem_Click);
            // 
            // делениеМатрицыНаПроизведениеToolStripMenuItem
            // 
            this.делениеМатрицыНаПроизведениеToolStripMenuItem.Name = "делениеМатрицыНаПроизведениеToolStripMenuItem";
            this.делениеМатрицыНаПроизведениеToolStripMenuItem.Size = new System.Drawing.Size(513, 26);
            this.делениеМатрицыНаПроизведениеToolStripMenuItem.Text = "Деление матрицы на произведение";
            this.делениеМатрицыНаПроизведениеToolStripMenuItem.Click += new System.EventHandler(this.делениеМатрицыНаПроизведениеToolStripMenuItem_Click);
            // 
            // печатьМатрицыToolStripMenuItem
            // 
            this.печатьМатрицыToolStripMenuItem.Name = "печатьМатрицыToolStripMenuItem";
            this.печатьМатрицыToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.печатьМатрицыToolStripMenuItem.Text = "Печать матрицы";
            this.печатьМатрицыToolStripMenuItem.Click += new System.EventHandler(this.печатьМатрицыToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 308);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Матрица:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(564, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(564, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Строки n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Столбцы m:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(226, 178);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(562, 260);
            this.listBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результаты:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem подсчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьМатрицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делениеМатрицыНаПроизведениеToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
    }
}

