using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public abstract class Animal
    {
        protected string _specie;
        protected bool _hairy;

        public Animal (string specie, bool hairy)
        {
            _specie = specie;
            _hairy = hairy;

        }
        public void Numbermembers()
        {
            Console.WriteLine(_specie + " is tetrapod");
        }

        public virtual void Move()
        {
            System.Console.WriteLine(_specie + " is also quadruped");
        }

        public virtual void Reproduction()
        {
            System.Console.WriteLine(_specie + " is viviparous");
        }

        public void Eat()
        {
            Console.WriteLine(_specie + " eats with his mouth");
        }

        public virtual void Regime()
        {
            System.Console.WriteLine(_specie + " is omnivorous");
        }

    }

}
