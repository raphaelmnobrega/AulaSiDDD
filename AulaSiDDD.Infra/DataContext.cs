using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaSiDDD.Domain;

namespace AulaSiDDD.Infra
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
