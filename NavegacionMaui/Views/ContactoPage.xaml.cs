namespace NavegacionMaui.Views;

public partial class ContactoPage : ContentPage
{
    public ContactoPage()
    {
        InitializeComponent();
    }

    private async void OnRegresarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}