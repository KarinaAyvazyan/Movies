using Microsoft;
using Movies.Enums;
using System.ComponentModel.DataAnnotations;

namespace Movies.ViewModels.Users
{
    public class UserViewModel
    {
       
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
      
        [MaxLength(30)]
        public string Email { get; set; }

        public StatusEnum Status { get; set; }  

        [Required]
        
        [MinLength(6,ErrorMessage ="Your password min length is 6")]
        [MaxLength(50)]
        public string Password{get;set;}
      //  [Required]

       // [Compare("Password",ErrorMessage ="Your password is different ")]
   
       // public string ConfirmPassword {get;set;}
   
        public DateTime DOB { get; set; }


    }
}
