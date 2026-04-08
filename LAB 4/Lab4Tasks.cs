using System;

namespace LAB_4
{
    internal class Lab4Tasks
    {
        // 1. перевернуть каждое второе слово наоборот
        public static void Task1()
        {
            Console.WriteLine("Введите предложение, состоящее только из слов и предлогов:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Пустая строка.");
                return;
            }

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < words.Length; i += 2)
            {
                words[i] = ReverseString(words[i]);
            }

            string result = string.Join(" ", words);

            Console.WriteLine("\nРезультат:");
            Console.WriteLine(result);
        }

        // 2. квадратная матрица целых чисел, найти максимум с каждой строки
        public static void Task2()
        {
            Console.Write("Введите размер квадратной матрицы n: ");
            int n = ReadPositiveInt();

            int[,] matrix = new int[n, n];
            Random rnd = new Random();

            Console.WriteLine("\nИсходная матрица:\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, 100);
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            int[] maxInRows = new int[n];

            for (int i = 0; i < n; i++)
            {
                int max = matrix[i, 0];

                for (int j = 1; j < n; j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }

                maxInRows[i] = max;
            }

            Console.WriteLine("\nМаксимальные элементы по строкам:");

            for (int i = 0; i < maxInRows.Length; i++)
            {
                Console.Write(maxInRows[i]);
                if (i < maxInRows.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        // 3. Невыровненная матрица букв, замена a на e + транспонирование
        public static void Task3()
        {
            Random rnd = new Random();

            Console.Write("Введите количество строк невыровненной матрицы: ");
            int rows = ReadPositiveInt();

            char[][] matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                int cols = rnd.Next(3, 8); // длина строки 3..7
                matrix[i] = new char[cols];

                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = (char)('a' + rnd.Next(0, 11)); // от a до k
                }
            }

            Console.WriteLine("\nИсходная матрица:");
            PrintJaggedMatrix(matrix);

            char[][] replacedMatrix = new char[rows][];
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                replacedMatrix[i] = new char[matrix[i].Length];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'a') 
                    {
                        replacedMatrix[i][j] = 'e';
                        count += 1;
                    }
                    else
                        replacedMatrix[i][j] = matrix[i][j];
                }
            }

            Console.WriteLine("\nМатрица после замены 'a' на 'e':");
            PrintJaggedMatrix(replacedMatrix);

            Console.WriteLine("\nКоличество замен: " + count);

            char[][] transposed = TransposeJaggedMatrix(replacedMatrix);

            Console.WriteLine("\nТранспонированная матрица:");
            PrintJaggedMatrixWithSpaces(transposed);
        }

        // шаблончики

        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private static int ReadPositiveInt()
        {
            while (true)
            {
                string s = Console.ReadLine();
                int value;

                if (int.TryParse(s, out value) && value > 0)
                    return value;

                Console.Write("Введите положительное целое число: ");
            }
        }

        private static void PrintJaggedMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintJaggedMatrixWithSpaces(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == '\0')
                        Console.Write("  ");
                    else
                        Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static char[][] TransposeJaggedMatrix(char[][] matrix)
        {
            int maxCols = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Length > maxCols)
                    maxCols = matrix[i].Length;
            }

            char[][] result = new char[maxCols][];

            for (int i = 0; i < maxCols; i++)
            {
                result[i] = new char[matrix.Length];

                for (int j = 0; j < matrix.Length; j++)
                {
                    if (i < matrix[j].Length)
                        result[i][j] = matrix[j][i];
                    else
                        result[i][j] = '\0';
                }
            }

            return result;
        }
    }
}
