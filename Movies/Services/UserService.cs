using Movies.Data.Entities;
using Movies.Data.Repositories;
using Movies.Data.Repositories.Interfaces;
using Movies.Services.Interfaces;
using Movies.ViewModels;
using Movies.ViewModels.Films;
using Movies.ViewModels.Users;

namespace Movies.Services
{
    public class UserService : IUserService
    {
       
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        { 
            _userRepository = userRepository;   
        }
        public void Add(UserViewModel model)
        {
            CheckEmail(model);
            var entity = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                DOB = model.DOB,
              Status = model.Status,
                Password = model.Password,
               // ConfirmPassword=model.ConfirmPassword,

            };
            _userRepository.Add(entity);
           
        }
        public bool Login(LoginViewModel model)
        {
            var regUser = _userRepository.GetAll().Any(p => p.Email == model.Email &&
                                                               p.Password == model.Password);
            return regUser;
       //     throw new Exception("err");
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
            CheckEmail(model);
            var entity = _userRepository.GetById(model.Id);
            entity.FirstName = model.FirstName; 
            entity.LastName=model.LastName; 
            entity.DOB = model.DOB;
            entity.Email = model.Email;
            entity.Password = model.Password;
            entity.Status = model.Status;   
           // entity.ConfirmPassword = model.ConfirmPassword; 
            _userRepository.SaveChanges();
         
        }
        private void CheckEmail(UserViewModel model)
        {
            bool checkUserExists
                = _userRepository.GetAll().Any(p=>p.Email == model.Email && p.Id != model.Id);  
            if (checkUserExists)
            {
                throw new Exception("User exists");
            }
        }


    }
}

