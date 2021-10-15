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
    class ProductConnect
    {
        //public static List<ProductImage> SelecProductAndImage()
        //{
        //    using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var products = connection.Query<Product>("select * from Product,DetailImage where Product.IDPro = DetailImage.IDPro ", new DynamicParameters());
        //        return products.ToList();
        //    }
        //}

        public static List<Product> LoadProduct()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var products = connection.Query<Product>("select * from Product", new DynamicParameters());
                return products.ToList();
            }
        }

        public static void CreateProduct(Product product)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Product (IDCate,IDCust,Name,Price,Quantity,Description,Type) values (@IDCate,@IDCust,@Name,@Price,@Quantity,@Description,@Type)", product);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
