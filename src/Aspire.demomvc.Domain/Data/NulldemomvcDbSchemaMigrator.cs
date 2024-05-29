using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Aspire.demomvc.Data;

/* This is used if database provider does't define
 * IdemomvcDbSchemaMigrator implementation.
 */
public class NulldemomvcDbSchemaMigrator : IdemomvcDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
