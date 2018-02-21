using Microsoft.EntityFrameworkCore;

namespace ForoDeReunionesYsoporte.Models
{
    public class MvcUserContext : DbContext
    {
        public MvcUserContext (DbContextOptions<MvcUserContext> options)
            : base(options)
        {
        }

        public DbSet<ForoDeReunionesYsoporte.Models.User> User { get; set; }
    }
}