using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Genetics
{
    public class Biped : Animal
    {
        public Biped(string name) : base(name, 2)
        {
        }

        public override void Move () 
        {
            Console.WriteLine($"Le {Name} se déplace en {NumberOfLegs} pattes.");
            Console.WriteLine("C'est un animal bipède.");
        }

    }
}