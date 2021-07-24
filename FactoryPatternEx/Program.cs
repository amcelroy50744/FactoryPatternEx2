
using System;

namespace FactoryPatternEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vechicle have");
            var wheelz = Console.ReadLine();
            IVehicle wheels = VehicleFactory.GetVehicle(wheelz);
            wheels.Drive();
            Console.ReadLine();

            
        }
        
    }
}
