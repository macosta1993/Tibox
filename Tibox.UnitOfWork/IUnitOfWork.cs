using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibox.Models;
using Tibox.Repository;
using Tibox.Repository.Northwind;

namespace Tibox.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        //IRepository<Order> Orders { get; }
        IRepository<OrderItem> OrdersItems { get; }
        IRepository<Product> Products { get; }
        IRepository<Supplier> Supliers { get; }

        IOrderRepository orderrepost { get; }

        ISuplierRepository supplierproduct { get; }
    }
}
