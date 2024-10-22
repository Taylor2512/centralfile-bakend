using CentalFile.managment.api.DtaAcces;
using CentalFile.managment.api.DtaAcces.Extensions;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.ContactLayer.Repository.Command.Interfaces;

namespace CentalFile.managment.api.feature.ContactLayer.Repository.Command
{
    public class CommandContactRepository(ApplicationDbContext context) : RepositoryWrite<Contact>(context), ICommandContactRepository
    {
    }
}
