using Movies.Enums;

namespace Movies.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
       
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public StatusEnum Status { get; set; }


        public DateTime DOB { get; set; }
        public string Password { get; set; }
      //  public string ConfirmPassword { get;set; }
    
    }
}
