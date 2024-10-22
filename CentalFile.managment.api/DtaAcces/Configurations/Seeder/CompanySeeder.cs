using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.DtaAcces.StronglyTypedIDs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentalFile.managment.api.DtaAcces.Configurations.Seeder
{
    public static class CompanySeeder
    {
        public static void SeederCompany(this EntityTypeBuilder<Company> modelBuilder)
        {
            modelBuilder.HasData(
                new Company
                {
                    Id = new CompanyId(),
                    Name = "centralfile",
                    Identificaction = "123456789",
                    IdentificationType = "NIT"
                },
                new Company
                {
                    Id = new CompanyId(),
                    Name = "Company 2",
                    Identificaction = "987654321",
                    IdentificationType = "NIT"
                }
            );
        }
    }
}
