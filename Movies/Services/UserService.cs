using Movies.Services.Interfaces;
using Movies.ViewModels;

namespace OnlineBook.Services
{
    public class UserService : IUserService
    {
        //  public bool Login(LoginViewModel model)
        //   {

        //    var user = _userRepository.GetAll().Any(x => (x.UserName == model.UserName ||
        //                                                       x.Email == model.UserName) &&
        //                                                       x.Password == model.Password);
        //    return existUser;
        //}
        // }
        public bool Login(LoginViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
