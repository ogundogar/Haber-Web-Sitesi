using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models {
    public class StoreDbContext : DbContext {
        public StoreDbContext()
        {
        }

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
      
    }
   
}
