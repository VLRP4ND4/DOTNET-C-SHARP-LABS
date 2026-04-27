using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;

namespace LAB10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\..\LAB 10_1\moviesData.json"
            );

            filePath = Path.GetFullPath(filePath);
            Console.WriteLine("Поиск файла: " + filePath);

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                Console.ReadKey();
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                MovieDatabaseJson data = JsonConvert.DeserializeObject<MovieDatabaseJson>(json);

                if (data == null)
                {
                    Console.WriteLine("Не удалось прочитать JSON.");
                    Console.ReadKey();
                    return;
                }

                using (AppDbContext db = new AppDbContext())
                {
                    if (data.Actors != null)
                    {
                        foreach (string actorName in data.Actors)
                        {
                            if (string.IsNullOrWhiteSpace(actorName))
                                continue;

                            db.Database.ExecuteSqlCommand(
                                "INSERT INTO public.actors(name) VALUES (@p0)",
                                actorName.Trim()
                            );
                        }
                    }

                    if (data.Movies != null)
                    {
                        foreach (MovieInfo movie in data.Movies)
                        {
                            if (movie == null || string.IsNullOrWhiteSpace(movie.Title))
                                continue;

                            string description = movie.Description ?? "";

                            db.Database.ExecuteSqlCommand(
                                "INSERT INTO public.movies(title, description) VALUES (@p0, @p1)",
                                movie.Title.Trim(),
                                description.Trim()
                            );
                        }
                    }
                }

                Console.WriteLine("Данные успешно сохранены в базу данных.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);

                if (ex.InnerException != null)
                    Console.WriteLine("InnerException: " + ex.InnerException.Message);

                if (ex.InnerException.InnerException != null)
                    Console.WriteLine("Inner InnerException: " + ex.InnerException.InnerException.Message);
            }

            Console.ReadKey();
        }
    }

    public class MovieInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class MovieDatabaseJson
    {
        public List<string> Actors { get; set; }
        public List<MovieInfo> Movies { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("MovieConnection")
        {
            Database.SetInitializer<AppDbContext>(null);
        }
    }
}