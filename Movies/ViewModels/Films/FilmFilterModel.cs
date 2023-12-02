using Movies.Enums;

namespace Movies.ViewModels.Films
{
    public class FilmFilterModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public GenreEnum FilmGenre { get; set; }
        public DateTime? DOB { get; set; }  
        
       // public int PublisherId { get; set; }
    }
}
