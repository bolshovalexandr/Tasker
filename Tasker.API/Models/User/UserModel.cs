using Tasker.Logic.Models.User;

namespace Tasker.API.Models.User
{
    public class UserModel
    {
        public UserModel() { }

        public UserModel(UserDTO user)
        {
            Id = user.Id;
            Name = user.Name;
            Surname = user.Surname;
            Email = user.Email;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
    }
}
