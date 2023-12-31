﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Proyectoprogreso2.Models;

namespace Proyectoprogreso2.Service
{
    public class APIService
    {
        public static string _baseUrl;
        public HttpClient _httpClient;

        public APIService()
        {

            _baseUrl = "https://apiproyecto20231127081349.azurewebsites.net/";
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }


        public async Task<bool> DeleteProducto(int IdProducto)
        {
            var response = await _httpClient.DeleteAsync($"/api/ProductoColorTalla/{IdProducto}");
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }

        public async Task<ProductoColorTalla> GetProducto(int IdProducto)
        {
            var response = await _httpClient.GetAsync($"/api/ProductoColorTalla/{IdProducto}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                ProductoColorTalla producto = JsonConvert.DeserializeObject<ProductoColorTalla>(json_response);
                return producto;
            }
            return new ProductoColorTalla();
        }

        public async Task<List<ProductoColorTalla>> GetProductos()
        {
            var response = await _httpClient.GetAsync("/api/ProductoColorTalla");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<ProductoColorTalla> productos = JsonConvert.DeserializeObject<List<ProductoColorTalla>>(json_response);
                return productos;
            }
            return new List<ProductoColorTalla>();

        }

        public async Task<Producto> PostProducto(Producto producto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/Producto/", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Producto producto2 = JsonConvert.DeserializeObject<Producto>(json_response);
                return producto2;
            }
            return new Producto();
        }

        public async Task<Producto> PutProducto(int IdProducto, Producto producto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"/api/Producto/{IdProducto}", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Producto producto2 = JsonConvert.DeserializeObject<Producto>(json_response);
                return producto2;
            }
            return new Producto();
        }
        public async Task<Usuario> GetUsuario(string Usu, string Contra)
        {
            var response = await _httpClient.GetAsync($"/api/Cliente/{Usu}/{Contra}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Usuario usu = JsonConvert.DeserializeObject<Usuario>(json_response);
                return usu;
            }
            return null;
        }

        public async Task<Cliente> PostCliente(Cliente cliente)
        {
            var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/Cliente/", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Cliente cliente1 = JsonConvert.DeserializeObject<Cliente>(json_response);
                return cliente1;
            }
            return new Cliente();
        }

    }
}
