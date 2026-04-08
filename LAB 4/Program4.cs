using System;

namespace LAB_4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Лабораторная работа №4");
                Console.WriteLine("1) Обратный порядок каждого второго слова");
                Console.WriteLine("2) Квардатная матрица чисел, найти максимум в каждой строке");
                Console.WriteLine("3) Невыровненная матрица букв, замена и транспонирование (заменить а на e)");
                Console.Write("\nВыберите пункт: ");

                int choice = ReadInt();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Lab4Tasks.Task1();
                        Pause();
                        break;

                    case 2:
                        Lab4Tasks.Task2();
                        Pause();
                        break;

                    case 3:
                        Lab4Tasks.Task3();
                        Pause();
                        break;

                    default:
                        Console.WriteLine("Неверный пункт меню.");
                        Pause();
                        break;
                }
            }
        }

        static int ReadInt()
        {
            while (true)
            {
                string s = Console.ReadLine();
                int value;
                if (int.TryParse(s, out value))
                    return value;

                Console.Write("Введите целое число: ");
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nНажмите Enter...");
            Console.ReadLine();
        }
    }
}