using RomanConverter.Custom;

namespace RomanConverter;

public partial class MainPage : ContentPage
{
    private Converter Converter = new Converter();
    
    public MainPage()
    {
        InitializeComponent();
        Title = "Roman Converter";
    }


    private void btnClear_OnClicked(object sender, EventArgs e)
    {
        txtInput.Text = string.Empty;
        lblResult.Text = string.Empty;
    }

    private void btnConvert_OnClicked(object sender, EventArgs e)
    {
        string input = txtInput.Text;

        if (string.IsNullOrEmpty(input))
        {
            lblResult.Text = "Enter a numerical value";
            return;
        }

        if (int.TryParse(input, out int number))
        {
            if (number <= 0)
            {
                lblResult.Text = "Enter a positive numeral value";
                return;
            }
            lblResult.Text = Converter.NumberToRoman(number);
        }
        else
        {
            int result = Converter.RomanToNumber(input);
            lblResult.Text = result.ToString();
        }
    }
}