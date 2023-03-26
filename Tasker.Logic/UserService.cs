using Tasker.Logic.Models.User;

namespace Tasker.Logic
{
    public class UserService { 

        public UserService() { }

        public UserDTO Get (int id)
        {
            var userDTO = new UserDTO()
            {
                Id = id,
                Name = "Litest" + new Random(100).Next().ToString(),
                Email = "li-service@li.li",
                Surname = "Li"
            };
            return userDTO;
        }
    }

}