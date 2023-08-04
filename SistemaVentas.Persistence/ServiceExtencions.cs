using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.Persistence.DBcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Persistence
{
    public static class ServiceExtencions
    {
        public static void AddIOCPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SistemaVentasContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbVentasConnection"),
                p => p.MigrationsAssembly(typeof(SistemaVentasContext).Assembly.FullName)));
        }
    }
}
