using bankMVC.Models.Entities;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Interfaces
{
    public interface IUserRepository:IBaseRepository<User>
    {
        User Get(string id);
        User Get(Expression<Func<User, bool>> expression);
        ICollection<User> GetAll();
    }
}
