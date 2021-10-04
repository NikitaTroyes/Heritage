using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Elephant : Animal
    {
        public Elephant(string name) : base(name, true) { }

        public override void Regime()
        {
            System.Console.WriteLine(_specie + " is herbivorous");
        }
    }
}
