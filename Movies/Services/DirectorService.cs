using Movies.Data.Repositories.Interfaces;
using Movies.Services.Interfaces;
using Movies.ViewModels.Directors;

namespace Movies.Services
{
    public class DirectorService:IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;   
        }

        public int Add(DirectorViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<DirectorViewModel> Filter(DirectorViewModel model)
        {
            throw new NotImplementedException();
        }

        public DirectorViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<DirectorViewModel> GetListForDropdown()
        {
            throw new NotImplementedException();
        }
    }
}
