using NavegacionMaui.Views;

namespace NavegacionMaui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        
        Routing.RegisterRoute("informacion", typeof(InformacionPage));
        Routing.RegisterRoute("contacto", typeof(ContactoPage));
    }
}