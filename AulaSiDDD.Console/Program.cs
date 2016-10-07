using AulaSiDDD.Domain.Interfaces.Service;
using AulaSiDDD.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSiDDD.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerService service = new CustomerVipService();
            CustomerConsole customer = new CustomerConsole(service);

            System.Console.WriteLine(customer.ReclamarPedido());
            System.Console.ReadLine();
        }
    }
}
