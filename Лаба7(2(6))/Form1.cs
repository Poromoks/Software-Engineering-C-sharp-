using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба7_2_6__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void создатьМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int[,] Arr = new int[m, n];

            Random rnd = new Random();

            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Arr[i, j] = rnd.Next(-500, 50);

            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                    listBox1.Items.Add(Arr[i, j]);
                listBox1.Items.Add(" ");
            }
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
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int[,] Arr = new int[m, n];

            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Arr[i, j] = (int)listBox1.Items[j * Arr.GetLength(1) + i + j];

            int sum = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    sum += Arr[i, j];
            listBox2.Items.Add("Сумма элементов = " + sum);
        }

        private void максимальныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int[,] Arr = new int[m, n];

            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Arr[i, j] = (int)listBox1.Items[j * Arr.GetLength(1) + i + j];

            int max = Arr[0, 0];
            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    if (Arr[i, j] > max)
                        max = Arr[i, j];
            listBox2.Items.Add("Максимальный элемент = " + max);
        }

        private void минимальныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int[,] Arr = new int[m, n];

            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Arr[i, j] = (int)listBox1.Items[j * Arr.GetLength(1) + i + j];

            int min = Arr[0, 0];
            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    if (Arr[i, j] < min)
                        min = Arr[i, j];
            listBox2.Items.Add("Минимальный элемент = " + min);
        }

        private void количествоЭлементовКратных2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int[,] Arr = new int[m, n];

            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Arr[i, j] = (int)listBox1.Items[j * Arr.GetLength(1) + i + j];

            int amount = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    if (Arr[i, j] % 2 == 0)
                        amount++;
            listBox2.Items.Add("Количество элементов, кратных 2 = " + amount);
        }
    }
}
