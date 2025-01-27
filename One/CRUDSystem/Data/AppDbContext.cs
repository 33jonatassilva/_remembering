using Microsoft.EntityFrameworkCore;

namespace CRUDSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        DbSet<Author> Authors {get; set;}
      
    }
}
