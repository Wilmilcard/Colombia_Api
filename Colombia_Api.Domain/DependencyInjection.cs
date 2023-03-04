using Colombia_Api.Domain.DB;
using Colombia_Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Colombia_Api.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomizedDataStore(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ColombiaApiDbContext>(
                options => options.UseMySql(Configuration.GetConnectionString("conn_mysql"),
                ServerVersion.AutoDetect(Configuration.GetConnectionString("conn_mysql")),
                null));
            return services;
        }

        public static IServiceCollection AddCustomizedRepository(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
