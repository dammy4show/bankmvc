using bankMVC.Data;
using bankMVC.Models.Entities;
using bankMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Implementations
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(BankContext bankContext) 
        { 
            _bankContext = bankContext;
        }
        public Address Get(string id)
        {
            var address = _bankContext.Addresses.SingleOrDefault(a => a.Id == id);
            return address;
        }

        public Address Get(Expression<Func<Address, bool>> expression)
        {
            var address = _bankContext.Addresses.SingleOrDefault(expression);
            return address;
        }

        public ICollection<Address> GetAll()
        {
            return _bankContext.Addresses.ToList();
        }
    }
}
