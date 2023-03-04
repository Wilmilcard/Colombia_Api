using Colombia_Api.Interfaces;
using Colombia_Api.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Colombia_Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomerServicesColombia(this IServiceCollection services)
        {
            services.AddTransient<IDepartamentoServices, DepartamentoServices>();
            services.AddTransient<IMunicipioServices, MunicipioServices>();

            return services;
        }
    }
}
