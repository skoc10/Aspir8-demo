using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Demo.AspireMvc.Data;
using Volo.Abp.DependencyInjection;

namespace Demo.AspireMvc.EntityFrameworkCore;

public class EntityFrameworkCoreAspireMvcDbSchemaMigrator
    : IAspireMvcDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAspireMvcDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AspireMvcDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AspireMvcDbContext>()
            .Database
            .MigrateAsync();
    }
}
