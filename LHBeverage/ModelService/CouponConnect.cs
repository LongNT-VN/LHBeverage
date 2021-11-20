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
    class CouponConnect
    {
        public static void CreateCart(string Code,int Discountpercent, DateTime date)
        {
            Coupon coupon = new Coupon();
            string CreateAt = DateTime.Now.ToString();
            string Date = date.ToString();
            coupon.Code = Code;
            coupon.Discountpercent = Discountpercent;
            coupon.CreateAt = CreateAt;
            coupon.Date = Date;
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Coupon (Code, Discountpercent, CreateAt, Date) values (@Code,@Discountpercent,@CreateAt,@Date)", coupon);
            }
        }

        public static List<Coupon> GetAllCoupon()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var coupon = connection.Query<Coupon>($"select * from Coupon", new DynamicParameters());
                return coupon.ToList();
            }
        }
        public static Coupon GetCouponbyCode(string Code)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var coupon = connection.Query<Coupon>($"select * from Coupon where Code='{Code}'", new DynamicParameters());
                return coupon.Count() != 0 ? coupon.First() : null;
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
