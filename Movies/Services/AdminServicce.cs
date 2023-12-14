using Movies.Data.Repositories.Interfaces;
using Movies.Services.Interfaces;
using Movies.ViewModels.Users;
using System.Xml;

namespace Movies.Services
{
    public class AdminServicce:IAdminService
    {
        public readonly IAdminRepository _adminRepository;
        public AdminServicce(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public List<UserViewModel> GetAllUsers()
        {
            var users = _adminRepository.GetAll();
         return users.Select(x => new UserViewModel
            {
                Id = x.Id,
             FirstName=x.Name,
               Email=x.Email,   
            }).ToList();
        }
    }
}
