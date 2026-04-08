using System;
using System.IO;
using System.Text;

namespace LAB_3
{
    internal class Lab3Tasks
    {
        // 1. Генерация строк и запись в файл 
        public static void GenerateStrokes(string output)
        {
            Random rnd = new Random();

            int rows = rnd.Next(5, 11);

            Console.WriteLine("Количество строк: " + rows + "\n");


            string[] arr = new string[rows];

            const string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+*/|,.?{}[]:;'<> ";

            for (int i = 0; i < rows; i++)
            {
                int len = rnd.Next(5, 31);
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < len; j++)
                    sb.Append(alphabet[rnd.Next(alphabet.Length)]);

                arr[i] = sb.ToString();
            }

            StreamWriter sw = new StreamWriter(output, false, Encoding.UTF8);

            for (int i = 0; i < arr.Length; i++)
                sw.WriteLine(arr[i]);

            sw.Flush();
            sw.Close();

            Console.WriteLine("Файл создан: " + output);
            Console.WriteLine("\nСодержимое массива: \n");

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        // 2. Подсчет s из сгенерированного файла
        public static void CountS(string input)
        {
            if (!File.Exists(input))
            {
                Console.WriteLine("Файл не найден: " + input);
                return;
            }

            StreamReader sr = new StreamReader(input, Encoding.UTF8);

            StringBuilder result = new StringBuilder();
            bool first = true;

            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                int count = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 's')
                        count++;
                }

                if (!first)
                    result.Append(", ");

                result.Append(count);
                first = false;

                Console.WriteLine(line);
            }
  

            sr.Close();

            Console.WriteLine("\nКоличество символов 's' по строкам:");
            Console.WriteLine(result.ToString());
        }

        // 3. Перекодировать и записать в файл новый
        public static void Reencode(string input)
        {
            if (!File.Exists(input))
            {
                Console.WriteLine("Файл не найден: " + input);
                return;
            }

            try
            {
                Encoding enc866 = Encoding.GetEncoding(866);

                StreamReader sr = new StreamReader(input, enc866);
                string text = sr.ReadToEnd();
                sr.Close();

                string newPath = Path.Combine(Path.GetDirectoryName(input), "Task1_new.txt");

                StreamWriter sw = new StreamWriter(newPath, false, Encoding.UTF8);
                sw.Write(text);
                sw.Flush();
                sw.Close();

                Console.WriteLine("Новый текст:\n");
                Console.WriteLine(text);

                Console.WriteLine("\nСоздан файл UTF-8: " + newPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при перекодировке: " + ex.Message);
            }
        }

        // 4. Замена обьекта на класс
        public static void Replace(string input)
        {
            if (!File.Exists(input))
            {
                Console.WriteLine("Файл не найден:  " + input);
                return;
            }

            StreamReader sr = new StreamReader(input, Encoding.UTF8);
            string text = sr.ReadToEnd();
            sr.Close();

            string replaced = ReplaceWordTemplate(text, "объект", "класс");

            string newPath = Path.Combine(Path.GetDirectoryName(input), "Task2_new.txt");

            StreamWriter sw = new StreamWriter(newPath, false, Encoding.UTF8);
            sw.Write(replaced);
            sw.Flush();
            sw.Close();

            Console.WriteLine("Новый текст:\n");
            Console.WriteLine(replaced);

            Console.WriteLine("\nФайл сохранен: " + newPath);
        }

        // 5. Количество слов в файле
        public static void CountWords(string input)
        {
            if (!File.Exists(input))
            {
                Console.WriteLine("Файл не найден:  " + input);
                return;
            }

            StreamReader sr = new StreamReader(input, Encoding.UTF8);
            string text = sr.ReadToEnd();
            sr.Close();

            int words = CountWordsTemplate(text);

            Console.WriteLine("Количество слов в Task2.txt: " + words);
        }

        // 6. Список файлов и папок из Program Files
        public static void ListProgramFiles()
        {
            string path = @"C:\Program Files";
            DirectoryInfo di = new DirectoryInfo(path);

            try
            {
                Console.WriteLine("Содержимое: (" + path + ")");
                DirectoryInfo[] dirs = di.GetDirectories();
                for (int i = 0; i < dirs.Length; i++)
                    Console.WriteLine(dirs[i].Name);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Нет доступа к некоторым элементам.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        // Шаблончики
        private static string ReplaceWordTemplate(string text, string from, string to)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder word = new StringBuilder();

            for (int i = 0; i <= text.Length; i++)
            {
                char ch = (i < text.Length) ? text[i] : '\0';
                bool isWordChar = (i < text.Length) && char.IsLetterOrDigit(ch);

                if (isWordChar)
                {
                    word.Append(ch);
                }
                else
                {
                    if (word.Length > 0)
                    {
                        string w = word.ToString();
                        sb.Append(w == from ? to : w);
                        word.Clear();
                    }

                    if (i < text.Length)
                        sb.Append(ch);
                }
            }

            return sb.ToString();
        }

        private static int CountWordsTemplate(string text)
        {
            int count = 0;
            bool inWord = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetterOrDigit(text[i]))
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }

            return count;
        }
    }
}