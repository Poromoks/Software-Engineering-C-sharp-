using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба7_1_6__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void создатьМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random realRnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            realRnd.NextBytes(bar);
            for (int i = 0; i < n; i++)
                listBox1.Items.Add(bar[i]);
        }

        private void очиститьПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void суммаЭлементовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            for (int i = 0; i < n; ++i)
                bar[i] = (byte)listBox1.Items[i];

            int sum = 0;
            for (int i = 0; i < n; ++i)
                sum += bar[i];
            listBox2.Items.Add("Сумма элементов = " + sum);
        }

        private void максимальныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            for (int i = 0; i < n; ++i)
                bar[i] = (byte)listBox1.Items[i];

            int max = bar[0];
            for (int i = 0; i < n; ++i)
                if (bar[i] > max)
                    max = bar[i];
            listBox2.Items.Add("Максимальный элемент = " + max);
        }

        private void минимальныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            for (int i = 0; i < n; ++i)
                bar[i] = (byte)listBox1.Items[i];

            int min = bar[0];
            for (int i = 0; i < n; ++i)
                if (bar[i] < min)
                    min = bar[i];
            listBox2.Items.Add("Минимальный элемент = " + min);
        }

        private void количествоЭлементовКратных2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            for (int i = 0; i < n; ++i)
                bar[i] = (byte)listBox1.Items[i];

            int amount2 = 0;
            for (int i = 0; i < n; ++i)
                if (bar[i] % 2 == 0)
                    amount2++;
            listBox2.Items.Add("Количество элементов, кратных 2 = " + amount2);
        }

        private void количествоЭлементовКратных4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            for (int i = 0; i < n; ++i)
                bar[i] = (byte)listBox1.Items[i];

            int amount4 = 0;
            for (int i = 0; i < n; ++i)
                if (bar[i] % 4 == 0)
                    amount4++;
            listBox2.Items.Add("Количество элементов, кратных 4 = " + amount4);
        }

        private void количествоЭлементовКратных6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            for (int i = 0; i < n; ++i)
                bar[i] = (byte)listBox1.Items[i];

            int amount6 = 0;
            for (int i = 0; i < n; ++i)
                if (bar[i] % 6 == 0)
                    amount6++;
            listBox2.Items.Add("Количество элементов, кратных 6 = " + amount6);
        }
    }
}
