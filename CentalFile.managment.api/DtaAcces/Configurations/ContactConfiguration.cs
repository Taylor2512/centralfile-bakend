using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentalFile.managment.api.DtaAcces.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasConversion(id => id.Value, value => (ContactId)value)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(c => c.UserId)
                .HasConversion(id => id.Value, value => (UserId)value);

            builder.HasOne(c => c.User)
                .WithMany(u => u.Contacts)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.PhoneNumber)
                .HasMaxLength(15);

            builder.Property(c => c.MobileNumber)
                .HasMaxLength(15);

            builder.Property(c => c.PhotoUrl)
                .HasMaxLength(250);
        }
    }
}
