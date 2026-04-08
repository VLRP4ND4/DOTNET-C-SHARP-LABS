using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class Radio
    {
        public bool IsOn { get; private set; }
        private void SetState(bool turnOn)
        {
            IsOn = turnOn;
            Console.WriteLine(turnOn ? "Радио включено." : "Радио выключено.");
        }
        public void On()
        {
            if (IsOn)
            {
                Console.WriteLine("Радио уже включено.");
                return;
            }
            SetState(true);
        }
        public void Off()
        {
            if (!IsOn)
            {
                Console.WriteLine("Радио уже выключено.");
                return;
            }
            SetState(false);
        }
    }
}
