using E_Commercial_Db.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commercial_Db.Context
{
    class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            Database.Connection.ConnectionString = @"Data Source=GIZEM;Initial Catalog=ECommercialDb;Integrated Security=True;";
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
