using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibox.Models;

namespace Tibox.Repository.Northwind
{
   public interface ICustomerRepository : IRepository<Customer>
    {
        Customer SearchCustomer(string FirstName, string LastName);
        Customer CustomerWithOrdes(int id);
    }
}
