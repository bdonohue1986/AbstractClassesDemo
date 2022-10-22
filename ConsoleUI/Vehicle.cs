using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public  string Make { get; set; }
        public  string Model { get; set; }

        public  int Year { get; set; }

        public abstract void Drive();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The {Model} is in auto pilot");
        }


    }
}
