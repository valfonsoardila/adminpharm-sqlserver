﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FormProductosVendidos : Form
    {
        ProductoService productoService;
        ProductoVendidoTxtService productoVendidoTxtService = new ProductoVendidoTxtService();
        ProductoVendidoTxt productoTxt = new ProductoVendidoTxt();
        string referenciaProducto;
        int cantidadARestar;
        int cantidadProducto;
        string nombreProducto;
        string detalleProducto;
        double precioProducto;
        public FormProductosVendidos()
        {
            InitializeComponent();
            cargarArchivo(productoVendidoTxtService);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cargarArchivo(ProductoVendidoTxtService productoVendidoTxtService)
        {
            ProductoVendidoTxtConsultaResponse productoVendidoTxtConsultaResponse = productoVendidoTxtService.Consultar();
            if (productoVendidoTxtConsultaResponse.ProductoTxts.Count > 0)
            {
                foreach (var item in productoVendidoTxtConsultaResponse.ProductoTxts)
                {
                    cantidadProducto = item.Cantidad;
                    referenciaProducto = item.Referencia;
                    nombreProducto = item.Nombre;
                    detalleProducto = item.Detalle;
                    precioProducto = item.Precio;
                    dataGridProductosVendidos.Rows.Add(cantidadProducto, referenciaProducto, nombreProducto, detalleProducto, precioProducto);
                }
            }
            else
            {
                if (productoVendidoTxtConsultaResponse.ProductoTxts.Count == 0)
                {
                    dataGridProductosVendidos.DataSource = null;
                    labelAdvertencia.Visible = true;
                }
            }
        }
        private void ConsultarHistorial()
        {
            ProductoVendidoTxtConsultaResponse productoTxtConsultaResponse = productoVendidoTxtService.Consultar();
            if (productoTxtConsultaResponse.Encontrado == true)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    string referencia = item.Referencia;
                    int cantidad = item.Cantidad;
                    string nombre = item.Nombre;
                    string detalle = item.Detalle;
                    double precio = item.Precio;
                    dataGridProductosVendidos.Rows.Add(referencia, cantidad, nombre, detalle, precio);
                }
            }
            else
            {
                string mensaje = productoTxtConsultaResponse.Mensaje;
                MessageBox.Show(mensaje.ToString());
            }
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de productos vendidos?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ProductoFacturaTxt productoTxt = new ProductoFacturaTxt();
                string mensaje = productoVendidoTxtService.EliminarHistorial();
                dataGridProductosVendidos.DataSource = null;
                ConsultarHistorial();
            }
        }
    }
}
