using bankMVC.Data;
using bankMVC.Models.Entities;
using bankMVC.Repositories.Interfaces;

namespace bankMVC.Repositories.Implementations
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public BankContext _bankContext;

        public T Create(T entity)
        {
            _bankContext.Set<T>().Add(entity);
            return entity;
        }

        public int Save()
        {
            return _bankContext.SaveChanges();
        }

        public T Update(T entity)
        {
            _bankContext.Update(entity);
            return entity;
        }
    }
}
