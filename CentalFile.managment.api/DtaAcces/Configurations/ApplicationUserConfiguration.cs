using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentalFile.managment.api.DtaAcces.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.Id)
                .HasConversion(id => id.Value, value => (UserId)value)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(u => u.CompanyId)
                .HasConversion(id => id.Value, value => (CompanyId?)value);

            builder.HasOne(u => u.Company)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.CompanyId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(u => u.FirstName);

            builder.Property(u => u.LastName);
        }
    }
}
