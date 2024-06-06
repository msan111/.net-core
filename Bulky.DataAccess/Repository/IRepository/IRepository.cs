using System.Linq.Expressions;

namespace Bulky.DataAccess.Repository.IRepository;

public interface IRepository<T> where T : class
{
    // T -> Category
    //retrieve all categories
    IEnumerable<T> GetAll();
    //retrieve one category
    //FirstOrDefault(u=>u.Id == id);
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    //void Update(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entity);
}