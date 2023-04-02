namespace Tasker.DAL.Repositories.Abstract
{
    public interface IRepository<T>
    {
        public T Get(int id);
        public T Save(T entity);
        public void Delete(int id);
        public ICollection<T> Get(Func<T, bool> where);

    }
}
