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
   public class SupplierRepository : BaseRepository<Supplier> , ISuplierRepository
    {
        public Supplier SupplierProductItems(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IDSUPPLIER", id);

                using (var multiple = connection.QueryMultiple("dbo.SupplierProductItems",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure))
                {
                    var suppli = multiple.Read<Supplier>().Single();
                    suppli.SupplierProduct = multiple.Read<Product>();
                    return suppli;
                }
            }
        }
    }
}
