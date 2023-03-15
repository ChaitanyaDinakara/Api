using Microsoft.EntityFrameworkCore;
using MyProject9.Entities;

namespace MyProject9.Dbcontext
{
    public class Orders:DbContext
    {
        public DbSet<product> products { get; set; }

        public DbSet<Customerid> customerids { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<OrderData> orders { get; set; }

        public DbSet<LineItem> Lineitems { get; set; }

        public DbSet<Contact> contacts { get; set; }

        public Orders(DbContextOptions<Orders> options)
            : base(options)
        {

        }

   

    }
}
