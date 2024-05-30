using System.Threading.Tasks;

namespace Demo.AspireMvc.Data;

public interface IAspireMvcDbSchemaMigrator
{
    Task MigrateAsync();
}
