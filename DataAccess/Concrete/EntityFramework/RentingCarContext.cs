using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using User = Entities.Concrete.User;

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
        public DbSet<CarImage> tbl_CarImages { get; set; }
        public DbSet<Core.Entities.Concrete.User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
    }
}
