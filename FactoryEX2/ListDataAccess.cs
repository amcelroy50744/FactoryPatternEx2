using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryEX2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name="Xbox", Price= 350},
            new Product (){Name= "Guitar", Price = 1000},
            new Product (){Name= "Blendder", Price = 50},
            new Product (){Name= "Kite", Price = 25},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from  Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL Data Access.");
        }
    }
}
