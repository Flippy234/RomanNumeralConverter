using CoreText;
using RomanConverter.Custom;

namespace RomanConverter;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        RomanConverter = new RomanConverter();
        MainPage = new AppShell();
    }
}