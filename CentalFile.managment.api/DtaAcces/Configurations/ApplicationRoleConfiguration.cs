using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentalFile.managment.api.DtaAcces.Configurations
{
    public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.Property(r => r.Id)
                .HasConversion(id => id.Value, value => new UserId(value))
                .ValueGeneratedOnAdd()
                .IsRequired();
        }
    }
}
