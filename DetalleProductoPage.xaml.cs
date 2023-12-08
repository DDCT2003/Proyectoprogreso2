using Proyectoprogreso2.Models;
using Proyectoprogreso2.Service;
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
      //  Nombre.Text = _producto.Nombre;
      //  Cantidad.Text = _producto.Cantidad.ToString();
      //  Descripcion.Text = _producto.Descripcion;
    }
}