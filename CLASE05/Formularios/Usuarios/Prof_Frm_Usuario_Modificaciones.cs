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
    public partial class Prof_Frm_Usuario_Modificaciones : CLASE05.Formularios.Usuarios.Prof_Frm_Usuario
    {
        public Prof_Frm_Usuario_Modificaciones()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                // VALIDACION ESPECIFICA
                if (_TE.ValidarEmail(txt_email._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                {
                    MessageBox.Show("El formato de correo es invalido");
                    txt_email.Focus();
                    return;
                }

                // GRABAR NUEVO REGISTRO
                NE_Usuarios usu = new NE_Usuarios();

                usu.id_perfil = cmb_perfiles.SelectedValue.ToString();
                usu.n_usario = txt_n_usuario._Text;
                usu.passsword = txt_password._Text;
                usu.email = txt_email._Text;
                usu.apellido = txt_apellido._Text;
                usu.nombres = txt_nombres._Text;
                usu.cuil = txt_cuil._Text;
                usu.id_estado = cmb_estadosUsuarios.SelectedValue.ToString();



            }
        }
        private void Frm_Usuario_Modificaciones_Load(object sender, EventArgs e)
        {
            NE_Usuarios usu = new NE_Usuarios();
            CargarFormulario(usu.RecuperarUsuario(id_usuario));
        }
        private void CargarFormulario (DataTable tabla)
        {
            txt_id_usuario._Text = tabla.Rows[0]["id_usuario"].ToString();
            txt_n_usuario._Text = tabla.Rows[0]["n_usuario"].ToString();
            txt_password._Text = tabla.Rows[0]["password"].ToString();
            cmb_perfiles.SelectedValue = int.Parse(tabla.Rows[0]["id_perfil"].ToString());
            txt_email._Text = tabla.Rows[0]["email"].ToString();
            txt_apellido._Text = tabla.Rows[0]["apellido"].ToString();
            txt_nombres._Text = tabla.Rows[0]["nombres"].ToString();
            txt_cuil._Text = tabla.Rows[0]["cuil"].ToString();
            cmb_estadosUsuarios.SelectedValue = int.Parse(tabla.Rows[0]["id_estado"].ToString());
        }
    }
}
