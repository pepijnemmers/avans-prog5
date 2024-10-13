using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NinjaApp.Database;

public class ContextFactory: IDesignTimeDbContextFactory<NinjaDbContext>
{
    public ContextFactory()
    {
    }

    private IConfiguration Configuration => new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

    public NinjaDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<NinjaDbContext>();
        builder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        
        return new NinjaDbContext(builder.Options);
    }
}