using BlazorStudy.Shared.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorStudy.WinForm.Services;

namespace BlazorStudy.WinForm;

public static class Startup
{
    public static IServiceProvider? Services { get; private set; }

    public static void Init()
    {
        var host = Host.CreateDefaultBuilder()
                       .ConfigureServices(WireupServices)
                       .Build();
        Services = host.Services;
    }
    private static void WireupServices(IServiceCollection services)
    {
        services.AddWindowsFormsBlazorWebView();
		services.AddAntDesign();
        services.AddSingleton<IFormFactor,FormFactor>();
        services.AddSingleton<IWeatherForecastService,WeatherForecastService>();

#if DEBUG
        services.AddBlazorWebViewDeveloperTools();
#endif
    }
}
