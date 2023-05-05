namespace bankMVC.Dto
{
    public class AddressDto
    {
        public string Id { get; set; }
        public int Plot { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
