using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManasDemirbas.Domain;
using System.Data.Entity;

namespace ManasDemirbas.Data
{
    public class FixtureContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        //public object Employee { get; internal set; }
        public DbSet<Employee> Employees { get; set; }
        //public object Fixture { get; internal set; }
        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<FixtureCategory> FixtureCategories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<FixtureContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
   
}
