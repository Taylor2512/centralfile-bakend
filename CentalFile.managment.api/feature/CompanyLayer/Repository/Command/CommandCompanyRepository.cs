using CentalFile.managment.api.DtaAcces;
using CentalFile.managment.api.DtaAcces.Extensions;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Command.Interfaces;

namespace CentalFile.managment.api.feature.CompanyLayer.Repository.Command
{
    public class CommandCompanyRepository(ApplicationDbContext context) : RepositoryWrite<Company>(context), ICommandCompanyRepository
    {
    }
}
