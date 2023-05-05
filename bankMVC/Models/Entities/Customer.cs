namespace bankMVC.Models.Entities
{
    public class Customer : BaseEntity
    {
        public string UserId { get; set; }
        public ICollection<Account> Accounts { get; set; } = new HashSet<Account>();
    }
}
