using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LAB
{
    internal class AutoInput
    {
        static void Main()
        {
            Lab1Tasks class1 = new Lab1Tasks();
            Console.WriteLine("-----------------1-----------------");
            double a = 5, b = 8, x;
            class1.Task1(a, b);

            Console.WriteLine("\n\n\n-----------------2-----------------");
            double num1 = 3, num2 = 7;
            class1.Task2(num1, num2);

            Console.WriteLine("\n\n\n-----------------3-----------------");
            int k = 2215;
            class1.Task3(k);

            Console.WriteLine("\n\n\n-----------------4-----------------");
            double circleArea = 50, squareArea = 160;
            class1.Task4(circleArea, squareArea);

            Console.WriteLine("\n\n\n-----------------5-----------------");
            double kmh = 160, ms = 40;
            class1.Task5(kmh, ms);

            Console.WriteLine("\n\n\n-----------------6-----------------");
            int birthYear = 2005, birthMonth = 5, currentYear = 2026, currentMonth = 2;
            class1.Task6(birthYear, birthMonth, currentYear, currentMonth);

            Console.WriteLine("\n\n\n-----------------7-----------------");
            string name = "Гоголев";
            class1.Task7(name);

            Console.WriteLine("\n\n\n-----------------8-----------------");
            string day = "Среда";
            class1.Task8(day);

            Console.WriteLine("\n\n\n");
        }
    }
}
    