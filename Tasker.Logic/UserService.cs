using Tasker.DAL.Repositories.Abstract;
using Tasker.Logic.Models.User;

namespace Tasker.Logic
{
    public class UserService { 

        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) { 
            _userRepository = userRepository;
        }


        public UserDTO Get (int id)
        {
            var user = _userRepository.Get(id);
            var userDTO = new UserDTO()
            {
                Id = user.Id,
                Name = user.Name,
                Email = "li-service@li.li",
                Surname = "Li"
            };
            return userDTO;
        }
    }

}