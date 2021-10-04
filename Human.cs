using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Human : Animal 
    {
        public Human(string name) : base(name, true) { }

        public override void Move()
        {
            System.Console.WriteLine(_specie + " is also biped");
        }
    }
}
