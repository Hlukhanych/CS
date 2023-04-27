using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Зав1
{
    internal class Operations
    {
        double A, B, H, InitX, FinalX;

        public Operations(double a, double b, double h, double initX, double finalX)
        {
            this.A = a;
            this.B = b;
            this.H = h;
            this.InitX = initX;
            this.FinalX = finalX;
        }

        public void BuildGraph(Chart chart1)
        {
            chart1.Series[0].Points.Clear();

            double x = A;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                chart1.Series[0].Points.AddXY(x, y);
                x += H;
            }
        }
        public void DescendingOrGrowing()
        {
            double x = A;

            int length = 0;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                x += H;
                length++;
            }

            double[] arrY = new double[length];

            int i = 0;
            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                arrY[i] = y;
                i++;
                x += H;
            }

            if (arrY[0] < arrY[length - 1])
                MessageBox.Show("Функція зростаюча");
            else
                MessageBox.Show("Функція спадаюча");
        }
        public void MinAndMaxValueOnInterval(Chart chart1)
        {
            chart1.Series[0].Points.Clear();

            double minY = double.MaxValue;
            double maxY = double.MinValue;

            while (InitX < FinalX)
            {
                double y = Math.Pow(InitX, 2) * Math.Pow(Math.E, -InitX);
                chart1.Series[0].Points.AddXY(InitX, y);
                if (y < minY)
                    minY = y;
                if (y > maxY)
                    maxY = y;
                InitX += H;
            }

            MessageBox.Show($"min = {minY} max = {maxY}");
        }
        public void CrossOrNotOX()
        {
            double x = A;

            double y0 = double.MinValue;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                if (y == 0)
                    y0 = 0;
                x += H;
            }

            if (y0 == 0)
                MessageBox.Show("Так");
            else
                MessageBox.Show("Ні");
        }
        public void Quadrant()
        {
            double x = A;

            int quadrant1 = 0;
            int quadrant2 = 0;
            int quadrant3 = 0;
            int quadrant4 = 0;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                if (x > 0 && y > 0)
                    quadrant1++;
                else if (x < 0 && y > 0)
                    quadrant2++;
                else if (x < 0 && y < 0)
                    quadrant3++;
                else
                    quadrant4++;
                x += H;
            }

            if (quadrant1 > quadrant2 && quadrant1 > quadrant3 && quadrant1 > quadrant4)
                MessageBox.Show("В квадранті 1");
            else if (quadrant2 > quadrant1 && quadrant2 > quadrant3 && quadrant2 > quadrant4)
                MessageBox.Show("В квадранті 2");
            else if (quadrant3 > quadrant1 && quadrant3 > quadrant2 && quadrant3 > quadrant4)
                MessageBox.Show("В квадранті 3");
            else
                MessageBox.Show("В квадранті 4");
        }
        public void AverageValue()
        {
            double x = A;

            double sum = 0;
            int count = 0;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                sum += y;
                count++;
                x += H;
            }

            double average = sum / count;
            MessageBox.Show(average.ToString());
        }
        public void MaxNegativeValue(Chart chart1)
        {
            chart1.Series[1].Points.Clear();

            double x = A;

            double minPointX = double.MaxValue;
            double minPointY = double.MinValue;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                if (y < 0 && y > minPointY)
                {
                    minPointX = x;
                    minPointY = y;
                }
                x += H;
            }
            if (minPointY > double.MinValue)
                chart1.Series[1].Points.AddXY(minPointX, minPointY);
            else
                MessageBox.Show("Нема від'ємних значень");
        }
        public void MinPositiveValue(Chart chart1)
        {
            chart1.Series[1].Points.Clear();

            double x = A;

            double minPointX = double.MaxValue;
            double minPointY = double.MaxValue;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                if (y > 0 && y < minPointY)
                {
                    minPointX = x;
                    minPointY = y;
                }
                x += H;
            }
            if (minPointY < double.MaxValue)
                chart1.Series[1].Points.AddXY(minPointX, minPointY);
            else
                MessageBox.Show("Нема додатніх значень значень");
        }
        public void ApproximateIntersectionPoint(Chart chart1)
        {
            chart1.Series[1].Points.Clear();

            double x = A;

            double maxY0 = 0.1;
            double minY0 = -0.1;
            double minX = double.MaxValue;
            double minY = 0;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                if (y <= maxY0 && y >= minY0)
                {
                    minX = x;
                    minY = y;
                }
                x += H;
            }

            if (x != double.MaxValue)
            {
                chart1.Series[1].Points.AddXY(minX, minY);
                MessageBox.Show($"x = {minX}");
            }
            else
                MessageBox.Show($"Такої точки немає");
        }
        public void SymmetricallyOX(Chart chart1)
        {
            chart1.Series[0].Points.Clear();

            double x = A;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                chart1.Series[0].Points.AddXY(x, -y);
                x += H;
            }
        }
        public void SymmetricallyOY(Chart chart1)
        {
            chart1.Series[0].Points.Clear();

            double x = A;

            while (x <= B)
            {
                double y = Math.Pow(x, 2) * Math.Pow(Math.E, -x);
                chart1.Series[0].Points.AddXY(-x, y);
                x += H;
            }
        }
    }
}
