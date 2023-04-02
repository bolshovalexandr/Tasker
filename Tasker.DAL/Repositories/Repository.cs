using Tasker.DAL.Domain.User;
using Tasker.DAL.Repositories.Abstract;
using T = Tasker.DAL.Domain.User;

namespace Tasker.DAL.Repositories
{
    public abstract class Repository : IUserRepository, IRepository<T.User>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
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
