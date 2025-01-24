using Microsoft.EntityFrameworkCore;

namespace CRUDSystem.Data
{
    public class AppDbContext : DbContext
    {


        DbSet<Author> Authors {get; set;}
        DbSet<Carrer> Carrers {get; set;}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
      
    }
}
