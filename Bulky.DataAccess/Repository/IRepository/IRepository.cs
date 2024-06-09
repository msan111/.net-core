using System.Linq.Expressions;

namespace Bulky.DataAccess.Repository.IRepository;

public interface IRepository<T> where T : class
{
    // T -> Category
    //retrieve all categories
    IEnumerable<T> GetAll(string? includeProperties = null);
    //retrieve one category
    //FirstOrDefault(u=>u.Id == id);
    T Get(Expression<Func<T, bool>> filter,string? includeProperties = null);
    void Add(T entity);
    //void Update(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entity);
}