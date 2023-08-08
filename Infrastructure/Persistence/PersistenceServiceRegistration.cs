using ShopAPI.Application.Contracts.Persistence;
using ShopAPI.Infrastructure.Persistence.DatabaseContext;
using ShopAPI.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Infrastructure.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ShopContext>(options2 =>
        {
            options2.UseSqlServer(configuration.GetConnectionString("ShopDatabaseConnectionString"), b => b.MigrationsAssembly("ShopAPI"));
        });


        services.AddScoped(typeof(IShopRepositoryGeneric<>), typeof(GenericShopRepository<>));
        services.AddScoped<IItemRepository, ItemsRepository>();

        return services;
    }
}
