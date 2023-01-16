using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal class Audi : Vehicle
    {
        public bool IsDoorOpen()
        {
            //business logic
            if (true)
            {
                return true;
            }

            return false;
        }

        public void StartEngine()
        {
            //some business logic
        }
    }
}
