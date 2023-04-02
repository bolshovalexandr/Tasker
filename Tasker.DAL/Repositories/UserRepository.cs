using Tasker.DAL.Domain.User;
using Tasker.DAL.Repositories.Abstract;
using T = Tasker.DAL.Domain.User;

namespace Tasker.DAL.Repositories
{
    public class UserRepository : IUserRepository, IRepository<T.User>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            var user = new T.User()
            {
                Id = id,
                Name = "Litest rnd# " + new Random(100).Next().ToString(),
            };
            return user;
        }

        public ICollection<User> Get(Func<User, bool> where)
        {
            throw new NotImplementedException();
        }

        public User Save(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
