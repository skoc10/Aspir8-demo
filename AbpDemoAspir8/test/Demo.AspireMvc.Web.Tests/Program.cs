using Microsoft.AspNetCore.Builder;
using Demo.AspireMvc;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<AspireMvcWebTestModule>();

public partial class Program
{
}
