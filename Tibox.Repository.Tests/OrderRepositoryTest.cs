using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibox.Models;
using Tibox.Repository;
using Tibox.UnitOfWork;

namespace Tibox.DataAccess.Tests
{
    [TestClass]
    public class OrderRepositoryTest
    {
        private readonly IRepository<Order> _repository;
        private readonly IUnitOfWork _IUnitOfWork;

        public OrderRepositoryTest()
        {
            _IUnitOfWork = new TiboxUnitOfWork();
        }

        //[TestMethod]
        //public void Get_All_Orders()
        //{
        //    var orderList = _IUnitOfWork..GetAll();
        //    Assert.AreEqual(orderList.Count() > 0, true);
        //}

        [TestMethod]
        public void Customer_With_Orders()
        {
            var customer = _IUnitOfWork.orderrepost.OrderWithOrdersitems(1);
            Assert.AreEqual(customer != null, true);

            Assert.AreEqual(customer.Orders.Any(), true);
        }
    }
}
