using Dotnet_API_15.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_15.Data
{
    public class PlayerDbContext:DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options):base(options)
        {
        }
        public DbSet<Player>Players =>Set<Player>();
    }
}
