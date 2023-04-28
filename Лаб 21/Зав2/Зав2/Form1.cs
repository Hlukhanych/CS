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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            double x = Convert.ToDouble(textBox3.Text);
            double sum = Math.Cos(2 + x/n) + Math.Sin(2 / 5);
            int step = 4;
            double znam = n * (n - 1);
            double mnozh = n - 2;
            for (int i = 1; i < n; i++)
            {             
                sum += Math.Cos(2 + Math.Pow(x, step) / znam);
                znam *= mnozh;
                mnozh -= 1;
                step += step;
            }
            for (int i = 2; i < m; i++)
            {
                sum += -1 * Math.Sin(Math.Pow(2, i) / 5);
            }
            textBox4.Text = sum.ToString();
        }
    }
}
