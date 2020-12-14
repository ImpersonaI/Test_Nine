using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Nine
{
    class Truck : Machine
    {
        public double MaxCaredWeight { get; set; }
        public int NumberOfBridges { get; set; }

        public Truck(double power, string name, double speed, double maxcaredweight, int numberofbridges)
            : base(power, name, speed)
        {

            MaxCaredWeight = maxcaredweight;
            NumberOfBridges = numberofbridges;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Max cared weight = " + MaxCaredWeight);
            Console.WriteLine("Number of bridges = " + NumberOfBridges);
            Console.WriteLine();
        }
    }
}
