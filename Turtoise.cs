using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Turtoise : Animal
    {
        public Turtoise(string name) : base(name, false) { }

        public override void Reproduction()
        {
            System.Console.WriteLine(_specie + "is oviparous");
        }

        public override void Regime()
        {
            System.Console.WriteLine(_specie + " is herbivorous");
        }
    }
}
