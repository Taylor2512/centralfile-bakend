using CentalFile.managment.api.DtaAcces;
using CentalFile.managment.api.DtaAcces.Extensions;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.ContactLayer.Repository.Query.Interfaz;

namespace CentalFile.managment.api.feature.ContactLayer.Repository.Query
{
    public class QueryContactRepository(ApplicationDbContext context) : RepositoryRead<Contact>(context), IQueryContactRepository
    {
    }
}
