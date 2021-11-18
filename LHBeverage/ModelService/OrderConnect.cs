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
    class OrderConnect
    {
        //Lấy ra giỏ hàng thuộc khách hàng
        public static void CreateOrder(Cart cart, int Shipping = 0, int Discount = 0, int LHCoin =0, string Deliverymethod ="")
        {
            Order order = new Order();
            order.DateOrder = DateTime.Now.ToString();
            order.IDCus = cart.IDCus;
            order.Status = "Confirm";
            int total = 0;
            int Totalpayment = 0;
            //Lấy tất cả các detail carts để lấy tổng tiền.
            List<DetailCart> detailcarts = DetailCartConnect.LoadDetailCart(cart);
            foreach (DetailCart detailcart in detailcarts)
            {
                if(detailcart!=null)
                {
                    total+=detailcart.Price;
                }
            }
            Totalpayment = total - LHCoin - (total - LHCoin) * Discount / 100 + Shipping;
            order.Total = total;
            order.Discount = Discount;
            order.LHcoin = LHCoin;
            order.Totalpayment = Totalpayment;
            order.Deliverymethod = Deliverymethod;
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into 'Order'(IDCus,DateOrder,Status,Total,Discount,LHcoin,Totalpayment,Deliverymethod) values (@IDCus,@DateOrder,@Status,@Total,@Discount,@LHcoin,@Totalpayment,@Deliverymethod)", order);
                var successorder = connection.Query<Order>($"select * from 'Order' where IDCus='{order.IDCus}' and DateOrder = '{order.DateOrder}'", new DynamicParameters()).First();
                DetailOrderConnect.CreateDetailOrder(successorder, cart);
            }
        }
        // Lấy tất cả các order của khách hàng
        public static List<Order> LoadOrder(Customer customer)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var order = connection.Query<Order>($"select * from 'Order' where IDCus='{customer.IDCus}'", new DynamicParameters());
                return order.ToList();
            }
        }
        public static List<Order> LoadAllOrder()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var order = connection.Query<Order>($"select * from 'Order' order by IDOrder DESC", new DynamicParameters());
                return order.ToList();
            }
        }
     
        public static List<Order> GetOrderByStatus(Customer customer,String status)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var order = connection.Query<Order>($"select * from 'Order' where IDCus='{customer.IDCus}' and Status='{status}'", new DynamicParameters());
                return order.ToList();
            }
        }

        public static Order GetOrderByID(int id)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var order = connection.Query<Order>($"select * from 'Order' where IDOrder='{id}'", new DynamicParameters());
                return order.First();
            }
        }

        public static void ModifyOrder(Order order,String status)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Query<Order>($"Update 'Order' set Status='{status}' where IDOrder = '{order.IDOrder}'", new DynamicParameters());
            }
                
        }
        public static void UpdateReasonOrder(Order order, String reason, String status)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Query<Order>($"Update 'Order' set Reason='{reason}', Status='{status}' where IDOrder = '{order.IDOrder}'", new DynamicParameters());
            }

        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
