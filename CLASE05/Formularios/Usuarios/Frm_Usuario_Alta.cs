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
    public partial class Frm_Usuario_Alta : CLASE05.Formularios.Usuarios.Frm_Usuario
    {
        NE_Usuarios usu = new NE_Usuarios();
        public Frm_Usuario_Alta()
        {
            InitializeComponent();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if(usu.ValidarExistenciaNombre(txt_n_usuario._Text) == true)
            {
                MessageBox.Show("El nombre de usuario '" + txt_n_usuario._Text + "' ya está registrado", "Importante");
                txt_n_usuario.Focus();
                return;
            }

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                // GRABAR NUEVO REGISTRO  
                usu.n_usuario = txt_n_usuario._Text;
                usu.password = txt_password._Text;
                
                usu.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }
        private void Frm_Usuario_Alta_Activated(object sender, EventArgs e)
        {
            this.txt_n_usuario.Focus();
        }

        private void Frm_Usuario_Alta_Load(object sender, EventArgs e)
        {
            //maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
    }
}


