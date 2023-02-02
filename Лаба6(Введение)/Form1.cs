using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба6_Введение_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Hello world!";
            this.BackgroundImage = Image.FromFile("C:\\Games\\Без имени.png");
            this.Width = 250;
            this.Height = 250;
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет мир!");
        }
    }
}
