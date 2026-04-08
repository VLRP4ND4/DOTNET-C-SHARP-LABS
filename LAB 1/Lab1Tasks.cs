using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LAB
{
    internal class Lab1Tasks
    {
         public void Task1(double a, double b)
        {
            double x = -b / a;
            Console.WriteLine($"{a}x + {b} = 0: x = {x}");
        }

        public void Task2(double num1, double num2)
        {
            if (num1 > num2) Console.WriteLine($"{num1} > {num2}");
            else if (num1 == num2) Console.WriteLine($"{num1} = {num2}");
            else Console.WriteLine($"{num1} < {num2}");
        }

        public void Task3(int k)
        {
            if (k % 10 == 1 && k % 100 != 11) Console.WriteLine($"Мы нашли {k} гриб в лесу");
            else if (k % 10 > 1 && k % 10 < 5 && (k % 100 < 10 || k % 100 > 20)) Console.WriteLine($"Мы нашли {k} грибa в лесу");
            else Console.WriteLine($"Мы нашли {k} грибов в лесу");
        }


        public void Task4(double circleArea, double squareArea)
        {
            double diametr = 2 * Math.Sqrt(circleArea / Math.PI);
            double side = Math.Sqrt(squareArea);
            double diagonal = side * Math.Sqrt(2);

            Console.WriteLine("Диаметр круга: " + diametr);
            Console.WriteLine("Сторона квадрата: " + side);
            Console.WriteLine("Диагональ квадрата: " + diagonal);

            if (diagonal <= diametr) Console.WriteLine("Квадрат поместится в круге");
            else Console.WriteLine("Квадрат не поместится в круге");

            if (diametr <= side) Console.WriteLine("Круг поместится в квадрате");
            else Console.WriteLine("Круг не поместится в квадрате");
        }

        public void Task5(double kmh, double ms)
        {
            double mstokmh = ms * 3.6;
            Console.WriteLine("ms to kmh: " + mstokmh);
            if (kmh > mstokmh) Console.WriteLine($"{kmh} km/h > {ms} m/sec");
            else if (kmh == mstokmh) Console.WriteLine($"{kmh} km/h = {ms} m/sec");
            else Console.WriteLine($"{kmh} km/h < {ms} m/sec");
        }

        public void Task6(int birthYear, int birthMonth, int currentYear, int currentMonth)
        {
            int age = currentYear - birthYear;
            if (birthMonth > currentMonth) age--;
            Console.WriteLine($"Age: {age}");
        }

        public void Task7(string name)
        {
            if (name.EndsWith("ов")) Console.WriteLine($"Здравствуйте господин {name}!");
            else if (name.EndsWith("ова")) Console.WriteLine($"Здравствуйте госпожа {name}!");
            else Console.WriteLine($"Здравствуйте господин(госпожа) {name}!");
        }

        public void Task8(string day)
        {
            switch (day)
            {
                case "Понедельник":
                    Console.WriteLine("Системы управления данными, Социология, Программирование на платфорие .NET, Вычислительные методы");
                    break;
                case "Вторник":
                    Console.WriteLine("НЕТ ПАР");
                    break;
                case "Среда":
                    Console.WriteLine("Физкультура, Программная инженерия, Проектная деятельность, Социология");
                    break;
                case "Четверг":
                    Console.WriteLine("Блокчейн технологии, Программная инженерия");
                    break;
                case "Пятница":
                    Console.WriteLine("Системы управления контентом, Программирование на платфорие .NET, Технологии сети Интернет");
                    break;
                case "Суббота":
                    Console.WriteLine("Физкультура, Основы безопасности ИТ, Основы безопасности ИТ");
                    break;
                case "Воскресенье":
                    Console.WriteLine("ВЫХОДНОЙ");
                    break;
            }
        }
    }
}
