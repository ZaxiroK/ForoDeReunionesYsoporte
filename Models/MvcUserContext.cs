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
        public DbSet<ForoDeReunionesYsoporte.Models.Client> Client { get; set; }
        //public DbSet<ForoDeReunionesYsoporte.Models.Client> Contact { get; set; }
        //public DbSet<ForoDeReunionesYsoporte.Models.Client> Meeting { get; set; }
        //public DbSet<ForoDeReunionesYsoporte.Models.Client> SupportTicket { get; set; }
        

    }
}