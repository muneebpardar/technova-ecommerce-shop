using Microsoft.EntityFrameworkCore;
using technova_ecommerce_shop.Models.Entities;
using technova_ecommerce.Models.Entities;

namespace technova_ecommerce_shop.Models
{
    public class DatabaseContext : DbContext

    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<technova_ecommerce.Models.Entities.Product> Product { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;
    }
}
