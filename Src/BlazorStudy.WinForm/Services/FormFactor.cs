using BlazorStudy.Shared.Services;

namespace BlazorStudy.WinForm.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "WinForm";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}