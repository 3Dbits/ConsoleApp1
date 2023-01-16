using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extending
{
    internal class Animal
    {
        public string? name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public Animal() { }

        public Animal(string name, double height, double weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }
    }
}
