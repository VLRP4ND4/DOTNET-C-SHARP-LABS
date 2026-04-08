using System;

namespace LAB_5
{
    internal class SolarSystem
    {
        private Planet[] planets;

        public SolarSystem(int size)
        {
            planets = new Planet[size];
        }

        public int Count
        {
            get { return planets.Length; }
        }

        public Planet this[int index]
        {
            get
            {
                if (index < 0 || index >= planets.Length)
                    throw new IndexOutOfRangeException("Неверный индекс.");

                return planets[index];
            }
            set
            {
                if (index < 0 || index >= planets.Length)
                    throw new IndexOutOfRangeException("Неверный индекс.");

                planets[index] = value;
            }
        }
    }
}