using Dapper;
using LHBeverage.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.ModelService
{
    class CategoryConnect
    {
        public static List<Category> LoadCategory()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var categories = connection.Query<Category>("select * from Category", new DynamicParameters());
                return categories.ToList();
            }
        }
       
        public static void CreateCategory(Category category)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Category (Name) values (@Name)", category);
            }
        }
       
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
