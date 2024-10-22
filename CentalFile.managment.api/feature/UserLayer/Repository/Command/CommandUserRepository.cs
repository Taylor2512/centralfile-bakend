using CentalFile.managment.api.DtaAcces;
using CentalFile.managment.api.DtaAcces.Extensions;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.UserLayer.Repository.Command.Interfaces;

namespace CentalFile.managment.api.feature.UserLayer.Repository.Command
{
    public class CommandUserRepository : RepositoryWrite<ApplicationUser>, ICommandUserRepository
    {
        public CommandUserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
