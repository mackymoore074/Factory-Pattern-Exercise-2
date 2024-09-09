using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database do you want to use???");
            Console.WriteLine("Please enter: Regular or list for a static list.");
            Console.WriteLine("Please enter: Sql for a MySQL DB.");
            Console.WriteLine("Please enter: Mongo for a Mongo DB.");
            string dbType = Console.ReadLine();

            IDataAccess dataAccess = DataAceessFactory.GetDataAccessObject(dbType);

            dataAccess.LoadData();
            dataAccess.SaveData();

            Console.WriteLine();

            Console.WriteLine("This is our Product");

            List<Product> Product = dataAccess.LoadData();



            for (int index = 0; index < Product.Count; index++)
            {
                Console.WriteLine($"Product Name: {Product[index].Name} Product Price: {Product[index].Price}");
            }
             Console.WriteLine();

            Console.WriteLine($"Foreach loop version");
            foreach (var product in Product)
            {
                Console.WriteLine($"Product Name: {product.Name} Product Price: {product.Price}");
            }

        }
    }
}
