using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SquatPal.Data.Entities;

namespace SquatPal.Data.DatabaseContext;

public class ApplicationDbContext : IdentityDbContext<AdminUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<AdminUser> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ExercisePlan> Exercises { get; set; }
        public DbSet<MembershipTier> Memberships { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );
        }
}
