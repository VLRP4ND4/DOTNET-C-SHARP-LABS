using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new Student { StudentId = 1,   Surname = "Иванов",   Name = "Иван",  Stipend = 150,   Kurs = 1, City = "Орел",    Birthday = new DateTime(1982, 3, 12),  UnivId = 10 },
                new Student { StudentId = 3,   Surname = "Петров",   Name = "Петр",  Stipend = 200,   Kurs = 3, City = "Курск",   Birthday = new DateTime(1980, 12, 1),  UnivId = 10 },
                new Student { StudentId = 6,   Surname = "Сидоров",  Name = "Вадим", Stipend = 150,   Kurs = 4, City = "Москва",  Birthday = new DateTime(1979, 6, 7),   UnivId = 22 },
                new Student { StudentId = 55,  Surname = "Белкин",   Name = "Вадим", Stipend = 250,   Kurs = 5, City = "Воронеж", Birthday = new DateTime(1980, 1, 7),   UnivId = 10 },
                new Student { StudentId = 12,  Surname = "Зайцева",  Name = "Ольга", Stipend = 10000, Kurs = 2, City = "Липецк",  Birthday = new DateTime(1981, 5, 1),   UnivId = 10 },
                new Student { StudentId = 10,  Surname = "Кузнецов", Name = "Борис", Stipend = 10000, Kurs = 2, City = "Брянск",  Birthday = new DateTime(1900, 1, 21),  UnivId = 10 },
                new Student { StudentId = 100, Surname = "Иванов",   Name = "Иван",  Stipend = 0,     Kurs = 4, City = "Якутск",  Birthday = new DateTime(2000, 12, 12), UnivId = 12 }
            };

            var exams = new[]
            {
                new Exam { ExamId = 145, StudentId = 12,  SubjId = 10, Mark = 5, ExamDate = new DateTime(2000, 1, 12) },
                new Exam { ExamId = 34,  StudentId = 32,  SubjId = 10, Mark = 4, ExamDate = new DateTime(2000, 1, 23) },
                new Exam { ExamId = 75,  StudentId = 55,  SubjId = 10, Mark = 5, ExamDate = new DateTime(2000, 1, 5)  },
                new Exam { ExamId = 238, StudentId = 12,  SubjId = 22, Mark = 3, ExamDate = new DateTime(1999, 6, 17) },
                new Exam { ExamId = 639, StudentId = 55,  SubjId = 22, Mark = 2, ExamDate = new DateTime(1999, 6, 22) },
                new Exam { ExamId = 43,  StudentId = 6,   SubjId = 22, Mark = 4, ExamDate = new DateTime(2000, 1, 18) }
            };

            var lecturers = new[]
            {
                new Lecturer { LecturerId = 24,  Surname = "Колесников", Name = "Борис",   City = "Воронеж", SubjId = 10 },
                new Lecturer { LecturerId = 46,  Surname = "Никонов",    Name = "Иван",    City = "Воронеж", SubjId = 10 },
                new Lecturer { LecturerId = 276, Surname = "Николаев",   Name = "Виктор",  City = "Воронеж", SubjId = 10 },
                new Lecturer { LecturerId = 74,  Surname = "Лагутин",    Name = "Павел",   City = "Москва",  SubjId = 22 },
                new Lecturer { LecturerId = 108, Surname = "Струков",    Name = "Николай", City = "Москва",  SubjId = 22 },
                new Lecturer { LecturerId = 328, Surname = "Сорокин",    Name = "Павел",   City = "Орел",    SubjId = 10 }
            };

            var subjects = new[]
            {
                new Subject { SubjId = 10, SubjName = "Информатика", Hour = 56, Semester = 1 },
                new Subject { SubjId = 22, SubjName = "Физика",       Hour = 34, Semester = 1 },
                new Subject { SubjId = 43, SubjName = "Математика",   Hour = 56, Semester = 2 },
                new Subject { SubjId = 94, SubjName = "Английский",   Hour = 56, Semester = 3 },
                new Subject { SubjId = 73, SubjName = "Физкультура",  Hour = 34, Semester = 5 },
                new Subject { SubjId = 56, SubjName = "История",      Hour = 34, Semester = 4 }
            };

            //-------------------------------------------------------------------------------------------------------------------------------

            // 1
            Console.WriteLine("1. Студенты, у которых фамилия или имя начинается на 'И':");
            var q1 =
                from s in students
                where s.Surname.StartsWith("И") || s.Name.StartsWith("И")
                select s;

            foreach (var s in q1)
            {
                Console.WriteLine($"{s.Surname} {s.Name}, курс {s.Kurs}, город {s.City}, стипендия {s.Stipend}");
            }

            Console.WriteLine();

            // 2
            Console.WriteLine("2. Оценки студентов 2 курса, отсортированные по фамилии:");
            var q2 =
                from s in students
                join e in exams on s.StudentId equals e.StudentId
                where s.Kurs == 2
                orderby s.Surname
                select new
                {
                    s.Surname,
                    s.Name,
                    e.Mark,
                    e.SubjId,
                    e.ExamDate
                };

            foreach (var item in q2)
            {
                Console.WriteLine($"{item.Surname} {item.Name} | Оценка: {item.Mark} | Предмет ID: {item.SubjId} | Дата: {item.ExamDate:dd.MM.yyyy}");
            }

            Console.WriteLine();

            // 3
            Console.WriteLine("3. Преподаватели и предметы:");
            var q3 =
                from l in lecturers
                join sub in subjects on l.SubjId equals sub.SubjId
                select new
                {
                    l.Surname,
                    l.Name,
                    SubjectName = sub.SubjName
                };

            foreach (var item in q3)
            {
                Console.WriteLine($"{item.Surname} {item.Name} - {item.SubjectName}");
            }

            Console.WriteLine();

            // 4
            Console.WriteLine("4. Студенты курса >= 3 с максимальной стипендией:");
            var maxStipend = students
                .Where(s => s.Kurs >= 3)
                .Max(s => s.Stipend);

            var q4 =
                from s in students
                where s.Kurs >= 3 && s.Stipend == maxStipend
                select new
                {
                    s.Surname,
                    s.Name,
                    s.Kurs,
                    s.Stipend
                };

            foreach (var item in q4)
            {
                Console.WriteLine($"{item.Surname} {item.Name} | Курс: {item.Kurs} | Стипендия: {item.Stipend}");
            }

            Console.WriteLine();

            // 5
            Console.WriteLine("5. Средняя оценка по информатике:");
            var avgInfo =
                (from e in exams
                 join sub in subjects on e.SubjId equals sub.SubjId
                 where sub.SubjName == "Информатика"
                 select e.Mark)
                .Average();

            Console.WriteLine(Math.Round(avgInfo, 1));

            Console.ReadKey();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------

    class Student
    {
        public int StudentId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public double Stipend { get; set; }
        public int Kurs { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }
        public int UnivId { get; set; }
    }

    class Exam
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int SubjId { get; set; }
        public int Mark { get; set; }
        public DateTime ExamDate { get; set; }
    }

    class Lecturer
    {
        public int LecturerId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int SubjId { get; set; }
    }

    class Subject
    {
        public int SubjId { get; set; }
        public string SubjName { get; set; }
        public int Hour { get; set; }
        public int Semester { get; set; }
    }
}