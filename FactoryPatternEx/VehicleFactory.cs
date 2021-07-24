using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx
{
   static class VehicleFactory
    {
        public static  IVehicle GetVehicle(string vehicleType) 
        {
            switch (vehicleType) 
            {
                case "2":
                    return new Motorcyle();
                case "4":
                    return new Car();
                case "18":
                    return new BigRigg();
                default:
                    return new Car();
                    

            }
        }
    }
}
