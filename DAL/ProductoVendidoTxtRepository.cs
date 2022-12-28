﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class ProductoVendidoTxtRepository
    {
        private string ruta = @"ProductosVendidos.txt";
        public void Guardar(ProductoVendidoTxt productoTxt)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{productoTxt.Cantidad};{productoTxt.Referencia};{productoTxt.Nombre};{productoTxt.Detalle};{productoTxt.FechaDeRegistro};" +
                $"{productoTxt.FechaDeVencimiento};{productoTxt.Lote};{productoTxt.Laboratorio};{productoTxt.Estado};{productoTxt.Tipo};{productoTxt.Via};{productoTxt.PrecioDeNegocio};{productoTxt.PrecioDeVenta};{productoTxt.GananciaPorProducto}");
            escritor.Close();
            file.Close();
        }
        public List<ProductoVendidoTxt> Consultar()
        {
            List<ProductoVendidoTxt> productoTxts = new List<ProductoVendidoTxt>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                ProductoVendidoTxt productoTxt = new ProductoVendidoTxt()
                {
                    Cantidad = int.Parse(dato[0]),
                    Referencia = dato[1],
                    Nombre = dato[2],
                    Detalle = dato[3],
                    FechaDeRegistro = DateTime.Parse(dato[4]),
                    FechaDeVencimiento = DateTime.Parse(dato[5]),
                    Lote = dato[6],
                    Laboratorio = dato[7],
                    Estado = dato[8],
                    Tipo = dato[9],
                    Via = dato[10],
                    PrecioDeNegocio = int.Parse(dato[11]),
                    PrecioDeVenta = int.Parse(dato[12]),
                    GananciaPorProducto = int.Parse(dato[13]),
                };
                productoTxts.Add(productoTxt);
            }
            lector.Close();
            file.Close();
            return productoTxts;
        }
        public bool FiltroIdentificaicon(string referencia)
        {
            List<ProductoVendidoTxt> productoTxts = new List<ProductoVendidoTxt>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                if (dato[1].Equals(referencia))
                {
                    lector.Close();
                    file.Close();
                    return true;
                }
            }
            lector.Close();
            file.Close();
            return false;
        }
        private bool EsEncontrado(string referenciaRegistrada, string referenciaBuscada)
        {
            return referenciaRegistrada == referenciaBuscada;
        }
        public void Modificar(ProductoVendidoTxt productoTxt, string referencia)
        {
            List<ProductoVendidoTxt> productoTxts = new List<ProductoVendidoTxt>();
            productoTxts = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in productoTxts)
            {
                if (!EsEncontrado(item.Referencia, referencia))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(productoTxt);
                }
            }
        }
        public void EliminarTodo()
        {
            File.Delete(ruta);
        }
        public void Eliminar(string referencia)
        {
            List<ProductoVendidoTxt> productoTxts = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in productoTxts)
            {
                if (!item.Referencia.Equals(referencia))
                {
                    Guardar(item);
                }
            }
        }
    }
}