using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зав1_real
{
    internal class Operationscs
    {
        double[] data;

        public Operationscs(int length, int minValue = -100, int maxValue = 100)
        {
            data = getRandomVector(length, minValue, maxValue);
        }
        public Operationscs(DataGridView grid)
        {
            data = readDataFromGrid(grid);
        }
        double[] getRandomVector(int length, int minValue = -100, int maxValue = 100)
        {
            double[] vect = new double[length];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < length; i++)
            {
                vect[i] = rnd.Next(minValue, maxValue);
            }
            return vect;
        }
        public static double[] readDataFromGrid(DataGridView grid)
        {
            double[] vect = new double[grid.ColumnCount];
            for (int i = 0; i < grid.ColumnCount; i++)
            {
                vect[i] = Convert.ToDouble(grid[i, 0].Value);
            }
            return vect;
        }
        public void writeToGrid(DataGridView grid)
        {
            grid.ColumnCount = data.Length;
            for (int i = 0; i < data.Length; i++)
            {
                grid[i, 0].Value = data[i];
            }
        }
        public double getSumMinus()
        {
            double sum = 0;
            foreach (var item in data)
            {
                if(item < 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}
