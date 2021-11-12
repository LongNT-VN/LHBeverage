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
    class DetailOrderConnect
    {
        public static void CreateDetailOrder(Order order, Cart cart)
        {
            DetailOrder detailOrder = new DetailOrder();
            detailOrder.IDOrder = order.IDOrder;
            List<DetailCart> detailcarts = DetailCartConnect.LoadDetailCart(cart);
            foreach (DetailCart detailcart in detailcarts)
            {
                if (detailcart != null)
                {
                    detailOrder.Size = detailcart.Size;
                    detailOrder.Quantity = detailcart.Quantity;
                    detailOrder.IDPro = detailcart.IDPro;
                    detailOrder.Topping = detailcart.ListIDIngredient;
                    detailOrder.Price = detailcart.Price;
                    using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
                    {
                        connection.Execute("insert into DetailOrder (IDOrder, IDPro,Size,Quantity,Topping,Price) values (@IDOrder, @IDPro,@Size,@Quantity,@Topping,@Price)", detailOrder);
                    }
                }
            }
        }
        public static List<DetailOrder> SelectItemOrderByIDOrder(int IDOrder)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var detailOrders = connection.Query<DetailOrder>($"select * from DetailOrder where IDOrder = '{IDOrder}'", new DynamicParameters());
                return detailOrders.ToList();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
