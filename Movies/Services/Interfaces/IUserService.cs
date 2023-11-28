using Movies.ViewModels;

namespace Movies.Services.Interfaces
{
    public interface IUserService
    {
        public bool Login(LoginViewModel model);

    }
}
