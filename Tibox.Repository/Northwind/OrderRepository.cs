﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibox.Models;

namespace Tibox.Repository.Northwind
{
   public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public Order OrderWithOrdersitems(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", id);

                using (var multiple = connection.QueryMultiple("dbo.OrderWithOrdersitems",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure))
                {
                    var order = multiple.Read<Order>().Single();
                    order.Orders = multiple.Read<OrderItem>();
                    return order;
                }
            }
        }
    }
}
