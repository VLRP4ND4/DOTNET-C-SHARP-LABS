using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class Toyota : Car
    {
        protected override int MaxSpeed => 300;
        public Toyota(string model = "Toyota Supra") : base(model) { }
    }

    public class Ferrari : Car
    {
        protected override int MaxSpeed => 450;
        public Ferrari(string model = "Ferrari Enzo") : base(model) { }
    }

    public class Bugatti : Car
    {
        protected override int MaxSpeed => 500;
        public Bugatti(string model = "Bugatti Veyron") : base(model) { }
    }
}
