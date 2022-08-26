using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Project4.EntityFramework.Core
{
    [AppDbContext("Project4", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}