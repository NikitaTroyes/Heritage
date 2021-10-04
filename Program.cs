using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animalsSet = new Animal[5];

            Lizard lizard = new Lizard("Gecko");
            Turtoise turtoise = new Turtoise("Chelonia");
            Elephant elephant = new Elephant("Asian elephant");
            Chimpanzee chimpanzee = new Chimpanzee("Pan");
            Human human = new Human("Homo");

            animalsSet[0] = lizard;
            animalsSet[1] = turtoise;
            animalsSet[2] = elephant;
            animalsSet[3] = chimpanzee;
            animalsSet[4] = human;
         
            foreach (Animal animal in animalsSet)

            {
                Console.WriteLine("-----------------------------------------");
                animal.Numbermembers();
                animal.Move();
                animal.Reproduction();
                animal.Eat();
                animal.Regime();
            }

            Console.ReadLine();

        }
    }
}
