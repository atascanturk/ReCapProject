using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentingCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentingCar; Trusted_Connection=true");
        }

        public DbSet<Car> tbl_Cars { get; set; }
        public DbSet<Brand> tbl_Brands { get; set; }
        public DbSet<Color> tbl_Colors { get; set; }
        public DbSet<Customer> tbl_Customers{ get; set; }
        public DbSet<Rental> tbl_Rentals { get; set; }
        public DbSet<User> tbl_Users { get; set; }
    }
}
