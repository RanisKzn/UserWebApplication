using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core;

namespace UserWebApplication.Db
{
    public static class UserWebDbServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:UserWebApplication"];

            services.AddDbContext<UserWebApplicationDbContext>(options =>
            {
                options.UseLazyLoadingProxies();
                options.UseNpgsql(connectionString, o => {
                    o.CommandTimeout(600);
                    o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                })
                .UseSnakeCaseNamingConvention();
            });

            services.AddScoped<IUserWebApplicationDbContext>(provider => provider.GetRequiredService<UserWebApplicationDbContext>());
            return services;
        }
    }
}