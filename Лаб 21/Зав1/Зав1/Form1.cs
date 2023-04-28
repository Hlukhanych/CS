using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зав1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double F(double x)
        {
            double sum = 0;
            if (x > 3)
            {
                for (int i = 1; i < 18; i++)
                {
                    sum += Math.Sin(Math.Pow(x, i));
                }
            }
            else
            {
                sum = 15;
                for (int i = 1; i < 6; i++)
                {
                    sum += Math.Tan(Math.Pow(x, i));
                }
            }
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double u = Math.Max(F(a), F(b));
            textBox3.Text = u.ToString();
        }
    }
}
