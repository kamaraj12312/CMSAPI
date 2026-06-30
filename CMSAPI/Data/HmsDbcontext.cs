using HMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace HMS.Data
{
    public class HmsDbcontext : DbContext
    {

        public HmsDbcontext(DbContextOptions<HmsDbcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<UserLogin>().ToTable("UserLogin", "dbo");
            modelBuilder.Entity<UserMaster>().ToTable("UserMaster", "dbo");
            modelBuilder.Entity<MedicationMaster>().ToTable("MedicationMaster", "dbo");
            modelBuilder.Entity<Customer>().ToTable("Customer", "dbo");
            modelBuilder.Entity<ProductTypeMaster>().ToTable("ProductTypeMaster", "dbo");
            modelBuilder.Entity<GSTmaster>().ToTable("GSTmaster", "dbo");
            modelBuilder.Entity<CartCustomer>().ToTable("CartCustomer", "dbo");
            modelBuilder.Entity<SalesReport>().ToTable("SalesReport", "dbo");
            modelBuilder.Entity<MedicationReport>().ToTable("MedicationReport", "dbo");
            modelBuilder.Entity<Status>().ToTable("Status", "dbo");
            modelBuilder.Entity<Category>().ToTable("Category", "dbo");
            modelBuilder.Entity<Supplier>().ToTable("Supplier", "dbo");

            //  modelBuilder.ApplyConfiguration(new TenantsMap());
        }

    }
}
