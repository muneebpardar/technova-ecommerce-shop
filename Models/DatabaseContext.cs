using Microsoft.EntityFrameworkCore;
using technova_ecommerce_shop.Models.Entities;

namespace technova_ecommerce_shop.Models
{
    public class DatabaseContext : DbContext

    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<technova_ecommerce_shop.Models.Entities.Products> Products { get; set; } = default!;
    }
}
