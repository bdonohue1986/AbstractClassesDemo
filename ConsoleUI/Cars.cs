using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Cars : Vehicle
    {
        public Cars()
        {

        }


        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {Model} drives");
        }

        public bool HasTrunk { get; set; } = true;
        
       
       
    }
}
