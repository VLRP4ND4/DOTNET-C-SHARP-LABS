using System;

namespace LAB_5
{
    internal class Planet
    {
        public const int EarthRadius = 6371;

        public string Name { get; set; }
        public int Radius { get; set; }

        public Planet(string name, int radius)
        {
            Name = name;
            Radius = radius;
        }

        public override string ToString()
        {
            return Name + " (радиус: " + Radius + " км)";
        }
    }
}