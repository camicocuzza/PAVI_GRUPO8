using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Proveedores
{
    public partial class Frm_Proveedor_Consulta : CLASE05.Formularios.Proveedores.Frm_Proveedor
    {
        public Frm_Proveedor_Consulta()
        {
            InitializeComponent();
        }

        private void Frm_Proveedor_Consulta_Load(object sender, EventArgs e)
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
    }
}
