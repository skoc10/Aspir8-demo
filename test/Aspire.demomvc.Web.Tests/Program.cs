using Microsoft.AspNetCore.Builder;
using Aspire.demomvc;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<demomvcWebTestModule>();

public partial class Program
{
}
