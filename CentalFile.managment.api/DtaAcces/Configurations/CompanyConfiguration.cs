﻿using CentalFile.managment.api.DtaAcces.Configurations.Seeder;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentalFile.managment.api.DtaAcces.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.Id);


            builder.Property(c => c.Id)
                .HasConversion(id => id.Value, value => (CompanyId)value)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Identificaction)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.IdentificationType)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(c => c.Users)
                .WithOne(u => u.Company)
                .HasForeignKey(u => u.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.SeederCompany();
        }
    }
}
