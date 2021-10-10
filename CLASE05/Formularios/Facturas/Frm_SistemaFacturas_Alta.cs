using CLASE05.Clases;
using CLASE05.Negocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Alta : CLASE05.Formularios.Facturas.Frm_BaseFactura
    {
        NE_Empleados ne_empleados = new NE_Empleados();
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
            if (txt_legajo_empleado.Text == "")
            {
                MessageBox.Show("Falta ingresar legajo de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ne_empleados.ValidarExistencia(txt_legajo_empleado.Text) == false)
            {
                MessageBox.Show("El legajo '" + txt_legajo_empleado.Text + "' no corresponde a un empleado activo", "Importante");
                txt_legajo_empleado.Focus();
                return;
            }
            if (grid_articulos.Rows.Count == 1 && grid_ensamblados.Rows.Count == 1)
            {
                MessageBox.Show("No se ha incluido ningún producto en la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ne_facturas.InsertarFactura(cmb_tipo_factura.SelectedIndex + 1, txt_fechaActual.Text, txt_total_venta.Text.Replace("$", "").Replace(",", "."), txt_cuit_cliente.Text,
                txt_legajo_empleado.Text, grid_articulos, grid_ensamblados);

            this.num_factura = ne_facturas.num_factura;

            this.Inicio();
            cuit_cliente = txt_cuit_cliente.Text;
            this.RecuperarDatosCliente(cuit_cliente);
            txt_num_factura.Text = num_factura;

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
