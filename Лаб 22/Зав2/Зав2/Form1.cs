using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зав2
{
    public partial class Form1 : Form
    {
        MatrOperations matr;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = (int)numericUpDown1.Value;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            matr = new MatrOperations(dataGridView1.ColumnCount, dataGridView1.RowCount);
            matr.writeToGrid(dataGridView1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            matr = new MatrOperations(dataGridView1);
            matr.zamina();
            matr.writeToGrid(dataGridView1);
        }
    }
}
