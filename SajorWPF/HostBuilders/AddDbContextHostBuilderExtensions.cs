using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SajorIPT101Solution.SajorWPF.Data;
using SajorIPT101Solution.SajorWPF.ViewModels;

namespace SajorIPT101Solution.SajorWPF.HostBuilders
{
    public static class AddDbContextHostBuilderExtensions
    {
        public static IHostBuilder AddDbContext(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
            {
                string connectionString = context.Configuration.GetConnectionString("connect");

                // Recommended: register DbContext as scoped
                services.AddDbContext<EmployeeDbContext>(options =>
                    options.UseSqlServer(connectionString));

                // Register ViewModel and MainWindow in DI
                services.AddSingleton<MainViewModel>(); // if you prefer singleton VM
                services.AddSingleton<MainWindow>();
            });

            return hostBuilder;
        }
    }
}