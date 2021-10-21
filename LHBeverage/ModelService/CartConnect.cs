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
    class CartConnect
    {
        //Lấy ra giỏ hàng thuộc khách hàng
        public static List<Cart> LoadCart(Customer customer)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var cart = connection.Query<Cart>($"select * from Cart where IDCus='{customer.IDCus}'", new DynamicParameters());
                return cart.ToList();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
