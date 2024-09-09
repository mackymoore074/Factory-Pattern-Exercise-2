using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Loading data from SQL");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Saving data from SQL");

            return new List<Product>()
            {
                new Product() { Name = "Product1" },
                new Product() { Name = "Product2" },
                new Product() { Name = "Product3" },
                new Product() { Name = "Product4" },
                new Product() { Name = "Product5" }
            };
        }
    }
}
