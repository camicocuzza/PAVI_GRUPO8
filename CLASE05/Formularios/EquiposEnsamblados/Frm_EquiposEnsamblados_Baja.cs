using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.EquiposEnsamblados
{
    public partial class Frm_EquiposEnsamblados_Baja : CLASE05.Formularios.EquiposEnsamblados.Frm_EquiposEnsamblados
    {
        public Frm_EquiposEnsamblados_Baja()
        {
            InitializeComponent();
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_cod_p_ensamblado._Text = tabla.Rows[0]["cod_prod_ensamblado"].ToString();
            txt_precio._Text = tabla.Rows[0]["precio"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();

        }

        private void Frm_EquiposEnsamblados_Baja_Load(object sender, EventArgs e)
        {
            NE_EquiposEnsamblados equipo = new NE_EquiposEnsamblados();
            CargarFormulario(equipo.RecuperarEquipo(cod_prod_ensamblado));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_EquiposEnsamblados equipo = new NE_EquiposEnsamblados();

                equipo.cod_prod_ensamblado = txt_cod_p_ensamblado._Text;

                if (MessageBox.Show("¿Está seguro de que desea eliminar al equipo ensamblado " + txt_cod_p_ensamblado._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    equipo.Borrar();
                    MessageBox.Show("Se eliminó correctamente el equipo ensamblado " + txt_cod_p_ensamblado._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            }
        }
    }
}
