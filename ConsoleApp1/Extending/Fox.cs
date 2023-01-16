using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extending
{
    internal class Fox : Animal
    {
        public string species { get; set; }
        public string color { get; set; }

        public Fox(string name, double height, double weight, string species, 
            string color)
            : base(name, height, weight)
        {
            this.species = species;
            this.color = color;
        }

        public new void Run()
        {
            Console.WriteLine("Run like a fox");
        }
    }
}
