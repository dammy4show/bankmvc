namespace bankMVC.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        int Save();
    }
}
