using Movies.ViewModels.Users;


namespace Movies.Services.Interfaces
{
    public interface IAdminService
    {

        public List<UserViewModel> GetAllUsers();
        //public bool Login(AdminViewModel adminViewModel);
    }
}
