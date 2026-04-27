using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Lab10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> actors = new List<string>
            {
                "Харрисон Форд",
                "Эмма Уотсон",
                "Иэн Маккеллен",
                "Киану Ривз"
            };

            List<MovieInfo> movies = new List<MovieInfo>
            {
                new MovieInfo
                {
                    Title = "Индиана Джонс",
                    Description = "Приключенческий фильм о поисках древних артефактов."
                },
                new MovieInfo
                {
                    Title = "Сумерки",
                    Description = "Фэнтезийная история о любви девушки и вампира."
                },
                new MovieInfo
                {
                    Title = "Гарри Поттер",
                    Description = "Фильм о юном волшебнике и его друзьях."
                },
                new MovieInfo
                {
                    Title = "Джон Уик",
                    Description = "Крутой мужик бегает и стреляет."
                }
            };

            MovieDatabaseJson data = new MovieDatabaseJson
            {
                Actors = actors,
                Movies = movies
            };

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\moviesData.json");
            filePath = Path.GetFullPath(filePath);
            File.WriteAllText(filePath, json);

            Console.WriteLine("JSON-файл успешно создан.");
            Console.WriteLine("Файл сохранён: " + Path.GetFullPath(filePath));
            Console.WriteLine(json);

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
}