using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Nine
{
    class Aviation : Machine
    {

        public double MaxHeight { get; set; }
        public double PowerOfGuns { get; set; }
        public Aviation(double power, string name, double speed, double maxheight, double powerofguns): base(power, name, speed)
        {

            MaxHeight = maxheight;
            PowerOfGuns = powerofguns;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Max height =" + MaxHeight);
            Console.WriteLine("Power of guns =" + PowerOfGuns);
            Console.WriteLine() ;
        }
    }
}
