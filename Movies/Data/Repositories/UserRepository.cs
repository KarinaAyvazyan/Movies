using Movies.Data.Entities;
using Movies.Data.Repositories.Interfaces;
using System.Drawing.Drawing2D;

namespace Movies.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FilmDataContext _context;
        public UserRepository(FilmDataContext context)
        { 
            _context = context; 
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges(); 
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user); 
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
          return _context.Users.ToList();
        }

        public User GetById(int id)
        {

            return _context.Users.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
