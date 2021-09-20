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
    public partial class Frm_EquiposEspeciales_Baja : CLASE05.Formularios.EquiposEspeciales.Frm_EquiposEspeciales
    {
        public Frm_EquiposEspeciales_Baja()
        {
            InitializeComponent();
        }
        private void CargarFormulario(DataTable tabla)
        {
            cmb_equipos.SelectedValue = tabla.Rows[0]["cod_prod_ensamblado"].ToString();
            cmb_clientes.SelectedValue = tabla.Rows[0]["cuit_cliente"].ToString();
            byte[] datos = new byte[0];
            datos = (byte[])tabla.Rows[0]["logo_cliente"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
            pb_imagen.Image = System.Drawing.Bitmap.FromStream(ms);

        }

        private void Frm_EquiposEspeciales_Baja_Load(object sender, EventArgs e)
        {
            NE_EquiposEspeciales equipo = new NE_EquiposEspeciales();
            CargarFormulario(equipo.RecuperarEquipo(cod_prod_ensamblado));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_EquiposEspeciales equipo = new NE_EquiposEspeciales();

                equipo.cod_prod_ensamblado = cmb_equipos.SelectedValue.ToString();

                if (MessageBox.Show("¿Está seguro de que desea eliminar al equipo especial " + cmb_equipos.SelectedValue.ToString() + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    equipo.Borrar();
                    MessageBox.Show("Se eliminó correctamente el equipo especial " + cmb_equipos.SelectedValue.ToString(), "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            }
        }

        
    }
}
