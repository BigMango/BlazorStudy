using Microsoft.AspNetCore.Components.WebView.WindowsForms;

namespace BlazorStudy.WinForm;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();

        var blazor = new BlazorWebView()
        {
            Dock = DockStyle.Fill,
            HostPage = "wwwroot/index.html",
            Services = Startup.Services!
        };

        // blazor.RootComponents.Add<Main>("#app");
        blazor.RootComponents.Add<BlazorStudy.Shared.Routes>("#app");
        Controls.Add(blazor);
    }
}
