using System;

namespace LAB_2
{
    public abstract class Car
    {
        public string Model { get; }
        public int Speed { get; private set; }
        public bool EngineOn { get; private set; }
        public Radio Radio { get; } = new Radio();
        protected virtual int MaxSpeed => int.MaxValue;
        protected Car(string model)
        {
            Model = model;
        }


        public virtual void Start()
        {
            if (EngineOn)
            {
                Console.WriteLine($"{Model}: двигатель уже запущен.");
                return;
            }
            EngineOn = true;
            Console.WriteLine($"{Model}: двигатель запущен.");
        }

        public virtual void Stop()
        {
            if (!EngineOn)
            {
                Console.WriteLine($"{Model}: двигатель уже остановлен.");
                return;
            }
            else if (Speed == 0 && EngineOn)
            {
                EngineOn = false;
                Console.WriteLine($"{Model}: двигатель остановлен, скорость = 0.");
            }
            else 
            {
                Console.WriteLine("Нельзя отключить двигатель на ходу, снизьте скорость до нуля.");
            }
        }

        public virtual void SpeedUp(int delta)
        {
            if (!EngineOn)
            {
                Console.WriteLine($"{Model}: нельзя ускоряться — двигатель выключен.");
                return;
            }
            if (delta <= 0)
            {
                Console.WriteLine($"{Model}: ускорение должно быть > 0.");
                return;
            }

            if (MaxSpeed == int.MaxValue)
            {
                Speed += delta;
                Console.WriteLine($"{Model}: скорость = {Speed} км/ч.");
                return;
            }

            int newSpeed = Speed + delta;
            if (newSpeed > MaxSpeed)
            {
                Speed = MaxSpeed;
                Console.WriteLine($"{Model}: достигнут лимит ({MaxSpeed} км/ч)! Скорость = {Speed} км/ч.");
            }
            else
            {
                Speed = newSpeed;
                Console.WriteLine($"{Model}: скорость = {Speed} км/ч.");
            }
        }

        public virtual void SlowDown(int delta)
        {
            if (delta <= 0)
            {
                Console.WriteLine($"{Model}: замедление должно быть > 0.");
                return;
            }

            int newSpeed = Speed - delta;
            Speed = newSpeed < 0 ? 0 : newSpeed;

            Console.WriteLine($"{Model}: скорость = {Speed} км/ч.");
        }

        public void PrintStatus()
        {
            Console.WriteLine($"[{Model}] Двигатель: {(EngineOn ? "ВКЛ" : "ВЫКЛ")}, Скорость: {Speed} км/ч, Радио: {(Radio.IsOn ? "ВКЛ" : "ВЫКЛ")}");
        }
    }
}