using System;

namespace LAB_5
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Лабораторная работа №5");
                Console.WriteLine("1) Перегрузка оператора '-' (должна получиться операция сложения)");
                Console.WriteLine("2) Планеты с радиусом больше радиуса Земли (индексатор)");
                Console.Write("\nВыберите пункт: ");

                int choice = ReadInt();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Task1Operation();
                        Pause();
                        break;

                    case 2:
                        Task2Planet();
                        Pause();
                        break;

                    default:
                        Console.WriteLine("Неверный пункт меню.");
                        Pause();
                        break;
                }
            }
        }

        static void Task1Operation()
        {
            Console.Write("Введите первое число: ");
            int a = ReadInt();  

            Console.Write("Введите второе число: ");
            int b = ReadInt();
                
            FunnyNumber n1 = new FunnyNumber(a);
            FunnyNumber n2 = new FunnyNumber(b);

            FunnyNumber result = n1 - n2;

            Console.WriteLine($"\n{a} - {b} = {result.Value}");
        }

        static void Task2Planet()
        {
            SolarSystem solar = new SolarSystem(8);

            solar[0] = new Planet("Меркурий", 2440);
            solar[1] = new Planet("Венера", 6052);
            solar[2] = new Planet("Земля", 6371);
            solar[3] = new Planet("Марс", 3390);
            solar[4] = new Planet("Юпитер", 69911);
            solar[5] = new Planet("Сатурн", 58232);
            solar[6] = new Planet("Уран", 25362);
            solar[7] = new Planet("Нептун", 24622);

            Console.WriteLine("Все планеты:");
            for (int i = 0; i < solar.Count; i++)
            {
                Console.WriteLine(solar[i]);
            }

            Console.WriteLine("\nПланеты, у которых радиус больше радиуса Земли:");
            double earthRadius = Planet.EarthRadius;

            for (int i = 0; i < solar.Count; i++)
            {
                if (solar[i].Radius > earthRadius)
                {
                    Console.WriteLine(solar[i]);
                }
            }
        }

        // шаблончики

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