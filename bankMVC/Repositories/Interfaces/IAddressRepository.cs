using bankMVC.Models.Entities;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Interfaces
{
    public interface IAddressRepository : IBaseRepository<Address>
    {
        Address Get(string id);
        Address Get(Expression<Func<Address, bool>> expression);
        ICollection<Address> GetAll();

    }
}
