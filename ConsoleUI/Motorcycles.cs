using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycles : Vehicle
    {
        public Motorcycles()
        {

        }
        public override void Drive()
        {
            Console.WriteLine($"The {Make} drove to get gas.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"The {Make} speeds off");
        }
        public bool Has2wheels { get; set; } = true;
        public bool HasSideCar { get; set; } = false;
    }
}
