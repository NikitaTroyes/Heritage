using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Lizard : Animal
    {
        public Lizard(string name) : base(name, false) { }

        public override void Reproduction()
        {
            System.Console.WriteLine(_specie + " is oviviviparous");
        }

        public override void Regime()
        {
            System.Console.WriteLine(_specie + " is mainly insectivorous");
        }
    }
}
