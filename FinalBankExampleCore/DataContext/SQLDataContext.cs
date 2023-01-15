using FinalBankExampleCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalBankExampleCore.DataContext
{
    public class SQLDataContext : DbContext
    {
        public SQLDataContext(DbContextOptions<SQLDataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // seed data

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    FirstName = "maryam",
                    LastName = "akbari",
                    UserName = "mm",
                    Password = "mm",
                    CreateDate = DateTime.Now,
                    LastModifiesDate = DateTime.Now,
                },
                new User
                {
                    ID = 2,
                    FirstName = "zeynab",
                    LastName = "shabanpour",
                    UserName = "zz",
                    Password = "zz",
                    CreateDate = DateTime.Now,
                    LastModifiesDate = DateTime.Now,
                }
                );
        }
    }
}
