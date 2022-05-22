using LG.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LG.Data.Core
{
    public class CoreDbContext : BaseDbContext<CoreDbContext>, IDbContext
    {
        public CoreDbContext()
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(e =>
            {
                e.HasKey(p => p.Id);

                e.ToTable("Users");

                e.Property(p => p.UserName).HasMaxLength(255).IsRequired();
                e.Property(p => p.Email).HasMaxLength(255).IsRequired();
                e.Property(p => p.Password).HasMaxLength(255).IsRequired();
                e.Property(p => p.IsVerified).IsRequired();
            });
        }
    }
}
