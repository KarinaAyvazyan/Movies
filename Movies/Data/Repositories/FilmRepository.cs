using Movies.Data;
using Movies.Data.Entities;
using Movies.Data.Repositories.Interfaces;

namespace OnlineBook.Data.Repositories
{
    public class FilmRepository:IFilmRepository
    {
        private readonly FilmDataContext _context;
        public FilmRepository(FilmDataContext context)
        {
            _context = context;
        }

        public void Add(Film film)
        {
            _context.Films.Add(film);       
            _context.SaveChanges(); 
        }

        public void Delete(Film film)
        {
            _context.Films.Remove(film);    
            _context.SaveChanges(); 
        }

        public List<Film> GetAll()
        {
            return _context.Films.ToList(); 
        }

        public IQueryable<Film> GetAllQuerable()
        {
           return _context?.Films.AsQueryable(); 
        }

        public Film GetById(int id)
        {
            return _context?.Films.FirstOrDefault(b => b.Id == id);
        }

        public void SaveChanges()
        {
            _context?.SaveChanges();
        }
    }
}
