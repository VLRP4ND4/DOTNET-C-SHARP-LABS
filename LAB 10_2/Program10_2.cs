using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LAB10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\..\LAB 10_1\movies_data.json"
            );

            filePath = Path.GetFullPath(filePath);

            Console.WriteLine("Поиск файла: " + filePath);

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                Console.ReadKey();
                return;
            }

            string json = File.ReadAllText(filePath);
            MovieDatabaseJson data = JsonConvert.DeserializeObject<MovieDatabaseJson>(json);

            Console.WriteLine("Актеры:");
            foreach (string actor in data.Actors)
            {
                Console.WriteLine(actor);
            }

            Console.WriteLine();
            Console.WriteLine("Фильмы:");
            foreach (MovieInfo movie in data.Movies)
            {
                Console.WriteLine(movie.Title + " - " + movie.Description);
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
}