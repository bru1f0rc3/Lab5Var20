using System;

namespace Lab5Var20
{
    public class Variant20
    {
        public static double Task1(double[,] x) // произведение элементов матрицы
        {
            double answer = 1;
            for (int i=0; i < 7; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    answer *= x[i, j];
                }
            }
            return answer;
        }

        public static double Task2(double[,] x) // нахождение макс. положительного числа последней строке
        {
            double max = x[6, 0];
            for (int j = 1; j < 9; j++)
            {
                if (x[6, j] > max)
                {
                    max = x[6, j];
                }
            }
            return max;
        }

        public static double[] Task3(double[,] x)
        {
            double[] H = new double[10];

            for (int j = 0; j < 10; j++) // Одномерный массив H
            {
                double multiplications = 1;
                for (int i = 0; i < 7; i++)
                {
                    multiplications *= x[i, j];
                }
                H[j] = multiplications;
            }

            return H;

        }

        public static double[] Task4(double[,] x) // Элемент E который меньше -2
        {
            int Min = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(x[i,j] < -2)
                    {
                        Min++;
                    }
                }
            }

            double[] E = new double[Min];
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (x[i,j] < -2)
                    {
                        E[count] = x[i,j];
                        count++;
                    }
                }
            }

            return E;
        }
    }
}
