using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Vehicles.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
           .Entity<ServiceShop>()
           .Property(e => e.CategoryVehicles)
           .HasConversion<string>();
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User>? User { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Part>? Parts { get; set; }
        public DbSet<ServiceShop>? ServiceShops { get; set; }
        public DbSet<CarWash>? CarWashes { get; set; }

    }
}