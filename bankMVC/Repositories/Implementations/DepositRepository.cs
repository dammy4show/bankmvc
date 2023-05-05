using bankMVC.Data;
using bankMVC.Models.Entities;
using bankMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Implementations
{
    public class DepositRepository : BaseRepository<Deposit>, IDepositRepository
    {
        public DepositRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }
        public Deposit Get(string id)
        {
            var deposit = _bankContext.Deposits.SingleOrDefault(d => d.Id == id);
            return deposit;
        }

        public Deposit Get(Expression<Func<Deposit, bool>> expression)
        {
            var deposit = _bankContext.Deposits.SingleOrDefault(expression);
            return deposit;
        }

        public ICollection<Deposit> GetAll()
        {
            return _bankContext.Deposits.ToList();
        }
    }
}
