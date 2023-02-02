using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба7_New_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void печатьМатрицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n, m;
            float[,] matr;

            using (StreamReader file = new StreamReader("dat.txt"))
            {
                string line;
                char[] delimiterChars = { ' ', ',', '\t' };
                n = int.Parse(file.ReadLine());
                m = int.Parse(file.ReadLine());
                matr = new float[n, m];
                int i, j;

                textBox1.Text = n.ToString();
                textBox2.Text = m.ToString();
                listBox1.Items.Clear();

                for (i = 0; (i < n) && (line = file.ReadLine()) != null; i++)
                {
                    string[] numbers = line.Split(delimiterChars);
                    j = 0;

                    foreach (string numString in numbers)
                    {
                        int x;
                        bool canConvert = int.TryParse(numString, out x);

                        if (canConvert == true)
                        {
                            matr[i, j] = x;
                            j++;
                        }
                    }
                }

                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        listBox1.Items.Add(matr[i, j]);
                    }
                    listBox1.Items.Add(" ");
                }
            }
        }

        private void нахождениеПроизведенияМаксимальныхЭлементовСтрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            float[,] Arr = new float[n, m];

            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Arr[i, j] = (float)listBox1.Items[i * Arr.GetLength(1) + j + i];

            float product = 1;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                float max_elt = Arr[i, 0];
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Arr[i, j] > max_elt)
                        max_elt = Arr[i, j];
                }
                product *= max_elt;
            }
            listBox2.Items.Add("Произведение = " + product);
        }

        private void делениеМатрицыНаПроизведениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            float[,] Arr = new float[n, m];

            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Arr[i, j] = (float)listBox1.Items[i * Arr.GetLength(1) + j + i];

            float product = 1;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                float max_elt = Arr[i, 0];
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Arr[i, j] > max_elt)
                        max_elt = Arr[i, j];
                }
                product *= max_elt;
            }

            listBox2.Items.Add("Матрица поделена");

            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] /= product;
                    listBox2.Items.Add(Arr[i, j]);
                }
                listBox2.Items.Add(" ");
            }
        }
    }
}
