using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Nine
{
    class Machine : Imachine
    {
        public double Power { get; set; }
        public string Name { get; set; }
        public double Speed { get; set; }

        public virtual void GetInfo()
        {

            Console.WriteLine("Power = "+ Power);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Speed = " + Speed);
            Console.WriteLine();
        }

        public Machine(double power, string name, double speed)
        {

            Power = power;
            Name = name;
            Speed = speed;
        }
    }
}
