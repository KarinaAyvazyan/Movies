using Movies.Data.Entities;
using Movies.ViewModels.Films;

namespace Movies.Services.Interfaces
{
    public interface IFilmService
    {
        void Add(FilmAddEditViewModel model);
        void Delete(int id);
        FilmAddEditViewModel GetById(int id);
        List<Film> GetByFilter(FilmFilterModel model);
        void Update(FilmAddEditViewModel model);
    }
}
