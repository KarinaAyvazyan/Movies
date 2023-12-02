using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Data.Repositories.Interfaces;
using Movies.Services;
using Movies.Services.Interfaces;
using Movies.Data.Repositories;
using Movies.Services;

namespace Movies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<FilmDataContext>
           (opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MyFilmDB")));
            builder.Services.AddScoped<IFilmRepository, FilmRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IFilmService, FilmService>();
            builder.Services.AddScoped<IUserService, UserService>();   


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}