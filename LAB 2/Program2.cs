using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---- LAB_2: Выбор автомобиля ----");
                Console.WriteLine("1) Toyota Supra");
                Console.WriteLine("2) Ferrari Enzo");
                Console.WriteLine("3) Bugatti Veyron");
                Console.WriteLine("0) Выход");
                Console.Write("\nВыберите: ");

                int choice = ReadInt();
                if (choice == 0) return;

                Car car = CreateCar(choice);
                if (car == null)
                {
                    Pause("Неверный выбор.");
                    continue;
                }

                CarMenu(car);
            }
        }

        static Car CreateCar(int choice)
        {
            if (choice == 1) return new Toyota("Toyota Supra");
            if (choice == 2) return new Ferrari("Ferrari F8");
            if (choice == 3) return new Bugatti("Bugatti Chiron");
            return null;
        }

        static void CarMenu(Car car)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------ Вы в машине: " + car.Model + " ------");
                car.PrintStatus();

                Console.WriteLine("\nДействия:");
                Console.WriteLine("1) Запустить двигатель");
                Console.WriteLine("2) Остановить двигатель");
                Console.WriteLine("3) Ускориться");
                Console.WriteLine("4) Замедлиться");
                Console.WriteLine("5) Включить радио");
                Console.WriteLine("6) Выключить радио");
                Console.WriteLine("7) Показать статус");
                Console.WriteLine("9) Выйти из машины (к выбору авто)");
                Console.WriteLine("0) Выход из программы");
                Console.Write("\nВыберите: ");

                int action = ReadInt();
                Console.WriteLine();

                switch (action)
                {
                    case 1:
                        car.Start();
                        Pause(null);
                        break;

                    case 2:
                        car.Stop();
                        Pause(null);
                        break;

                    case 3:
                        Console.Write("На сколько ускориться (км/ч): ");
                        car.SpeedUp(ReadInt());
                        Pause(null);
                        break;

                    case 4:
                        Console.Write("На сколько замедлиться (км/ч): ");
                        car.SlowDown(ReadInt());
                        Pause(null);
                        break;

                    case 5:
                        car.Radio.On();
                        Pause(null);
                        break;

                    case 6:
                        car.Radio.Off();
                        Pause(null);
                        break;

                    case 7:
                        car.PrintStatus();
                        Pause(null);
                        break;

                    case 9:
                        return;

                    case 0:
                        Environment.Exit(0);
                        return;

                    default:
                        Pause("Неверный пункт меню.");
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

                Console.Write("Введите число: ");
            }
        }

        static void Pause(string msg)
        {
            if (!string.IsNullOrWhiteSpace(msg))
                Console.WriteLine(msg);

            Console.WriteLine("\nНажмите Enter...");
            Console.ReadLine();
        }
    }
}
