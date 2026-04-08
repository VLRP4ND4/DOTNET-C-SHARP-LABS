using System;
using System.IO;
using System.Text;

namespace LAB_3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Path.GetFullPath(Path.Combine(exePath, @"..\.."));

            string genPath = Path.Combine(projectPath, "GeneratedText.txt");
            string task1Path = Path.Combine(projectPath, "Task1.txt");
            string task2Path = Path.Combine(projectPath, "Task2.txt");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Лабораторная работа №3");
                Console.WriteLine("1) Сформировать массив строк и записать в файл (GeneratedText.txt)");
                Console.WriteLine("2) Посчитать количество 's' в каждой строке файла (GeneratedText.txt)");
                Console.WriteLine("3) Перекодировать Task1.txt в UTF-8 в новом файле (Task1_new.txt)");
                Console.WriteLine("4) Заменить слово 'объект' на 'класс' в Task2.txt (Task2_new.txt)");
                Console.WriteLine("5) Посчитать количество слов в Task2.txt");
                Console.WriteLine(@"6) Вывести содержимое папки C:\Program Files (Папки и файлы)");
                Console.Write("\nВыберите пункт: ");

                int choice = ReadInt();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Lab3Tasks.GenerateStrokes(genPath);
                        Pause();
                        break;

                    case 2:
                        Lab3Tasks.CountS(genPath);
                        Pause();
                        break;

                    case 3:
                        Lab3Tasks.Reencode(task1Path);
                        Pause();
                        break;

                    case 4:
                        Lab3Tasks.Replace(task2Path);
                        Pause();
                        break;

                    case 5:
                        Lab3Tasks.CountWords(task2Path);
                        Pause();
                        break;

                    case 6:
                        Lab3Tasks.ListProgramFiles();
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
                int val;

                if (int.TryParse(s, out val))
                    return val;

                Console.Write("Введите число: ");
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nНажмите Enter...");
            Console.ReadLine();
        }
    }
}