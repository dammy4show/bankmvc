using bankMVC.Models.Entities;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Interfaces
{
    public interface IDepositRepository: IBaseRepository<Deposit>
    {
        Deposit Get(string id);
        Deposit Get(Expression<Func<Deposit, bool>> expression);
        ICollection<Deposit> GetAll();
    }
}
