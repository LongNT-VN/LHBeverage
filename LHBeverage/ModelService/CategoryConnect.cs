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
                var categories = connection.Query<Category>("select * from Category order by IDCate DESC", new DynamicParameters());
                return categories.ToList();
            }
        }
        public static Category SelectCategory(int idCate)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var categories = connection.Query<Category>($"select * from Category where IDCate ='{idCate}'", new DynamicParameters());
                return categories.Count() !=0 ?categories.First() : null;
            }
        }
        public static void CreateCategory(Category category)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Category (Name) values (@Name)", category);
            }
        }
        public static void UpdateCategory(Category category)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute($"update Category set Name='{category.Name}' where IDCate='{category.IDCate}'", category);
            }
        }
        public static void DeleteCategory(Category category)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute($"Delete From Category where IDCate='{category.IDCate}'", category);
            }
        }

        public static List<Category> Searchcategory(string searchkey)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var categories = connection.Query<Category>($"Select * From Category where Name LIKE '%{searchkey}%'", new DynamicParameters());
                return categories.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
