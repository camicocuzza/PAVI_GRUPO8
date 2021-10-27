using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Baja : CLASE05.Formularios.Facturas.Frm_BaseFactura
    {
        public Frm_SistemaFacturas_Baja()
        {
            InitializeComponent();
        }
        private void Frm_SistemaFacturas_Baja_Load(object sender, EventArgs e)
        {
            this.RecuperarDatosFormulario();
        }

        private void btn_eliminar_venta_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Está seguro de que desea eliminar la venta nro " + num_factura + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ne_facturas.BorrarFactura(num_factura, fecha, grid_articulos, grid_ensamblados);                
                this.Dispose();
            }
            else
                MessageBox.Show("Eliminación cancelada");
        }

        private void btnMostrarFactura_Click(object sender, EventArgs e)
        {
            IList<string> parametros = new List<string>
            {
                txt_fechaActual.Text,
                cmb_cliente.SelectedValue.ToString(),
                cmb_cliente.Text,
                ne_clientes.ObtenerProvincia_Pais(cuit_cliente).Rows[0][0].ToString(),
                ne_clientes.ObtenerProvincia_Pais(cuit_cliente).Rows[0][1].ToString(),
                num_factura,
                ne_clientes.RecuperarCliente(txt_cuit_cliente.Text).Rows[0][5].ToString(),
                txt_total_venta.Text.Substring(1),
                ne_clientes.RecuperarCliente(txt_cuit_cliente.Text).Rows[0][7].ToString()
            };

            Frm_VentaFactura ventaFactura = new Frm_VentaFactura(num_factura, parametros)
            {
                Text = "Visualización de Factura"
            };
            ventaFactura.Show();
        }
    }
}
