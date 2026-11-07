namespace NavegacionMaui.Views;

public partial class InformacionPage : ContentPage
{
    public InformacionPage()
    {
        InitializeComponent();
    }

    private async void OnRegresarClicked(object sender, EventArgs e)
    {
        
        await Shell.Current.GoToAsync("..");
    }
}