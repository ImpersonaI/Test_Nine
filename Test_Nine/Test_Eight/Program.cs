using System;

namespace Test_Nine
{
    class Program
    {
        static void Main(string[] args)
        {

            Aviation aviation = new Aviation(4.5, "Avia 1", 44, 44.5, 445.3);
            aviation.GetInfo();
            Machine machine = new Machine(4.5, "Machine 1", 44.5);
            machine.GetInfo();
            Destroyer destroyer = new Destroyer(4.5, "Destroyer 1", 445.5, 333.3, 444.5, 3);
            destroyer.GetInfo();
            Helicopter helicopter = new Helicopter(4.5, "Helicopter 1", 22.2, 3333.5, 333.2, 8);
            helicopter.GetInfo();
            Truck truck = new Truck(4444.3, "Truck 1", 43.5, 33333.5, 2);
            truck.GetInfo();
            Console.ReadKey();
        }
    }
}
