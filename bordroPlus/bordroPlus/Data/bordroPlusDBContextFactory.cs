using bP.Data.DBContext;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using bP.Core.Contract.Helpers;

namespace bordroPlus.Data
{
    public class bordroPlusDBContextFactory : IDesignTimeDbContextFactory<AppDBContext>
    {
        
        public AppDBContext CreateDbContext(string[] args)
        {
            string path = @"..\bordroPlus";
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath(path))
                .AddJsonFile("appsettings.json")
                .Build();

            //var builder = new DbContextOptionsBuilder<AppDBContext>();
            //var connectionString = configuration.GetConnectionString("ConnectionString");
            var builder = new DbContextOptionsBuilder<AppDBContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("bordroPlus"));

            //builder.UseSqlServer(connectionString);

            return new AppDBContext(builder.Options);
        }




    }
}
