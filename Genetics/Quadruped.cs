using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Genetics
{
    public class Quadruped : Animal
    {
        public Quadruped(string name) : base(name, 4)
        {
        }

        public override void Move () 
        {
            Console.WriteLine($"Le {Name} se déplace en {NumberOfLegs} pattes.");
            Console.WriteLine("C'est un animal quadrupède.");
        }
    }
}