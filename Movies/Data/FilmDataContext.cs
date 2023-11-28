using Microsoft.EntityFrameworkCore;
using Movies.Data.Entities;


namespace Movies.Data
{
    public class FilmDataContext:DbContext
    {
        public FilmDataContext(DbContextOptions<FilmDataContext> opt) : base(opt) 
        {       
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Director> Directors { get; set; }  
        public DbSet<Admin> Admins { get; set; }    
        public DbSet<User> Users { get; set; }
      //  public DbSet<Publisher> Publishers { get; set; }
    }
}
