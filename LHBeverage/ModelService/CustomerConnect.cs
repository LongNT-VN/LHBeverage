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
using System.Windows.Forms;

namespace LHBeverage.ModelService
{
    class CustomerConnect
    {
        public static List<Customer> LoadCustomer()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var customer = connection.Query<Customer>("select * from Customer", new DynamicParameters());
                return customer.ToList();
            }
        }
      
        public static bool IsCustomerExisted(String Email)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format($"select * from Customer where Email='{Email}'");
                var customer = connection.Query<Customer>(query);
                if (customer.Count() != 0)
                {
                    return true;
                }
                return false;
            }
        }
        public static void CreateCustomer(Customer customer)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Customer (Name, Email, Password, Age, Gender, Address, PhoneNumber, Authorized) values (@Name, @Email, @Password, @Age, @Gender, @Address, @PhoneNumber, @Authorized)", customer);
            }
        }
        public static int CheckLogin(string email, string password)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format($"select IDCus from Customer where Email='{email}' and Password ='{password}'");
                var customer = connection.Query<Customer>(query);
                if(customer.Count() != 0)
                {
                    return customer.First().IDCus;
                }
                return -1;
            }
        }
        public static Customer CustomerInfo(int idCus)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format($"select * from Customer where IDCus='{idCus}'");
                var customer = connection.Query<Customer>(query);
                return customer.First();
            }
        }
        public static Customer GetCustomerByEmail(string Email)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format($"select * from Customer where Email='{Email}'");
                var customer = connection.Query<Customer>(query);
                return customer.First();
            }
        }
        public static void UpdateCustomer(Customer customer)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Query<Customer>($"Update Customer set Email ='{customer.Email}',Password='{customer.Password}',Age='{customer.Age}',Gender='{customer.Gender}',Address='{customer.Address}', PhoneNumber = '{customer.PhoneNumber}',Authorized='{customer.Authorized}',Name='{customer.Name}',Avatar='{customer.Avatar}' where IDCus='{customer.IDCus}'", new DynamicParameters());
            }

        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
