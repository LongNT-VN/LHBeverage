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
    class DetaiCartConnect
    {
        //Lấy ra giỏ hàng thuộc khách hàng
        public static List<DetailCart> LoadDetailCart(Cart cart)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var detailcart = connection.Query<DetailCart>($"select * from DetailCart where IDCart='{cart.IDCart}'", new DynamicParameters());
                return detailcart.ToList();
            }
        }
        public static void CreateDetailCart(Cart cart, Product product, ProductIngredient productIngredient, string size, int quantity)
        {
            DetailCart detailcart = new DetailCart();
            detailcart.IDCart = cart.IDCart;
            detailcart.IDPro = product.IDPro;
            detailcart.ListIDIngredient += productIngredient.IDIngredient.ToString() + ",";
            List<DetailCart> cartcheck = LoadDetailCart(cart);
            //Kiểm tra trùng
            foreach(DetailCart detailCart in cartcheck)
            {
                if(detailCart!=null)
                {
                    //trùng size trùng product thì cộng số lượng lên
                    if (detailCart.IDPro == detailcart.IDPro && detailCart.Size == detailcart.Size)
                    {
                        detailcart.Quantity += quantity;
                    }
                    else
                    {
                        detailcart.Quantity = quantity;
                        detailcart.Size = size;
                    }
                }
            }
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into DetaiCart (IDCart, IDPro, ListIDIngredient, Quantity, Size) valuse (@IDCart, @IDPro, @ListIDIngredient, @Quantity, @Size)", detailcart);
            }
        }
        //Xóa item cart
        public static void DeleteDetailCart(DetailCart detailcart)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute($"DELETE FROM DetaiCart WHERE IDDetail='{detailcart.IDDetail}'");
            }
        }
        
        //Clear Cart
        public static void ClearCart(Cart cart)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute($"DELETE FROM DetaiCart WHERE IDCart='{cart.IDCart}'");
            }
        }


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
