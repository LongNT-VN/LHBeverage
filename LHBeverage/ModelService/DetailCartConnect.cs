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
    class DetailCartConnect
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
        public static void CreateDetailCart(Cart cart, int idproduct, string productIngredient, string size, int quantity)
        {
            DetailCart detailcart = new DetailCart();
            detailcart.IDCart = cart.IDCart;
            detailcart.IDPro = idproduct;
            detailcart.ListIDIngredient = productIngredient;
            detailcart.Size = size;
            bool ismodify = false;
            List<DetailCart> cartcheck = LoadDetailCart(cart);
            if(cartcheck.Count==0)
            {
                //chưa có detailcart nào
                detailcart.Quantity = quantity;
            }
            else
            {
                //Kiểm tra trùng
                foreach (DetailCart detailCart in cartcheck)
                {
                    if (detailCart != null)
                    {
                        
                        //trùng size, trùng product thì cộng số lượng lên
                        if (detailCart.IDPro == detailcart.IDPro && detailCart.Size == detailcart.Size)
                        {
                            int updateQuantity = detailCart.Quantity + quantity;
                            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
                            {
                                connection.Query<Product>($"Update DetailCart set Quantity='{updateQuantity}' where IDDetail = '{detailCart.IDDetail}'", new DynamicParameters());
                            }
                            ismodify = true;
                            break;
                        }
                    }
                }
            }
            // nếu chưa được cập nhật thì tạo mới
            if(!ismodify)
            {
                detailcart.Quantity = quantity;
                using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Execute("insert into DetailCart (IDCart, IDPro, ListIDIngredient, Quantity, Size) values (@IDCart, @IDPro, @ListIDIngredient, @Quantity, @Size)", detailcart);
                }
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
