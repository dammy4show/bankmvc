using bankMVC.Models.Entities;
using bankMVC.Models.Enums;

namespace bankMVC.Dto
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string AddressId { get; set; }
        public ICollection<UserRoleDto> UserRoles { get; set; } = new HashSet<UserRoleDto>();
    }
}
