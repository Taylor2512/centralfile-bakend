using CentalFile.managment.api.DtaAcces;
using CentalFile.managment.api.DtaAcces.Extensions;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.UserLayer.Repository.Query.Interfaz;

namespace CentalFile.managment.api.feature.UserLayer.Repository.Query
{
    public class QueryUserRepository : RepositoryRead<User>, IQueryUserRepository
    {
        public QueryUserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
