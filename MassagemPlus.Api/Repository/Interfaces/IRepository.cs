namespace MassagemPlus.Api.Repository.Interfaces;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> Post(T entity);
    Task<T> Put(T entity);
    Task<T> Delete(T entity);
}