using bankMVC.Models.Entities;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Interfaces
{
    public interface IAccountRepository: IBaseRepository<Account>
    {
        Account Get(string id);
        Account Get(Expression<Func<Account, bool>> expression);
        ICollection<Account> GetAll();

    }
}
