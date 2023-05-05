using bankMVC.Data;
using bankMVC.Models.Entities;
using bankMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Implementations
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
            
        }
        public Account Get(string id)
        {
            var account = _bankContext.Accounts
                .Include(a => a.Deposits)
                .SingleOrDefault(a => a.Id == id);
            return account;
        }

        public Account Get(Expression<Func<Account, bool>> expression)
        {
            var account = _bankContext.Accounts
                .Include(a => a.Deposits)
                .SingleOrDefault(expression);
            return account;
        }

        public ICollection<Account> GetAll()
        {
            return _bankContext.Accounts
                .Include(a => a.Deposits)
                .ToList();
        }
    }
}
