using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Point tmp_location;

            int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;


            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();

            if (e.X > 60 && e.X < 215 && e.Y > 80 && e.Y < 155)
            {
                tmp_location = this.Location;
                tmp_location.X += rnd.Next(-10, 10);
                tmp_location.Y += rnd.Next(-10, 10);

                if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
                {
                    tmp_location.X = _w / 2;
                    tmp_location.Y = _h / 2;
                }

                this.Location = tmp_location;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы усердны!");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы не сомневались в вашем безразличии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
