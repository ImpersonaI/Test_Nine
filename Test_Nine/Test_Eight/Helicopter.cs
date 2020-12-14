using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Nine
{
    class Helicopter : Aviation
    {

        public int Caredman { get; set; }

        public Helicopter(double power, string name, double speed, double maxheight, double powerofguns, int caredman)
            : base(power, name, speed, maxheight, powerofguns)
        {

            Caredman = caredman;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The number of cared man = " + Caredman);
            Console.WriteLine();
        }
    }
}
