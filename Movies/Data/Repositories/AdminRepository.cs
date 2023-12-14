using Movies.Data;
using Movies.Data.Entities;
using Movies.Data.Repositories.Interfaces;

namespace Movies.Data.Repositories
{
    public class AdminRepository:IAdminRepository
    {
        private readonly FilmDataContext _context;
        public AdminRepository(FilmDataContext context)
        { 
            _context = context; 
        
        }
   

        public List<Admin> GetAll()
        {
            return _context.Admins.ToList(); 
        }
    }
}
