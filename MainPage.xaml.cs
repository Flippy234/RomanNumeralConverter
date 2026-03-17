namespace RomanConverter;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Title = "Roman Converter";
    }


    private void TxtRomanNumeral_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        throw new NotImplementedException();
    }


    private void btnClear_OnClicked(object sender, EventArgs e)
    {
        txtRomanNumeral.Text = string.Empty;
    }

    private void btnConvert_OnClicked(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}