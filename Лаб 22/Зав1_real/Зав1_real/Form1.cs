using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зав1_real
{
    public partial class Form1 : Form
    {
        Operationscs vector;
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void randomGenerationsToolStripOperations_Click(object sender, EventArgs e)
        {
            vector = new Operationscs(dataGridView1.ColumnCount);
            vector.writeToGrid(dataGridView1);
        }

        private void sumToolStripOperations_Click(object sender, EventArgs e)
        {
            vector = new Operationscs(dataGridView1.ColumnCount);
            double sum = vector.getSumMinus();
            MessageBox.Show($"Sum = {sum}");
        }
    }
}
