using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Nine
{
    interface Imachine
    {
         double Power { get; set; }
         string Name { get; set; }
         double Speed { get; set; }
         void GetInfo();
    }
}
