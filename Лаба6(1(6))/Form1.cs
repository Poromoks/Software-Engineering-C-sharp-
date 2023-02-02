using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба6_1_6__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Aquamarine;
            this.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            Random realRnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            realRnd.NextBytes(bar);
            for (int i = 0; i < n; i++)
                listBox1.Items.Add(bar[i]);

            int sum = 0;
            for (int i = 0; i < n; ++i)
                sum += bar[i];
            listBox2.Items.Add("Сумма элементов = " + sum);

            int max = bar[0];
            for (int i = 0; i < n; ++i)
                if (bar[i] > max)
                    max = bar[i];
            listBox2.Items.Add("Максимальный элемент = " + max);

            int min = bar[0];
            for (int i = 0; i < n; ++i)
                if (bar[i] < min)
                    min = bar[i];
            listBox2.Items.Add("Минимальный элемент = " + min);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
