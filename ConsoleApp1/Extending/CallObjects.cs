using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extending
{
    public class CallObjects
    {
        public void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal animal2 = new Animal("Mate", 2.0, 50.0);

            Animal animal3 = new Fox("Ante", 3.0, 50.0, "snow fox", "orange");
            Fox animal4 = new Fox("Ante2", 32.0, 502.0, "red fox", "red");

            Console.WriteLine(animal);
            Console.WriteLine(animal2);
            Console.WriteLine(animal3);
            Console.WriteLine(animal4);
        }
    }
}
