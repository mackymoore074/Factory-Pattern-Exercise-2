using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product { Name = "Product1", Price = "100" },
            new Product { Name = "Product2", Price = "200" },
            new Product { Name = "Product3", Price = "300" }

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("Loading List Data");

            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving List Data");
        }
    }
}
