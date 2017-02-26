using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Tibox.Repository;
using Tibox.Models;

namespace Tibox.DataAccess.Tests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        private readonly IRepository _repository;
        public CustomerRepositoryTest()
        {
            _repository = new Repository.Repository();
        }
        [TestMethod]
        public void Get_All_Customers()
        {
            var result = _repository.GetAllCustomer();
            Assert.AreEqual(result.Count() > 0, true);
        }

        [TestMethod]
        public void Insert_Customer()
        {
            var customer = new Customer
            {
                FirstName = "Julio",
                LastName = "Velarde",
                City = "Huancavelica",
                Country = "Peru",
                Phone = "555-555-555"
            };
            var result = _repository.InsertCustomer(customer);
            Assert.AreEqual(result > 0, true);
        }

        [TestMethod]
        public void First_Customer_By_Id()
        {
            var customer = _repository.GetCustomerById(1);
            Assert.AreEqual(customer != null, true);

            Assert.AreEqual(customer.Id, 1);
            Assert.AreEqual(customer.FirstName, "Maria");
            Assert.AreEqual(customer.LastName, "Anders");
        }

        [TestMethod]
        public void Delete_Customer()
        {
            var customer = _repository.GetCustomerById(93);
            Assert.AreEqual(customer != null, true);

            Assert.AreEqual(_repository.DeleteCustomer(customer), true);
        }

        [TestMethod]
        public void Update_Customer()
        {
            var customer = _repository.GetCustomerById(1);            
            Assert.AreEqual(customer != null, true);

            Assert.AreEqual(_repository.UpdateCustomer(customer), true);
        }
    }
}
