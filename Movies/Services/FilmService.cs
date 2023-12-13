using Microsoft.EntityFrameworkCore;
using Movies.Data.Entities;
using Movies.Data.Repositories.Interfaces;
using Movies.Services.Interfaces;
using Movies.ViewModels.Films;
using System.Security.Policy;

namespace Movies.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;
        public FilmService(IFilmRepository filmRepository)
        {
           _filmRepository = filmRepository;
        }
        public void Add(FilmAddEditViewModel model)
        {
            CheckTitle(model);
            var film=new Film()
            {
               Title = model.Title,
               Description = model.Description, 
               FilmGenre=model.FilmGenre ,
               DirectorId=model.DirectorId ,
               //Image=model.Image,
               DOB = model.DOB,
           FileName = model.FileName ,
        
              
            };
            
           _filmRepository.Add(film);
           _filmRepository.SaveChanges();
            
              }



        public List<Film> GetByFilter(FilmFilterModel model)
        {

            var films = _filmRepository.GetAll()
                  .Where(u => model.Title == null || u.Title.ToLower().StartsWith(model.Title.ToLower())
                  && (model.Description!=null || u.Description.Contains(model.Description))

            ).ToList();


            //if (model.Title != null)
            //{
            //    return films.Where(u=>u.Title.ToLower().Contains(model.Title.ToLower())).ToList();
            //}

      
            return films;
        }

        public FilmAddEditViewModel GetById(int id)
        {
            var entity = _filmRepository.GetById(id);
            return new FilmAddEditViewModel
            {

                Title = entity.Title,
                Description = entity.Description,
                FilmGenre = entity.FilmGenre,
                Id = entity.Id,
                DirectorId = entity.DirectorId,
            //  Image = entity.Image,
                DOB = entity.DOB,
            FileName = entity.FileName,

            };
        }
        public void Delete(int id)
        {
            var entity = _filmRepository.GetById(id);
            _filmRepository.Delete(entity);
        }

        public void Update(FilmAddEditViewModel model)
        {
            CheckTitle(model);
            var entity = _filmRepository.GetById(model.Id);
            entity.Title=model.Title;
            entity.Description=model.Description;
            entity.FilmGenre =model.FilmGenre;
          //  entity.Image = model.Image;
            entity.DOB = model.DOB;
          
            entity.DirectorId = model.DirectorId;
            entity.FileName = model.FileName;   
      _filmRepository.SaveChanges();
        }
        private void CheckTitle(FilmAddEditViewModel model)
        {
            bool checkTitleExists
                = _filmRepository.GetAllQuerable()
                .Any(p => p.Title == model.Title && p.Id != model.Id);
            if (checkTitleExists)
            {
                throw new Exception("Film Name exists");
            }
        }
    }
}
