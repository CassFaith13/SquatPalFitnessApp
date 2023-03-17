using Microsoft.EntityFrameworkCore;
using SquatPal.Data.Entities;

namespace SquatPal.Data.DatabaseContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<AdminUser> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ExercisePlan> Exercises { get; set; }
        public DbSet<MembershipTier> Memberships { get; set; }
}
