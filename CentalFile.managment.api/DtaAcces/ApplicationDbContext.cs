using CentalFile.managment.api.DtaAcces.Configurations;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CentalFile.managment.api.DtaAcces
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, UserId, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationRoleConfiguration()); // Agrega esta línea

            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.HasKey(u => u.Id);
                b.HasMany(u => u.Contacts).WithOne(c => c.User).HasForeignKey(c => c.UserId);
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                b.HasKey(r => r.Id);
            });
        }
    }
}
