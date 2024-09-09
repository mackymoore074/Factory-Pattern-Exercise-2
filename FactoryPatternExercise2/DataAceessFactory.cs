using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAceessFactory 
    {
        public static IDataAccess GetDataAccessObject(string databaseType)
        {
            switch (databaseType)
            {
                case"ListData":
                case "List":
                    return new ListDataAccess();
                case "SQL":
                case "SQLServer":
                    return new SQLDataAccess();
                case "Mongo":  
                case"MongoDB":    
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();


            }
        }
    }
}
