namespace Лаба7_2_6__
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.подсчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.минимальныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоЭлементовКратных2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьМассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(257, 144);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(522, 196);
            this.listBox2.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 292);
            this.listBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Результаты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Массив:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введите n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите m:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Программа создания двумерного массива";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подсчётыToolStripMenuItem,
            this.создатьМассивToolStripMenuItem,
            this.очиститьПоляToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // подсчётыToolStripMenuItem
            // 
            this.подсчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммаЭлементовToolStripMenuItem,
            this.максимальныйЭлементToolStripMenuItem,
            this.минимальныйЭлементToolStripMenuItem,
            this.количествоЭлементовКратных2ToolStripMenuItem});
            this.подсчётыToolStripMenuItem.Name = "подсчётыToolStripMenuItem";
            this.подсчётыToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.подсчётыToolStripMenuItem.Text = "Подсчёты";
            // 
            // суммаЭлементовToolStripMenuItem
            // 
            this.суммаЭлементовToolStripMenuItem.Name = "суммаЭлементовToolStripMenuItem";
            this.суммаЭлементовToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.суммаЭлементовToolStripMenuItem.Text = "Сумма элементов";
            this.суммаЭлементовToolStripMenuItem.Click += new System.EventHandler(this.суммаЭлементовToolStripMenuItem_Click);
            // 
            // максимальныйЭлементToolStripMenuItem
            // 
            this.максимальныйЭлементToolStripMenuItem.Name = "максимальныйЭлементToolStripMenuItem";
            this.максимальныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.максимальныйЭлементToolStripMenuItem.Text = "Максимальный элемент";
            this.максимальныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.максимальныйЭлементToolStripMenuItem_Click);
            // 
            // минимальныйЭлементToolStripMenuItem
            // 
            this.минимальныйЭлементToolStripMenuItem.Name = "минимальныйЭлементToolStripMenuItem";
            this.минимальныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.минимальныйЭлементToolStripMenuItem.Text = "Минимальный элемент";
            this.минимальныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.минимальныйЭлементToolStripMenuItem_Click);
            // 
            // количествоЭлементовКратных2ToolStripMenuItem
            // 
            this.количествоЭлементовКратных2ToolStripMenuItem.Name = "количествоЭлементовКратных2ToolStripMenuItem";
            this.количествоЭлементовКратных2ToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.количествоЭлементовКратных2ToolStripMenuItem.Text = "Количество элементов, кратных 2";
            this.количествоЭлементовКратных2ToolStripMenuItem.Click += new System.EventHandler(this.количествоЭлементовКратных2ToolStripMenuItem_Click);
            // 
            // создатьМассивToolStripMenuItem
            // 
            this.создатьМассивToolStripMenuItem.Name = "создатьМассивToolStripMenuItem";
            this.создатьМассивToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.создатьМассивToolStripMenuItem.Text = "Создать массив";
            this.создатьМассивToolStripMenuItem.Click += new System.EventHandler(this.создатьМассивToolStripMenuItem_Click);
            // 
            // очиститьПоляToolStripMenuItem
            // 
            this.очиститьПоляToolStripMenuItem.Name = "очиститьПоляToolStripMenuItem";
            this.очиститьПоляToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.очиститьПоляToolStripMenuItem.Text = "Очистить поля";
            this.очиститьПоляToolStripMenuItem.Click += new System.EventHandler(this.очиститьПоляToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подсчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммаЭлементовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальныйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минимальныйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоЭлементовКратных2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьМассивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

