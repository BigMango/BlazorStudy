using AntDesign.ProLayout;
using Microsoft.Extensions.Logging;

namespace BlazorStudy
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            //注入AntDesign
            builder.Services.AddAntDesign();
            //基本配置
            builder.Services.Configure<ProSettings>(settings =>
            {
                settings.NavTheme = "light";
                settings.Layout = "side";
                settings.ContentWidth = "Fluid";
                settings.FixedHeader = false;
                settings.FixSiderbar = true;
                settings.Title = "DotNet宝藏库";
                settings.PrimaryColor = "daybreak";
                settings.ColorWeak = false;
                settings.SplitMenus = false;
                settings.HeaderRender = true;
                settings.FooterRender = false;
                settings.MenuRender = true;
                settings.MenuHeaderRender = true;
                settings.HeaderHeight = 48;

            });

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
