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
    class ToppingConnect
    {
        public static List<Topping> LoadTopping()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var toppings = connection.Query<Topping>("select * from Topping order by IDTopping DESC", new DynamicParameters());
                return toppings.ToList();
            }
        }
        public static List<Topping> SelectToppingByCate(int idCate)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var toppings = connection.Query<Topping>($"select * from Topping where IDCate ='{idCate}' order by IDTopping DESC", new DynamicParameters());
                return toppings.ToList();
            }
        }
        public static Topping SelectToppingByID(int IDTopping)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var toppings = connection.Query<Topping>($"select * from Topping where IDTopping ='{IDTopping}'", new DynamicParameters());
                return toppings.First();
            }
        }

        public static void CreateTopping(Topping topping)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Topping (IDCate,ToppingName,Price) values (@IDCate,@ToppingName,@Price)", topping);
            }
        }
        public static void UpdateTopping(Topping topping)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute($"update Topping set IDCate='{topping.IDCate}',ToppingName='{topping.ToppingName}' where IDTopping='{topping.IDTopping}'", new DynamicParameters());
            }
        }
        public static void DeleteTopping(Topping topping)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute($"Delete From Topping where IDTopping='{topping.IDTopping}'", new DynamicParameters());
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
