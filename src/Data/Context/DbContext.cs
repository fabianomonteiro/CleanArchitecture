using Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
    }
}
