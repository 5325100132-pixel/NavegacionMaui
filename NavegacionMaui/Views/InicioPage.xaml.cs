namespace NavegacionMaui.Views;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        
        InitializeComponent();
    }

    
    private async void OnVerInformacionClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("informacion");
    }
    private async void OnVerContactoClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("contacto");
    }
}
