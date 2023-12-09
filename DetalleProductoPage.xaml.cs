using Proyectoprogreso2.Models;
using Proyectoprogreso2.Service;
using System.Collections.ObjectModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyectoprogreso2;

public partial class DetalleProductoPage : ContentPage
{
    private ProductoColorTalla _producto;
    private readonly APIService _ApiService;
    public DetalleProductoPage(APIService apiservice)
    {
        InitializeComponent();
        _ApiService = apiservice;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as ProductoColorTalla;
        Nombre.Text = _producto.Producto.nombre;
        Cantidad.Text = _producto.stock.ToString();
        Descripcion.Text = _producto.Producto.descripcion;
        Color.Text = _producto.ColorProducto.nombre;
    }

    private async void OnClickSalir(object sender, EventArgs e)
    {

        await Navigation.PopAsync();

    }
}