using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Silencer()
        {
            MessageBox.Show("Заглушка");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void поручениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void сделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();

        }

        private void странаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void регионToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void иМНСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silencer();
        }
    }
}
