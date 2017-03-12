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
    public class SupplierRepositoryTest
    {
        private readonly IUnitOfWork _IUnitOfWork;

        public SupplierRepositoryTest()
        {
            _IUnitOfWork = new TiboxUnitOfWork();
        }

        [TestMethod]
        public void SupplierProductItemsII()
        {
            var X = _IUnitOfWork.supplierproduct.SupplierProductItems(1);
            Assert.AreEqual(X != null, true);

            Assert.AreEqual(X.SupplierProduct.Any(), true);
        }
    }
}
