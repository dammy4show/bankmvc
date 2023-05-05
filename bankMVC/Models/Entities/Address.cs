namespace bankMVC.Models.Entities
{
    public class Address : BaseEntity
    {
        public int Plot { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
