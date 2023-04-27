using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зав1
{
    public partial class Form1 : Form
    {
        Operations obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            double a = Convert.ToDouble(numericUpDownA.Value);
            double b = Convert.ToDouble(numericUpDownB.Value);
            double h = Convert.ToDouble(numericUpDownH.Value);
            double x = a;

            while (x <= b)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }

        private void Generation()
        {
            double a = Convert.ToDouble(numericUpDownA.Value);
            double b = Convert.ToDouble(numericUpDownB.Value);
            double h = Convert.ToDouble(numericUpDownH.Value);
            double initX = Convert.ToDouble(numericUpDownInit.Value);
            double finalX = Convert.ToDouble(numericUpDownFinal.Value);

            obj = new Operations(a, b, h, initX, finalX);
        }

        private void побудуватиГрафікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.BuildGraph(chart1);
        }

        private void спаднаЧиЗростаючаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.DescendingOrGrowing();
        }

        private void найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.MinAndMaxValueOnInterval(chart1);
        }

        private void чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.CrossOrNotOX();
        }

        private void вЯкомуКвадрантіБільшеТочокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.Quadrant();
        }

        private void середнєЗначенняФункціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.AverageValue();
        }

        private void найбільшеВідємнеЗначенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.MaxNegativeValue(chart1);
        }

        private void найменшеДодатнеЗначенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.MinPositiveValue(chart1);
        }

        private void наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.ApproximateIntersectionPoint(chart1);
        }

        private void відобразитиСиметричноВідносноОсіОХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.SymmetricallyOX(chart1);
        }

        private void відобразитиСиметричноВідносноОсіОУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation();
            obj.SymmetricallyOY(chart1);
        }
    }
}
