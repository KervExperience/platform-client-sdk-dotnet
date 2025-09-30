using Microsoft.Extensions.Configuration;
using PureCloudPlatform.Client.V2.Client;
using LoggerTester;
using Microsoft.Extensions.Logging; // for extension methods
using MSLogging = Microsoft.Extensions.Logging;

internal class Program
{
    private static async Task Main(string[] _)
    {
        Console.WriteLine("=== Log Test (GenesysApiManager) ===");

        var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

        // SDK logger
        var logger = new Logger(
            logToConsole: true,
            logFormat: LogFormat.Text,
            logLevel: PureCloudPlatform.Client.V2.Client.LogLevel.LTrace,
            logRequestBody: true,
            logResponseBody: true);

        // Bridge to Microsoft.Extensions.Logging
        using var msLoggerFactory = LoggerFactory.Create(b =>
        {
            b.AddSimpleConsole(o =>
            {
                o.SingleLine = true;
                o.TimestampFormat = "HH:mm:ss ";
                o.IncludeScopes = false;
            });
            b.SetMinimumLevel(MSLogging.LogLevel.Trace);
        });
        var externalLogger = msLoggerFactory.CreateLogger("GenesysSdk");
        logger.SetExternalLogger(externalLogger);

        var apiClient = new ApiClient();
        var cfg = new Configuration(apiClient: apiClient, useDefaultApiClient: false)
        {
            Logger = logger
        };

        // Base path & token
        var basePath = config["GENESYS_BASE_PATH"];
        if (!string.IsNullOrWhiteSpace(basePath))
            cfg.ApiClient.setBasePath(basePath);

        var accessToken = config["ACCESS_TOKEN"];
        if (!string.IsNullOrWhiteSpace(accessToken))
            cfg.AccessToken = accessToken;

        var apiManager = new GenesysApiManager(cfg);

        Console.WriteLine("Exercising API calls to generate log traffic...");
        await ExerciseLoggingThroughManager(cfg, apiManager);

        Console.WriteLine("Press ENTER after a couple seconds to exit.");
        Console.ReadLine();
    }

    private static async Task ExerciseLoggingThroughManager(Configuration cfg, GenesysApiManager manager)
    {
        try
        {
            var meSync = manager.GetCurrentUser();
            Console.WriteLine($"Sync user id: {meSync?.Id ?? "(null)"}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sync manager call threw (expected if unauthenticated): " + ex.Message);
        }

        try
        {
            var meAsync = await manager.GetCurrentUserAsync();
            Console.WriteLine($"Async user id: {meAsync?.Id ?? "(null)"}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Async manager call threw (expected if unauthenticated): " + ex.Message);
        }
    }
}
