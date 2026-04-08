using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class FunnyNumber
    {
        public int Value { get; set; }

        public FunnyNumber(int value)
        {
            Value = value;
        }

        public static FunnyNumber operator -(FunnyNumber a, FunnyNumber b)
        {
            return new FunnyNumber(a.Value + b.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}