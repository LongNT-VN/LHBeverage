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
    class LocationConnect
    {
        public static List<Province> LoadProvice()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var city = connection.Query<Province>($"select id,name from province", new DynamicParameters());
                return city.ToList();
            }
        }
        public static List<District> LoadDistrict(Province province)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var district = connection.Query<District>($"select id,name from district where province_id='{province.Id}'", new DynamicParameters());
                return district.ToList();
            }
        }
        public static List<Ward> LoadWard(District district)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var ward = connection.Query<Ward>($"select id,name from ward where district_id='{district.Id}'", new DynamicParameters());
                return ward.ToList();
            }
        }
        private static string LoadConnectionString(string id = "DataLocation")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
