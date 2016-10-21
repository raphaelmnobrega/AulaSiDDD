using AulaSiDDD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaSiDDD.Domain;

namespace AulaSiDDD.Infra.Repository
{
    public class RepositoryCustomer : IRepositoryCustomer
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

        public string reclamarPedido()
        {
            //Devo fazer uma consulta no BD e receber os dados que eu quero
            return "Reclamação Aceita!";
        }
    }
}
