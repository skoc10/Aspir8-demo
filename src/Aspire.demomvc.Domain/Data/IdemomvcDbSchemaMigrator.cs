using System.Threading.Tasks;

namespace Aspire.demomvc.Data;

public interface IdemomvcDbSchemaMigrator
{
    Task MigrateAsync();
}
