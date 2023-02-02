using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба6_1._2_6_
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

            Random realRnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            byte[] bar = new byte[n];
            realRnd.NextBytes(bar);
            for (int i = 0; i < n; i++)
                listBox1.Items.Add(bar[i]);

            int amount2 = 0;
            for (int i = 0; i < n; ++i)
                if (bar[i] % 2 == 0)
                    amount2++;
            listBox2.Items.Add("Количество элементов, кратных 2 = " + amount2);

            int amount4 = 0;
            for (int i = 0; i < n; ++i)
                if (bar[i] % 4 == 0)
                    amount4++;
            listBox2.Items.Add("Количество элементов, кратных 4 = " + amount4);

            int amount6 = 0;
            for (int i = 0; i < n; ++i)
                if (bar[i] % 6 == 0)
                    amount6++;
            listBox2.Items.Add("Количество элементов, кратных 6 = " + amount6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
