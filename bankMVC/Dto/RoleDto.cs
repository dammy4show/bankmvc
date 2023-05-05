using bankMVC.Models.Entities;

namespace bankMVC.Dto
{
    public class RoleDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<UserRoleDto> UserRoles { get; set; } = new HashSet<UserRoleDto>();

    }
}
