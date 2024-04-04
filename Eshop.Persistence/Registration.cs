using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Eshop.Application.Interfaces.Repositories;
using Eshop.Application.Interfaces.AutoMapper;
using Eshop.Application.Interfaces.UnitOfWorks;
using Eshop.Persistence.Context;
using Eshop.Persistence.Repositories;
using Eshop.Persistence.UnitOfWorks;

namespace Eshop.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddSingleton<IMapper, Mapping.Mapper>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
