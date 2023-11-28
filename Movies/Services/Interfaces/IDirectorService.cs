using Movies.ViewModels.Directors;

namespace Movies.Services.Interfaces
{
    public interface IDirectorService
    {
        public List<DirectorViewModel> GetListForDropdown();
        public List<DirectorViewModel> Filter(DirectorViewModel model);
        public DirectorViewModel GetById(int id);
        public int Add(DirectorViewModel model);
        public void Delete(int Id);
    }
}
