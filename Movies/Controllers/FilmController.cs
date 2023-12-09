using Microsoft.AspNetCore.Mvc;
using Movies.Data.Entities;
using Movies.Data.Repositories.Interfaces;
using Movies.Services.Interfaces;

using Movies.Data;
using Movies.ViewModels.Films;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace Movies.Controllers
{
    public class FilmController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
     //   private readonly FilmDataContext _context;
        private readonly IFilmService _filmService;
        public FilmController(IFilmService filmService, IWebHostEnvironment webHostEnvironment)
        {
            _filmService = filmService;   

            _webHostEnvironment = webHostEnvironment;
        }


   
        [HttpGet]
        public IActionResult AddEdit(int? id)

        {

            FilmAddEditViewModel model = id.HasValue ? _filmService.GetById(id.Value) : new FilmAddEditViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddEdit(FilmAddEditViewModel model, IFormFile Image)
        {

            if (Image != null)
            {

                var filename = model.Id.ToString();
                string path = _webHostEnvironment.WebRootPath + $"/Files/{Image?.FileName}";
                using var stream = new FileStream(path, FileMode.Create);

                //model.FileName = Path.GetFileName(path);    
                Image.CopyTo(stream);
                model.FileName = Image.FileName;
            }
            
                if (model.Id > 0)
                {
                    _filmService.Update(model);
                }
                else
                {
                    _filmService.Add(model);
                }

            
            
     
            return RedirectToAction("FilmIndex");
        }
        public IActionResult DeleteFilm(int id)
        {
            _filmService.Delete(id);
            return RedirectToAction("FilmIndex");

        }

        public IActionResult FilmIndex(FilmFilterModel model)
        {
            ViewBag.Filter = model;

            var data = _filmService.GetByFilter(model);
            return View(data);
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}

    