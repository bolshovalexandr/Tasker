using Tasker.DAL.Domain.User;

namespace Tasker.DAL
{
    public class UserMockData
    {
        private List<User> _users;

        public UserMockData() {
            _users = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                _users.Add(new User() {
                    Id = i,
                    Name = $"User # {i}"
                });
            }
        }

        public List<User> Users => _users;
    }
}