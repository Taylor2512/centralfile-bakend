using CentalFile.managment.api.DtaAcces.Extensions;
using CentalFile.managment.api.DtaAcces.Extensions.Interfaces;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Command;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Query;
using CentalFile.managment.api.feature.CompanyLayer.Repository.Query.Interfaz;
using CentalFile.managment.api.feature.ContactLayer.Repository.Command;
using CentalFile.managment.api.feature.ContactLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.ContactLayer.Repository.Query;
using CentalFile.managment.api.feature.ContactLayer.Repository.Query.Interfaz;
using CentalFile.managment.api.feature.UserLayer.Repository.Command;
using CentalFile.managment.api.feature.UserLayer.Repository.Command.Interfaces;
using CentalFile.managment.api.feature.UserLayer.Repository.Query;
using CentalFile.managment.api.feature.UserLayer.Repository.Query.Interfaz;

using System.Reflection;

namespace CentalFile.managment.api.Configuration
{
    public static class ConfigurationServices
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICommandUserRepository, CommandUserRepository>();
            services.AddScoped<ICommandContactRepository, CommandContactRepository>();
            services.AddScoped<ICommandCompanyRepository, CommandCompanyRepository>();
            services.AddScoped<IQueryUserRepository, QueryUserRepository>();
            services.AddScoped<IQueryContactRepository, QueryContactRepository>();
            services.AddScoped<IQueryCompanyRepository, QueryCompanyRepository>();
            services.AddScoped(typeof(IRepositoryRed<>), typeof(RepositoryRead<>));
            services.AddScoped(typeof(IRepositoryWrite<>), typeof(RepositoryWrite<>));
        }

    }
}
