using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DbFirst.DAL
{
    public class DbContextInitializer
    {
        public static IConfigurationRoot configuration;

        public static DbContextOptionsBuilder<AppDbContext> optionsBuilder;

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);

            configuration = builder.Build();

            optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlCon"));
        }
      
    }
}
