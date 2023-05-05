using bankMVC.Models.Entities;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Interfaces
{
    public interface ICustomerRepository:IBaseRepository<Customer>
    {
        Customer Get(string id);
        Customer Get(Expression <Func<Customer, bool>> expresion);
        ICollection<Customer> GetAll();

    }
}
