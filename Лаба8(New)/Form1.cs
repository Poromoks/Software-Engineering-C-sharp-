using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба8_New_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee FEmployee = new FormEmployee();
            FEmployee.MdiParent = this;
            FEmployee.Show();
            FEmployee.WindowState = FormWindowState.Maximized;
        }

        private void Undo()
        {
            MessageBox.Show("метод Undo");
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void поручениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void сделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void странаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void регионToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void иМНСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }
    }
}
