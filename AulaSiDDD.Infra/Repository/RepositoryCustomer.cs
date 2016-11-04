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
            //Customer c1 = new Customer();
            //c1.Id = 1;
            //c1.BirthDate = DateTime.Now;
            //c1.Email = "ze@mail.com";
            //c1.Name = "Ze";

            //Customer c2 =  new Customer(){ Id = 2, BirthDate = DateTime.Now, Email = "raphael@mail.com", Name = "Raphael"};

            //Customer c3 = new Customer();
            //c1.Id = 3;
            //c1.BirthDate = DateTime.Now;
            //c1.Email = "maria@mail.com";
            //c1.Name = "Maria";

            //List<Customer> list = new List<Customer>();
            //list.Add(c1);
            //list.Add(c2);
            //list.Add(c3);

            DataContext x = new DataContext();
            return x.Customers.ToList();
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
