using lab_9;

class Program
{
    static void Main(string[] args)
    {
        // Создание матрицы 3x3
        Matrix matrix = new Matrix(3, 3);

        // Заполнение матрицы значениями
        matrix[0, 0] = 1.5;
        matrix[0, 1] = 2.5;
        matrix[0, 2] = 3.5;
        matrix[1, 0] = 4.5;
        matrix[1, 1] = 5.5;
        matrix[1, 2] = 6.5;
        matrix[2, 0] = 7.5;
        matrix[2, 1] = 8.5;
        matrix[2, 2] = 9.5;

        // Вывод матрицы на экран
        Console.WriteLine("Матрица:");
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Cols; j++)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }

        // Подсчет элементов больше заданного числа
        double numberToCompare = 5.0;
        int countGreaterThan = matrix.CountElementsGreaterThan(numberToCompare);
        Console.WriteLine($"Количество элементов больше {numberToCompare}: {countGreaterThan}");

        // Подсчет элементов больше заданного числа в столбцах с номерами кратными заданному делителю
        int divisor = 1; // кратные единице
        int countGreaterThanMultiple = matrix.CountElementsGreaterThanMultiple(numberToCompare, divisor);
        Console.WriteLine($"Количество элементов больше {numberToCompare} в столбцах с номерами кратными {divisor}: {countGreaterThanMultiple}");
        // Подсчет элементов больше заданного числа в четных столбцах
        divisor = 2; // кратные двум
        countGreaterThanMultiple = matrix.CountElementsGreaterThanMultiple(numberToCompare, divisor);
        Console.WriteLine($"Количество элементов больше {numberToCompare} в четных столбцах: {countGreaterThanMultiple}");
    }
}