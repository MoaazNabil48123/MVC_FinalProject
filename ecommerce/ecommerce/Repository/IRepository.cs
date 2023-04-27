using System.Linq.Expressions;

namespace ecommerce.Repository;

public interface IRepository<T>
{
    void Add(T element);
    List<T> GetAll();
    List<T> GetAll(params Expression<Func<T, object>>[] includes);
    List<T> GetAllThenInclude<T1, T2>(Expression<Func<T, T1>> include, Expression<Func<T1, T2>> thenInclude);
    List<T> Get(params Expression<Func<T, bool>>[] filters);
    T GetById(int id);
    T GetById(int id, params Expression<Func<T, object>>[] includes);
    void Update(T element);
    void Delete(T element);
}
