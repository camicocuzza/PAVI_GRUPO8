using CLASE05.Clases;
using CLASE05.Negocios;
using System;
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

            this.Inicio();   
        }
    }

}
