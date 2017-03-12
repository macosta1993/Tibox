﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibox.Models;
using Tibox.Repository;
using Tibox.Repository.Northwind;

namespace Tibox.UnitOfWork
{
    public class TiboxUnitOfWork : IUnitOfWork,  IDisposable
    {
        public TiboxUnitOfWork()
        {
            Customers = new CustomerRepository();
            orderrepost = new OrderRepository();
            supplierproduct = new SupplierRepository();
            OrdersItems = new BaseRepository<OrderItem>();
            Products = new BaseRepository<Product>();
            Supliers = new BaseRepository<Supplier>();
        }

        public ICustomerRepository Customers { get; private set; }
        public IRepository<Order> Orders { get; private set; }
        public IRepository<OrderItem> OrdersItems { get; private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Supplier> Supliers { get; private set; }

        public IOrderRepository orderrepost { get; private set; }

        public ISuplierRepository supplierproduct { get; private set; }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
