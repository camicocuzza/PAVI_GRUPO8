using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.EquiposEspeciales
{
    public partial class Frm_EquiposEspeciales_Modificacion : CLASE05.Formularios.EquiposEspeciales.Frm_EquiposEspeciales
    {
        public Frm_EquiposEspeciales_Modificacion()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_EquiposEspeciales equipo = new NE_EquiposEspeciales();

            equipo.cod_prod_ensamblado = cmb_equipos.SelectedValue.ToString();
            equipo.cuit_cliente = cmb_clientes.SelectedValue.ToString();

            equipo.Modificar();
            MessageBox.Show("Se modificó correctamente el artículo " + cmb_equipos.SelectedValue.ToString(), "Importante");
        }

        private void Frm_EquiposEspeciales_Modificacion_Load(object sender, EventArgs e)
        {
            NE_EquiposEspeciales equipo = new NE_EquiposEspeciales();
            CargarFormulario(equipo.RecuperarEquipo(cod_prod_ensamblado));
        }

        private void CargarFormulario(DataTable tabla)
        {
            cmb_equipos.SelectedValue = int.Parse(tabla.Rows[0]["cod_prod_ensamblado"].ToString());
            cmb_clientes.SelectedValue = int.Parse(tabla.Rows[0]["cuit_cliente"].ToString());

        }
    }
}
