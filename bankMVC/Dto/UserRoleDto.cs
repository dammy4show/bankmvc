using bankMVC.Models.Entities;

namespace bankMVC.Dto
{
    public class UserRoleDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}
