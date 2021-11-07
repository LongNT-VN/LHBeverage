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
                    detailOrder.IDPro = detailcart.IDPro;
                    using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
                    {
                        connection.Execute("insert into DetailOrder (IDOrder, IDPro) values (@IDOrder, @IDPro)", detailOrder);
                    }
                }
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
