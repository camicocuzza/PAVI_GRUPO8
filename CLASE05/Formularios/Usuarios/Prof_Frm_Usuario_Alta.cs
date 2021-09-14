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
    public partial class Prof_Frm_Usuario_Alta : CLASE05.Formularios.Usuarios.Prof_Frm_Usuario
    {
        public Prof_Frm_Usuario_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //N1  validar los datos del formulario
            //N1 la validacion de todo ok => realizo validación especifica
            //----N2 -------si la validacion especifica da ok => grabo
            //----N2 -------la validacion especifica da error => ir a corregir el error
            //N1 si validacion da error => ir a corregir el error
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            //if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            //{
            //    // VALIDACION ESPECIFICA
            //    if (_TE.ValidarEmail(txt_email._Text)== TratamientosEspeciales.RespuestaValidacion.Error)
            //    {
            //        MessageBox.Show("El formato de correo es invalido");
            //        txt_email.Focus();
            //        return;
            //    }
                
                //// GRABAR NUEVO REGISTRO
                //NE_Usuarios usu = new NE_Usuarios();

                //usu.id_perfil = cmb_perfiles.SelectedValue.ToString();
                //usu.n_usario = txt_n_usuario._Text;
                //usu.passsword = txt_password._Text;
                //usu.email = txt_email._Text;
                //usu.apellido = txt_apellido._Text;
                //usu.nombres = txt_nombres._Text;
                //usu.cuil = txt_cuil._Text;
                //usu.id_estado = cmb_estadosUsuarios.SelectedValue.ToString();

                //usu.Isertar();
                //MessageBox.Show("Se Grabó correctamente", "Importante");
            }
        }
        //private void Prof_Frm_Usuario_Alta_Activated(object sender, EventArgs e)
        //{
        //    //this.txt_n_usuario.Focus();
        //}

        //private void Prof_Frm_Usuario_Alta_Activated(object sender, EventArgs e)
        //{
        //    //maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        //}
    }

