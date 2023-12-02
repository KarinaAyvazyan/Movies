using Movies.Data.Entities;
using Movies.Data.Repositories;
using Movies.Data.Repositories.Interfaces;
using Movies.Services.Interfaces;
using Movies.ViewModels.Users;

namespace Movies.Services
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
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        { 
            _userRepository = userRepository;   
        }
        public void Add(UserViewModel model)
        {
            var entity = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                DOB = model.DOB,
                Password = model.Password,
         
            };
            _userRepository.Add(entity);
           
        }
        public bool Login(LoginViewModel model)
        {
            var existUser = _userRepository.GetAll().Any(p =>  p.Email == model.Email &&
                                                               p.Password == model.Password );
            return existUser;
        }
  
        public void Delete(int Id)
        {
            var entity = _userRepository.GetById(Id);
            _userRepository.Delete(entity);
        }

        public List<UserViewModel> GetAllUsers()
        {
            var users = _userRepository.GetAll();
            return users.Select(p => new UserViewModel
            {
                Id = p.Id,
                FirstName = p.FirstName,
                Email = p.Email,

             
            }).ToList();
        }
        public UserViewModel GetById(int Id)
        {
            var entity = _userRepository.GetById(Id);
            return new UserViewModel
            {
                Id = entity.Id,
              
                Email = entity.Email,
                Password = entity.Password,
            };
        }
        public void Update(UserViewModel model)
        {
            var entity = _userRepository.GetById(model.Id);
            entity.FirstName = model.FirstName; 
            entity.LastName=model.LastName; 
            entity.DOB = model.DOB;
            entity.Email = model.Email;
            entity.Password = model.Password;
            _userRepository.SaveChanges();
         
        }

     
    }
}

