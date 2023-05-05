namespace bankMVC.Models.Entities
{
    public abstract class BaseEntity
    {
        public string Id = Guid.NewGuid().ToString();
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
