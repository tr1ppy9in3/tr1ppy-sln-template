namespace Template.Host;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplicationBuilderHelper.Create(args);
        var application =  CreateApplication(builder);
        await application.RunAsync();
    }
 
    private static WebApplication CreateApplication(WebApplicationBuilder builder)
    {
        var application = builder.Build();
        return application;
    }
}

file static class WebApplicationBuilderHelper
{
    public static WebApplicationBuilder Create(string[] args) =>
        WebApplication.CreateBuilder(args)
            .ConfigureConfiguration()
            .ConfigureLogging()
            .ConfigureServices()
            .ConfigureWebFeatures();
    
    private static WebApplicationBuilder ConfigureLogging(this WebApplicationBuilder builder)
    {
        return builder;
    }
    
    private static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        return builder;
    }
    
    private static WebApplicationBuilder ConfigureConfiguration(this WebApplicationBuilder builder)
    {
        return builder;
    } 
    
    private static WebApplicationBuilder ConfigureWebFeatures(this WebApplicationBuilder builder)
    {
        return builder;
    }
    
}