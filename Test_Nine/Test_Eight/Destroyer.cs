using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Nine
{
    class Destroyer : Aviation
    {

        public int Generation { get; set; }
        
        public Destroyer(double power, string name, double speed, double maxheight, double powerofguns, int generation)
            : base(power, name, speed, maxheight, powerofguns)
        {

            Generation = generation;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Generation =" + Generation);
            Console.WriteLine();
        }
    }
}
