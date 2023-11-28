using   Movies.Data.Entities;
using Movies.Data.Repositories.Interfaces;

namespace Movies.Data.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly FilmDataContext _context;
        public DirectorRepository(FilmDataContext context)
        {
            _context = context;
        }
        public void Add(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void Delete(Director director)
        {
           _context.Directors.Remove(director);
            _context.SaveChanges();
        }

        public List<Director> GetAll()
        {
            return _context.Directors.ToList();       
        }

        public Director GetById(int id)
        {
            return _context.Directors.FirstOrDefault(p=>p.Id==id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
