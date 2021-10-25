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
        public static void CreateCart(Customer customer)
        {
            Cart cart = new Cart();
            string CreateAt = DateTime.Now.ToString();
            cart.CreateAt = CreateAt;
            cart.UpdateAt = CreateAt;
            cart.IDCus = customer.IDCus;
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Cart (IDCus, CreateAt, UpdateAt) values (@IDCus, @CreateAt, @UpdateAt)", cart);
            }
        }
                            
        public static Cart LoadCart(Customer customer)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var cart = connection.Query<Cart>($"select * from Cart where IDCus='{customer.IDCus}'", new DynamicParameters());
                return cart.First();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
