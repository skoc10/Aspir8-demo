using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Demo.AspireMvc.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AspireMvcDbContextFactory : IDesignTimeDbContextFactory<AspireMvcDbContext>
{
    public AspireMvcDbContext CreateDbContext(string[] args)
    {
        AspireMvcEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AspireMvcDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AspireMvcDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Demo.AspireMvc.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
