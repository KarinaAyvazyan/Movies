using Movies.Data.Entities;

namespace Movies.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetById(int id);
        List<User> GetAll();
        void Delete(User user);
        void SaveChanges();
    }
}
