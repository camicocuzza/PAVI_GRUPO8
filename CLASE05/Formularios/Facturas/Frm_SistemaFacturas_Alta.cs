using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Alta : CLASE05.Formularios.Facturas.Frm_BaseFactura
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public Frm_SistemaFacturas_Alta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txt_cuit_cliente.Text.Length < 13)
            {
                MessageBox.Show("Falta seleccionar cliente para la facturación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmb_tipo_factura.SelectedIndex == -1)
            {
                MessageBox.Show("No se seleccionado tipo de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (grid_articulos.Rows.Count == 0 && grid_ensamblados.Rows.Count == 0)
            {
                MessageBox.Show("No se ha incluido ningún producto en la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ne_facturas.GenerarFactura(cmb_tipo_factura.SelectedIndex, txt_fechaActual.Text, txt_total_venta.Text, txt_cuit_cliente.Text,
                txt_legajo_empleado.Text, grid_articulos, grid_ensamblados);
            int num_factura, int id_tipo_factura, DateTime fecha, float monto_total,
            string cuit_cliente, int legajo_empleado, Grid01 Grid_Detalle_Articulo, 
            Grid01 Grid_Detalle_Ensamblado, Grid01 Grid_Stock
        }
    }
    
}
