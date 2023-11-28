using Movies.Data.Entities;

namespace Movies.Data.Repositories.Interfaces
{
    public interface IFilmRepository
    {
        void Add(Film film);
        void Delete(Film film);
        Film GetById(int id);
        List<Film> GetAll();
        IQueryable<Film> GetAllQuerable();
        void SaveChanges();
    }
}
