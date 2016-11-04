using AulaSiDDD.Domain;

namespace AulaSiDDD.Infra.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AulaSiDDD.Infra.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AulaSiDDD.Infra.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Customers.AddOrUpdate(
                c => c.Name,
                new Customer(){Name = "Jose", BirthDate = DateTime.Now, Email = "ze@mail.com"},
                new Customer(){Name = "Maria", BirthDate = DateTime.Now, Email = "maria@mail.com"},
                new Customer(){Name = "Francisco", BirthDate = DateTime.Now, Email = "chico@mail.com"}
                );
                
                
               
        }
    }
}
