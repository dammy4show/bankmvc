using bankMVC.Models.Entities;

namespace bankMVC.Dto
{
    public class CustomerDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public ICollection<AccountDto> Accounts { get; set; } = new HashSet<AccountDto>();

    }
}
