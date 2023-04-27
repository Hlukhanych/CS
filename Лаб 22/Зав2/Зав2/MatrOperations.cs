using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зав2
{
    internal class MatrOperations
    {
        double[,] matr;

        public MatrOperations(int length, int minValue = -100, int maxValue = 100)
        {
            matr = getRandomMatr(length, minValue, maxValue);
        }
        public MatrOperations(DataGridView grid)
        {
            matr = readMatrFromGrid(grid);
        }
        double[,] getRandomMatr(int length, int minValue = -100, int maxValue = 100)
        {
            double[,] matr = new double[length, length];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matr[i, j] = rnd.Next(minValue, maxValue);
                }
            }
            return matr;
        }
        public static double[,] readMatrFromGrid(DataGridView grid)
        {
            double[,] matr = new double[grid.RowCount, grid.ColumnCount];

            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    matr[i, j] = Convert.ToDouble(grid[j, i].Value);
                }
            }
            return matr;
        }
        public void writeToGrid(DataGridView grid)
        {
            grid.RowCount = matr.GetLength(0);
            grid.ColumnCount = matr.GetLength(1);

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    grid[j, i].Value = matr[i, j];
                }
            }
        }
        public void zamina()
        {
            double maxValue = double.MinValue;

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if(maxValue < matr[i, j])
                    {
                        maxValue = matr[i, j];
                    }
                }
            }

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                matr[i, i] = maxValue;
            }
        }
    }
}
