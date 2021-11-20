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
              connection.Query<Product>($"Update Product set IDCate='{product.IDCate}',Name ='{product.Name}',PriceS='{product.PriceS}',PriceM='{product.PriceM}',PriceL='{product.PriceL}',QuantitysizeS='{product.QuantitysizeS}',QuantitysizeM='{product.QuantitysizeM}',QuantitysizeL='{product.QuantitysizeL}',Description='{product.Description}' where IDPro='{product.IDPro}'", new DynamicParameters());           
            }
        
        }
        public static void UpdateProductQuantity(Product product,string size,int quantity)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                if(size=="S")
                {
                    Product productinfo = SelectProductByIDPro(product.IDPro);
                    connection.Query<Product>($"Update Product set QuantitysizeS='{productinfo.QuantitysizeS-quantity}' where IDPro='{product.IDPro}'", new DynamicParameters());
                }
                else if(size=="M")
                {
                    Product productinfo = SelectProductByIDPro(product.IDPro);
                    connection.Query<Product>($"Update Product set QuantitysizeM='{productinfo.QuantitysizeM - quantity}' where IDPro='{product.IDPro}'", new DynamicParameters());
                }
                else if(size == "L")
                {
                    Product productinfo = SelectProductByIDPro(product.IDPro);
                    connection.Query<Product>($"Update Product set QuantitysizeL='{productinfo.QuantitysizeL - quantity}' where IDPro='{product.IDPro}'", new DynamicParameters());
                }
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
                if(idcategory!=99999)
                {
                    var products = connection.Query<Product>($"select * from Product where IDCate = '{idcategory}' order by IDPro DESC", new DynamicParameters());
                    return products.ToList();
                }
                else
                {
                    var products = connection.Query<Product>($"select * from Product order by IDPro DESC", new DynamicParameters());
                    return products.ToList();
                }
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
        public static List<Product> SelectProductBySearch(string searchkey, int IDCate=999999)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                List<Product> productCate = new List<Product>();
                Category CateBefore = CategoryConnect.SelectCategory(IDCate);
                if (CateBefore != null)
                {
                    var productcate = connection.Query<Product>($"select * from Product where IDCate = '{CateBefore.IDCate}' and Name LIKE '%{searchkey}%' order by IDPro DESC", new DynamicParameters());
                    productCate = productcate.ToList();
                    return productCate.ToList();
                }
                else
                {
                    List<Category> Cates = CategoryConnect.Searchcategory(searchkey);
                    foreach (Category cate in Cates)
                    {
                        var productcate = connection.Query<Product>($"select * from Product where IDCate = '{cate.IDCate}' order by IDPro DESC", new DynamicParameters());
                        productCate = productcate.ToList();
                    }
                    var products = connection.Query<Product>($"select * from Product where Name LIKE '%{searchkey}%' order by IDPro DESC", new DynamicParameters());
                    List<Product> productbyName = new List<Product>();
                    productbyName = products.ToList();
                    foreach (Product product in productCate)
                    {
                        productbyName.Add(product);
                    }
                    return productbyName.ToList();
                }
            }
        }

        public static void CreateProduct(Product product)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Product (IDCate,IDCust,Name,PriceS,PriceM,PriceL,QuantitysizeS,QuantitysizeM,QuantitysizeL,Description,Type) values (@IDCate,@IDCust,@Name,@PriceS,@PriceM,@PriceL,@QuantitysizeS,@QuantitysizeM,@QuantitysizeL,@Description,@Type)", product);
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
