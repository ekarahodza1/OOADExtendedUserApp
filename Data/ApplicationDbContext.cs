using ExtendedUserApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExtendedUserApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Ticket { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.Property(u => u.FirstName);
                b.Property(u => u.LastName);
                b.Property(u => u.ProfilePicture);
                b.Property(u => u.Age);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
