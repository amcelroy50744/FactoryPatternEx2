﻿using System;

namespace FactoryEX2
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What data would you like to work with?");
            Console.WriteLine("Type: sql");
            Console.WriteLine("Type: mongo");
            Console.WriteLine("Type: list");

            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products =db.LoadData();
            db.SaveData();

            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price:{item.Price}");
            }

        }
    }
}
