using bankMVC.Models.Entities;
using bankMVC.Models.Enums;

namespace bankMVC.Dto
{
    public class AccountDto
    {
        public string Id { get; set; }
        public string CustumerId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public double AccountBalance { get; set; }
        public ICollection<DepositDto> Deposits { get; set; } = new HashSet<DepositDto>();

    }
}
