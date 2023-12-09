﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoprogreso2.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "La Cedula es un campo obligatorio.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El Nombre es un campo obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es un campo obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La Dirección es un campo obligatorio.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El Número de Tarjeta es un campo obligatorio.")]
        public int NumeroTarjeta { get; set; }

        [Required(ErrorMessage = "Login es un campo obligatorio.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Contrasenia es un campo obligatorio.")]
        public string Contrasenia { get; set; }
    }

}
