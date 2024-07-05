using Microsoft.EntityFrameworkCore;
using RestApi.Models.Entities;

namespace RestApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        //seeders

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Mouse",
                    Description = "Lenovo Mouse",
                    Price = 2000
                },
                new Product{

                    Id = 2,
                    Name = "LED",
                    Description = "Dell LED",
                    Price = 5000
                }

                );
        }

    }
}
