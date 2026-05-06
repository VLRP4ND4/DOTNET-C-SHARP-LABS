using System;
using System.Text;
using System.Xml;

namespace LAB_13
{
    internal class Program13
    {
        static string fileName = "imi_group.xml";

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n=== Лабораторная работа 13: XML в .NET ===");
                Console.WriteLine("1. Создать XML-файл");
                Console.WriteLine("2. Добавить студента в XML-файл");
                Console.WriteLine("3. Вывести данные из XML-файла");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateXmlFile();
                        break;
                    case "2":
                        AddStudent();
                        break;
                    case "3":
                        ReadXmlFile();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный пункт меню.");
                        break;
                }
            }
        }

        // 1. Создание XML-файла
        static void CreateXmlFile()
        {
            XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            writer.WriteStartElement("IMI");

            writer.WriteStartElement("Students");

            WriteStudent(writer, "S001", "Иванов", "Иван", "25000");
            WriteStudent(writer, "S002", "Петрова", "Анна", "30000");

            writer.WriteEndElement(); // Students

            writer.WriteStartElement("Subjects");

            WriteSubject(writer, "P001", "Программирование");
            WriteSubject(writer, "P002", "Базы данных");
            WriteSubject(writer, "P003", "Операционные системы");

            writer.WriteEndElement(); // Subjects

            writer.WriteEndElement(); // IMI

            writer.WriteEndDocument();
            writer.Close();

            Console.WriteLine($"XML-файл '{fileName}' успешно создан.");
        }

        static void WriteStudent(XmlTextWriter writer, string code, string surname, string name, string scholarship)
        {
            writer.WriteStartElement("Student");

            writer.WriteAttributeString("Code", code);
            writer.WriteElementString("Surname", surname);
            writer.WriteElementString("Name", name);
            writer.WriteElementString("Scholarship", scholarship);

            writer.WriteEndElement();
        }

        static void WriteSubject(XmlTextWriter writer, string code, string title)
        {
            writer.WriteStartElement("Subject");

            writer.WriteAttributeString("Code", code);
            writer.WriteElementString("Title", title);

            writer.WriteEndElement();
        }

        // 2. Добавление сведений в существующий XML-файл
        static void AddStudent()
        {
            XmlDocument document = new XmlDocument();

            try
            {
                document.Load(fileName);
            }
            catch
            {
                Console.WriteLine("Файл не найден. Сначала создайте XML-файл.");
                return;
            }

            Console.Write("Введите код студента: ");
            string code = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите размер стипендии: ");
            string scholarship = Console.ReadLine();

            XmlNode studentsNode = document.DocumentElement.SelectSingleNode("Students");

            XmlElement student = document.CreateElement("Student");

            XmlAttribute codeAttribute = document.CreateAttribute("Code");
            codeAttribute.Value = code;
            student.Attributes.Append(codeAttribute);

            XmlElement surnameElement = document.CreateElement("Surname");
            surnameElement.InnerText = surname;
            student.AppendChild(surnameElement);

            XmlElement nameElement = document.CreateElement("Name");
            nameElement.InnerText = name;
            student.AppendChild(nameElement);

            XmlElement scholarshipElement = document.CreateElement("Scholarship");
            scholarshipElement.InnerText = scholarship;
            student.AppendChild(scholarshipElement);

            studentsNode.AppendChild(student);

            document.Save(fileName);

            Console.WriteLine("Сведения о студенте успешно добавлены.");
        }

        // 3. Вывод данных из XML-файла
        static void ReadXmlFile()
        {
            XmlTextReader reader;

            try
            {
                reader = new XmlTextReader(fileName);
            }
            catch
            {
                Console.WriteLine("Файл не найден. Сначала создайте XML-файл.");
                return;
            }

            Console.WriteLine("\n=== Содержимое XML-файла ===");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    Console.WriteLine($"Элемент: {reader.Name}");

                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            Console.WriteLine($"  Атрибут: {reader.Name} = {reader.Value}");
                        }
                    }
                }

                if (reader.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine($"  Значение: {reader.Value}");
                }
            }

            reader.Close();
        }
    }
}
