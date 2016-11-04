using AulaSiDDD.Domain.Interfaces.Repository;
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
        private IRepositoryCustomer _repository;

        public CustomerService(IRepositoryCustomer repository)
        {
            _repository = repository;
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public string GetEmail(int id)
        {
            throw new NotImplementedException();
        }

       
        public string reclamarPedido()
        {
            return _repository.reclamarPedido(); 
        }
    }
}
