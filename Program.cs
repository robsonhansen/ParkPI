using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Device;
using GUI;

class Program
{
    static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                config.SetBasePath(AppContext.BaseDirectory);
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                IConfiguration configuration = context.Configuration;

                // Injetando a configuração geral
                services.AddSingleton(configuration);

                // Configurações fortemente tipadas (opcional, mas elegante)
                services.Configure<DatabaseSettings>(configuration.GetSection("Database"));
                services.Configure<DeviceSettings>(configuration.GetSection("Device"));
                services.Configure<AppSettings>(configuration.GetSection("Application"));

                // Camadas da aplicação
                services.AddApplicationLayer();
                services.AddInfrastructureLayer(configuration);
                services.AddBackgroundServices();

                // GUI
                services.AddSingleton<GuiApp>();
            })
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
            })
            .Build();

        var gui = host.Services.GetRequiredService<GuiApp>();
        gui.Run();
    }
}
