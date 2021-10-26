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
        private void Frm_SistemaFacturas_Alta_Load(object sender, EventArgs e)
        {
            Inicio();
            btnMostrarFactura.Enabled = false;
            btnGuardar.Enabled = true;

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
            
            txt_num_factura.Text = num_factura;
            btnMostrarFactura.Enabled = true;
            btnGuardar.Enabled = false;
            txt_legajo_empleado.Enabled = false;
            cmb_tipo_factura.Enabled = false;
            btn_agregar_articulo.Enabled = false;
            btn_agregar_ensamblado.Enabled = false;
            btn_quitar_articulo.Enabled = false;
            btn_quitar_ensamblado.Enabled = false;
        }
        private void btnMostrarFactura_Click(object sender, EventArgs e)
        {
            IList<string> parametros = new List<string>
            {
                txt_fechaActual.Text,
                txt_cuit_cliente.Text,
                txt_razon_social._Text,
                ne_clientes.ObtenerProvincia_Pais(txt_cuit_cliente.Text).Rows[0][0].ToString(),
                ne_clientes.ObtenerProvincia_Pais(txt_cuit_cliente.Text).Rows[0][1].ToString(),
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

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            this.Inicio();
            limpiarformulario();
            btnMostrarFactura.Enabled = false;
            btnGuardar.Enabled = true;
            txt_legajo_empleado.Enabled = true;
            cmb_tipo_factura.Enabled = true;
            btn_agregar_articulo.Enabled = true;
            btn_agregar_ensamblado.Enabled = true;
            btn_quitar_articulo.Enabled = true;
            btn_quitar_ensamblado.Enabled = true;

        }
    }

}
