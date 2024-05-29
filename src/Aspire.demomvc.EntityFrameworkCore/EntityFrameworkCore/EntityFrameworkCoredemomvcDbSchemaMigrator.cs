using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Aspire.demomvc.Data;
using Volo.Abp.DependencyInjection;

namespace Aspire.demomvc.EntityFrameworkCore;

public class EntityFrameworkCoredemomvcDbSchemaMigrator
    : IdemomvcDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoredemomvcDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the demomvcDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<demomvcDbContext>()
            .Database
            .MigrateAsync();
    }
}
