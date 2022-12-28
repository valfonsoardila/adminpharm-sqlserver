﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoFacturaTxt
    {
        public ProductoFacturaTxt(string referencia, int cantidad, string nombre, string detalle, double precio)
        {
            Referencia = referencia;
            Cantidad = cantidad;
            Nombre = nombre;
            Detalle = detalle;
            Precio = precio;
        }
        public ProductoFacturaTxt()
        {

        }
        public string Referencia { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public override string ToString()
        {
            return $"\n" +
                   $"- Referencia: {Referencia}\n" +
                   $"- Cantidad: {Cantidad}\n" +
                   $"- Nombre: {Nombre}\n" +
                   $"- Detalle: {Detalle}\n" +
                   $"- Precio: {Precio}\n";
        }
    }
}