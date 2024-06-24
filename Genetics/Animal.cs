using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Genetics
{
    public abstract class Animal
    {
        public string Name { get; protected set; }        
        public int NumberOfLegs { get; protected set; }

        public Animal (string name, int numberOfLegs)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
        }

        public virtual void Move () 
        {

        }

        public void Eat ()
        {
            Console.WriteLine($"{Name} mange.");
        }
    }
}