using bankMVC.Data;
using bankMVC.Models.Entities;
using bankMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public User Get(string id)
        {
            var user = _bankContext.Users
                .Include(a => a.UserRoles)
                .ThenInclude(a => a.Role)
                .Where(a => a.IsDeleted == false)
                .SingleOrDefault(s => s.Id == id);
            return user;
        }

        public User Get(Expression<Func<User, bool>> expression)
        {
            var user = _bankContext.Users
                .Include(a => a.UserRoles)
                .ThenInclude(a => a.Role)
                .Where(a=> a.IsDeleted == false)
                .SingleOrDefault(expression);
            return user;
        }

        public ICollection<User> GetAll()
        {
            return _bankContext.Users.ToList();
        }
    }
}
