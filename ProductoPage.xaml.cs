using Proyectoprogreso2.Models;
using Proyectoprogreso2.Service;
using System.Collections.ObjectModel;

namespace Proyectoprogreso2;

public partial class ProductoPage : ContentPage
{

    private readonly APIService _ApiService;
    public ProductoPage(APIService apiservice)
    {
        InitializeComponent();
        _ApiService = apiservice;

    }

    private async void Btn_Buscar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DetalleProductoPage(_ApiService));
    }


   
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        List<ProductoColorTalla> listaProducto = await _ApiService.GetProductos();
        var products = new ObservableCollection<ProductoColorTalla>(listaProducto);
        ListaProducto.ItemsSource = products;
    }
    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
     
        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage(_ApiService)
        {
            BindingContext = producto,
        });
    }
}