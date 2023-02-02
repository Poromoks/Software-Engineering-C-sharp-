using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба6_2._2_6__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

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
                    listBox1.Items.Add(Arr[i, j] + " ");
                listBox1.Items.Add(" ");
            }

            int amount = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    if (Arr[i, j] % 2 == 0)
                        amount++;
            listBox2.Items.Add("Количество элементов, кратных 2 = " + amount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
