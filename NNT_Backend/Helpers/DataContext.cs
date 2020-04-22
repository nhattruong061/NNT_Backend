using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NNT_Backend.Entities;

namespace NNT_Backend.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("NNT_BackendDatabase"));
        }

        public DbSet<User> Users { get; set; }
    }
}