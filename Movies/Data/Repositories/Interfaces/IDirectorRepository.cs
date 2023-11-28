using Movies.Data.Entities;
using System.Numerics;

namespace Movies.Data.Repositories.Interfaces
{
    public interface IDirectorRepository
    {
        void Add( Director director);
        Director GetById(int id);
        List<Director> GetAll();
        void Delete(Director director);
        void SaveChanges();
    }
}
