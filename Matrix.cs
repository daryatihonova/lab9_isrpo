using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class Matrix
    {
        private double[,] matrix; // Закрытое поле - матрица вещественных чисел

        public int Rows { get; } // Свойство для определения количества строк матрицы
        public int Cols { get; } // Свойство для определения количества столбцов матрицы

        // Индексатор для доступа к элементам поля-массиву
        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        /// <summary>
        /// Конструктор с двумя параметрами - количество строк, количество столбцов матрицы
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            matrix = new double[Rows, Cols];
        }

        /// <summary>
        /// Конструктор с одним параметром - матрица вещественных чисел
        /// </summary>
        /// <param name="array"></param>
        public Matrix(double[,] array)
        {
            Rows = array.GetLength(0);
            Cols = array.GetLength(1);
            matrix = array;
        }

        /// <summary>
        /// Метод для вычисления количества элементов матрицы, больших заданного числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int CountElementsGreaterThan(double number)
        {
            int count = 0;
            foreach (var element in matrix)
            {
                if (element > number)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Метод для вычисления количества элементов матрицы, больших заданного числа 
        /// и расположенных в столбцах с номерами кратными заданному целому числу
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="divisor">делитель</param>
        /// <returns></returns>
        public int CountElementsGreaterThanMultiple(double number, int divisor)
        {
            int count = 0;
            for (int j = 0; j < Cols; j++)
            {
                if (j % divisor == 0)
                {
                    for (int i = 0; i < Rows; i++)
                    {
                        if (matrix[i, j] > number)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
