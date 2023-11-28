using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Movies.Enums
{
    public enum GenreEnum
    {
        Detective=1,
        Adventure=2,
        [Display(Name="Historical Fiction")]
        HistoricalFiction=3,
        [Display(Name = "Science Fiction")]
        ScienceFiction= 4,
        Fantasy=5,
        Horror=6,
        Autobiography=7,
        Romance =8,



    }
}
