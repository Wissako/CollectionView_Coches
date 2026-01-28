using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo.Pages;

public partial class DetalleCochePage : ContentPage
{
   
    public DetalleCochePage(Coches cocheSeleccionado)
    {
        InitializeComponent();
     
        BindingContext = cocheSeleccionado;
    }

    private async void OnVolverClicked(object sender, EventArgs e)
    {
      
        await Navigation.PopAsync();
    }
}