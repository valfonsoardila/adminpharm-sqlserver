﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
using System.Globalization;

namespace DAL
{
    public class ProductoVencidoTxtRepository
    {
        private string ruta = @"ProductosVencidos.txt";
        public void Guardar(ProductoVencidoTxt productoTxt)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{productoTxt.Cantidad};{productoTxt.Referencia};{productoTxt.Nombre};{productoTxt.Detalle};{productoTxt.FechaDeRegistro};" +
                $"{productoTxt.FechaDeVencimiento};{productoTxt.Lote};{productoTxt.Laboratorio};{productoTxt.Estado};{productoTxt.Tipo};{productoTxt.Via};{productoTxt.PrecioDeNegocio};{productoTxt.PrecioDeVenta};{productoTxt.GananciaPorProducto}");
            escritor.Close();
            file.Close();
        }
        public List<ProductoVencidoTxt> Consultar()
        {
            List<ProductoVencidoTxt> productoTxts = new List<ProductoVencidoTxt>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                ProductoVencidoTxt productoTxt = new ProductoVencidoTxt()
                {
                    Cantidad = int.Parse(dato[0]),
                    Referencia = dato[1],
                    Nombre = dato[2],
                    Detalle = dato[3],
                    FechaDeRegistro = ParseDate(dato[4]),
                    FechaDeVencimiento = ParseDate(dato[5]),
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
        private DateTime ParseDate(string dateStr)
        {
            string[] formats = {
                "dd/MM/yyyy HH:mm:ss",
                "MM/dd/yyyy HH:mm:ss",
                "dd/MM/yyyy H:mm:ss",
                "MM/dd/yyyy H:mm:ss",
                "dd/MM/yyyy HH:mm",
                "MM/dd/yyyy HH:mm",
                "dd/MM/yyyy H:mm",
                "MM/dd/yyyy H:mm",
                "dd/MM/yyyy hh:mm tt",
                "MM/dd/yyyy hh:mm tt",
                "dd/MM/yyyy",
                "MM/dd/yyyy",
                "yyyy-MM-dd",
                "yyyy-MM-dd HH:mm:ss",
                "yyyy-MM-dd H:mm:ss",
                "yyyy-MM-dd HH:mm",
                "yyyy-MM-dd H:mm",
                "yyyy/MM/dd",
                "yyyy/MM/dd HH:mm:ss",
                "yyyy/MM/dd H:mm:ss",
                "yyyy/MM/dd HH:mm",
                "yyyy/MM/dd H:mm"
            };
            DateTime date;
            if (DateTime.TryParseExact(dateStr, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                return date;
            }
            else
            {
                throw new FormatException($"Formato de fecha no reconocido: {dateStr}");
            }
        }

        public List<ProductoVencidoTxt> ConsultarPorReferencias(string referencia)
        {
            List<ProductoVencidoTxt> productoTxts = new List<ProductoVencidoTxt>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                if (dato[1].Equals(referencia))
                {
                    ProductoVencidoTxt productoTxt = new ProductoVencidoTxt()
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
            }
            lector.Close();
            file.Close();
            return productoTxts;
        }
        private bool EsEncontrado(string referenciaRegistrada, string referenciaBuscada)
        {
            return referenciaRegistrada == referenciaBuscada;
        }
        public void Modificar(ProductoVencidoTxt productoTxt, string referencia)
        {
            List<ProductoVencidoTxt> productoTxts = new List<ProductoVencidoTxt>();
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
            List<ProductoVencidoTxt> productoTxts = Consultar();
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
        public int Totalizar()
        {
            return Consultar().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return Consultar().Where(p => p.Estado.Equals(tipo)).Count();
        }
    }
}
