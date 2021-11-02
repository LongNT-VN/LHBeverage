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
        public static void UpdateProduct(Product product)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
              connection.Query<Product>($"Update Product set IDCate='{product.IDCate}',Name ='{product.Name}',PriceS='{product.PriceS}',PriceM='{product.PriceM}',PriceL='{product.PriceL}',Quantity='{product.Quantity}',Description='{product.Description}' where IDPro='{product.IDPro}'", new DynamicParameters());           
            }
        
        }
        public static List<Product> LoadProduct()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var products = connection.Query<Product>("select * from Product order by IDPro DESC", new DynamicParameters());
                return products.ToList();
            }
        }
        public static List<Product> SelectProductByCategory(int  idcategory)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var products = connection.Query<Product>($"select * from Product where IDCate = '{idcategory}' order by IDPro DESC", new DynamicParameters());
                return products.ToList();
            }
        }
        public static Product SelectProductByIDPro(int IDPro)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var products = connection.Query<Product>($"select * from Product where IDPro = '{IDPro}'", new DynamicParameters());
                return products.First();
            }
        }
        public static void CreateProduct(Product product)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Product (IDCate,IDCust,Name,PriceS,PriceM,PriceL,Quantity,Description,Type) values (@IDCate,@IDCust,@Name,@PriceS,@PriceM,@PriceL,@Quantity,@Description,@Type)", product);
            }
        }
        public static void DeleteProduct(int idpro)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute($"Delete From Product where IDPro='{idpro}'", new DynamicParameters());
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
