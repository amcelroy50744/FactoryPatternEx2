using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx
{
    public class Car : IVehicle 
    {
        public void Drive()
        {
            Console.WriteLine("We are driving a nice car");
        }
    }
}
