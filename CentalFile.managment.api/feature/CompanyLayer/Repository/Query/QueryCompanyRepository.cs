using CentalFile.managment.api.DtaAcces;
using CentalFile.managment.api.DtaAcces.Extensions;
using CentalFile.managment.api.DtaAcces.Models;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Query.Interfaz;

namespace CentalFile.managment.api.feature.CompanyLayer.Repository.Query
{
    public class QueryCompanyRepository(ApplicationDbContext context) : RepositoryRead<Company>(context), IQueryCompanyRepository
    {
    }
}
