using bankMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace bankMVC.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        { 
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}
