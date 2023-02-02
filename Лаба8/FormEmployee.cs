using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба8
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void Undo()
        {
            MessageBox.Show("метод Undo");
        }

        private void New()
        {
            MessageBox.Show("метод New");
        }

        private void Edit()
        {
            MessageBox.Show("метод Edit");
        }

        private void Save()
        {
            MessageBox.Show("метод Save");
        }

        private void Remove()
        {
            MessageBox.Show("метод Remove");
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}
