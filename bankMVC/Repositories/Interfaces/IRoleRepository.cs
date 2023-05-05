using bankMVC.Models.Entities;
using System.Linq.Expressions;

namespace bankMVC.Repositories.Interfaces
{
    public interface IRoleRepository: IBaseRepository<Role>
    {
        Role Get(string id);
        Role Get(Expression<Func<Role, bool>>expression);
        ICollection<Role> GetRoles();
    }
}
