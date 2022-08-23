using System.Linq.Expressions;

namespace Restaurant.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        IEnumerable<T> GetAll();
        T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null);
    }
}
