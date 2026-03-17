using CoreText;
using Microsoft.Maui.Controls.Platform.Compatibility;

namespace RomanConverter;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}