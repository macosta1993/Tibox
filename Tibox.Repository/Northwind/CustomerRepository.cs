using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibox.Models;

namespace Tibox.Repository.Northwind
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public Customer CustomerWithOrdes(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", id);

                using (var multiple = connection.QueryMultiple("dbo.CustomerWithOrders",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure))
                {
                    var customer = multiple.Read<Customer>().Single();
                    customer.Orders = multiple.Read<Order>();
                    return customer;
                }
            }
        }

        public Customer SearchCustomer(string firstname, string lastname)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", firstname);
                parameters.Add("@LastName", lastname);

                return connection.QueryFirst<Customer>("dbo.CustomerSearchByNames",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
