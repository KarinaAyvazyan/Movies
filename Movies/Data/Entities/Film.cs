using Movies.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Data.Entities
{
    public class Film
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string? Description { get; set; }
        public GenreEnum FilmGenre { get; set; }
        public DateTime? DOB { get; set; } 
     
        [ForeignKey("Director")] 
        public int DirectorId { get; set; }
        public Director Director { get; set; }  
        public string FileName { get;set; }
    }
}
