using bankMVC.Data;
using bankMVC.Models.Entities;
using bankMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Implementations
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }
        public Role Get(string id)
        {
            var role = _bankContext.Roles
                .Include(a => a.UserRoles)
                .ThenInclude(a => a.User)
                .SingleOrDefault(r => r.Id == id && r.IsDeleted == false);
            return role;
                
        }

        public Role Get(Expression<Func<Role, bool>> expression )
        {
            var role = _bankContext.Roles
                .Include(a => a.UserRoles)
                .ThenInclude(a => a.User)
                .Where(a => a.IsDeleted == false)
                .SingleOrDefault(expression);
            return role;
        }

        public ICollection<Role> GetRoles()
        {
            return _bankContext.Roles.ToList();
        }
    }
}
