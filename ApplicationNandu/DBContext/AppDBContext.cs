using ApplicationNandu.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationNandu.DBContext
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
           : base(options)
        {
        }
        public DbSet<Registration> Registrations { get; set; }

    }
}
