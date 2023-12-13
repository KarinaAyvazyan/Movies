
using Movies.Data.Entities;
using Movies.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.ViewModels.Films
{
    public class FilmAddEditViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public GenreEnum FilmGenre { get; set; }
        public int DirectorId { get; set; }
        // public string Image { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:'MM'/'yyyy}")]
        public DateTime? DOB { get; set; } 
       
        public string FileName { get; set; }
        //public int PublisherId { get; set; }

    }
}
