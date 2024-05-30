using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Demo.AspireMvc.Data;

/* This is used if database provider does't define
 * IAspireMvcDbSchemaMigrator implementation.
 */
public class NullAspireMvcDbSchemaMigrator : IAspireMvcDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
