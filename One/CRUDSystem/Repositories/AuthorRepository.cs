
using CRUDSystem.Data;




namespace CRUDSystem.Repositories
{
    
    public class AuthorRepository
    {
        private readonly AppDbContext _context;


        public AuthorRepository(AppDbContext context)
        {
            _context = context;
        }


        public void GetAll()
        {
            _context
        }
    }
}