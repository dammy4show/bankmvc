using bankMVC.Data;
using bankMVC.Models.Entities;
using bankMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Implementations
{
    
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }
        public Customer Get(string id)
        {
            var customer = _bankContext.Customers
                .Include(a => a.Accounts)
                .SingleOrDefault(x => x.Id == id);
            return customer;
        }

        public Customer Get(Expression<Func<Customer, bool>> expression)
        {
            var customer =  _bankContext.Customers
                .Include(a => a.Accounts)
                .SingleOrDefault(expression);
            return customer;
        }

       

        public ICollection<Customer> GetAll()
        {
            return _bankContext.Customers
                .Include(a=> a.Accounts)
                .ToList();
        }

        
    }
}
