using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx
{
   public class BigRigg : IVehicle
    {
        public void Drive() 
        { Console.WriteLine("We are driving a BigRigg"); }
    }
}
