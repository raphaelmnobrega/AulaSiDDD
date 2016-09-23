using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSiDDD.Domain.Interfaces.Service
{
    public interface ICustomerService
    {
        Customer GetCustomer(int id);
        List<Customer> GetAll();
        string GetEmail(int id);
        string HelloWorld();
    }
}
