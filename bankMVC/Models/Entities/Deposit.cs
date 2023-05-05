namespace bankMVC.Models.Entities
{
    public class Deposit : BaseEntity
    {
        public string ReferenceNumber { get; set; }
        public double Amount { get; set; }
        public string AccountId { get; set; }
    }
}
