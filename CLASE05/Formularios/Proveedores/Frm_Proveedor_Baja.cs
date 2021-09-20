using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;


namespace CLASE05.Formularios.Proveedores
{
    public partial class Frm_Proveedor_Baja : CLASE05.Formularios.Proveedores.Frm_Proveedor
    {
        public Frm_Proveedor_Baja()
        {
            InitializeComponent();
        }

        private void Frm_Proveedor_Baja_Load(object sender, EventArgs e)
        {
            NE_Proveedores proveedor = new NE_Proveedores();
            CargarFormulario(proveedor.RecuperarProveedor(cuit_proveedor));
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_cuit_p._Text = tabla.Rows[0]["cuit_proveedor"].ToString(); 
            txt_razon_social._Text = tabla.Rows[0]["razon_social"].ToString();
            txt_fecha_inicio._Text = tabla.Rows[0]["fecha_inicio_operacion"].ToString();
            cmb_empleado.SelectedValue = int.Parse(tabla.Rows[0]["legajo_empleado"].ToString());
            txt_direccion._Text = tabla.Rows[0]["direccion"].ToString();
            cmb_estado_provincia.SelectedValue = int.Parse(tabla.Rows[0]["id_estado_provincia"].ToString());
            txt_ciudad._Text = tabla.Rows[0]["ciudad"].ToString();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Proveedores proveedor = new NE_Proveedores();

                proveedor.cuit_proveedor = txt_cuit_p._Text;

                if (MessageBox.Show("¿Está seguro de que desea eliminar el proveedor " + txt_razon_social._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    proveedor.Borrar();
                    MessageBox.Show("Se eliminó correctamente el proveedor " + txt_razon_social._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            }
        }
    }
}
