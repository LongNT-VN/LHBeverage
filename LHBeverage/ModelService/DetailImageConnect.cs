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
    public class DetailImageConnect
    {
       
        //public static List<DetailImage> SelectImage(string IdPro)
        //{
        //    using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var detailImages = connection.Query<DetailImage>($"select * from DetailImage where IDPro='{IdPro}'", new DynamicParameters());
        //        return detailImages.ToList();
        //    }
        //}
        public static List<DetailImage> LoadImage(Product product)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format($"select * from DetailImage where Email='{product.IDPro}'");
                var detailImages = connection.Query<DetailImage>("query", new DynamicParameters());
                return detailImages.ToList();
            }
        }
        public static void CreateDetailImage(DetailImage detailImage)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into DetailImage (IDPro,IDImage,ImageData) values (@IDPro,@IDImage,@ImageData)", detailImage);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
