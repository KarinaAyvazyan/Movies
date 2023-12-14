using Movies.Data.Entities;

namespace Movies.Data.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        public List<Admin> GetAll();  
    }
}
