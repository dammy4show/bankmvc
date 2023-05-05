using bankMVC.Models.Enums;

namespace bankMVC.Models.Entities
{
    public class Account : BaseEntity
    {
        public string CustumerId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; } 
        public double AccountBalance { get; set; }
        public ICollection<Deposit> Deposits { get; set;} = new HashSet<Deposit>();

    }
}
