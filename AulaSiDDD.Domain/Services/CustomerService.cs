using AulaSiDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSiDDD.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public string GetEmail(int id)
        {
            throw new NotImplementedException();
        }

        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
