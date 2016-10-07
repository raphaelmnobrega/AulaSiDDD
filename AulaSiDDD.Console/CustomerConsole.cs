using AulaSiDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSiDDD.Console
{
    public class CustomerConsole
    {
        private ICustomerService _service;

        public CustomerConsole(ICustomerService service)
        {
            _service = service;
        }

        public string ReclamarPedido()
        {
            return _service.reclamarPedido();
        }
    }
}
