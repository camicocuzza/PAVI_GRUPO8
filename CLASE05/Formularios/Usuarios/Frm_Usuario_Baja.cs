using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Usuarios
{
    public partial class Frm_Usuario_Baja : CLASE05.Formularios.Usuarios.Frm_Usuario
    {
        public Frm_Usuario_Baja()
        {
            InitializeComponent();
        }

        private void Frm_Usuario_Baja_Load(object sender, EventArgs e)
        {
            NE_Usuarios usu = new NE_Usuarios();
            CargarFormulario(usu.RecuperarUsuario(id_usuario));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_id_usuario._Text = tabla.Rows[0]["id_usuario"].ToString();
            txt_n_usuario._Text = tabla.Rows[0]["n_usuario"].ToString();
            txt_password._Text = tabla.Rows[0]["password"].ToString();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            //if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            //{
            NE_Usuarios usu = new NE_Usuarios();

            usu.id_usuario = txt_id_usuario._Text;

            if (MessageBox.Show("¿Está seguro de que desea eliminar al usuario '" + txt_n_usuario._Text + "'?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usu.Borrar();
                MessageBox.Show("Se eliminó correctamente el usuario '" + txt_n_usuario._Text + "'", "Importante");
                this.Dispose();
            }
            else
                MessageBox.Show("Eliminación cancelada");

            //}

        }




    }
}
