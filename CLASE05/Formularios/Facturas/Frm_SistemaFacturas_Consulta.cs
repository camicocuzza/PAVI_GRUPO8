using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Consulta : CLASE05.Formularios.Facturas.Frm_BaseFactura
    {
        public Frm_SistemaFacturas_Consulta()
        {
            InitializeComponent();
        }

        private void Frm_SistemaFacturas_Consulta_Load(object sender, EventArgs e)
        {
            this.RecuperarDatosFormulario();
        }

        private void btnMostrarFactura_Click(object sender, EventArgs e)
        {
            IList<string> parametros = new List<string>
            {
                txt_fechaActual.Text,
                txt_cuit_cliente.Text,
                txt_razon_social._Text,
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
            ventaFactura.ShowDialog();
        }
    }
}
