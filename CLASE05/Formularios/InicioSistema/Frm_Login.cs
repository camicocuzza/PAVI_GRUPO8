using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;
using CLASE05.Formularios.FrmBASE;


namespace CLASE05.Formularios.InicioSistema
{
    public partial class Frm_Login : FrmBase
    {
       
        public string Pp_usuario
        {
            get { return this.txt_usuario.Text; }
            set { this.txt_usuario.Text = value; }
        }
        public string Pp_clave
        {
            get { return this.txt_clave.Text; }
            set { this.txt_clave.Text = value; }
        }
        
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("Ingresar nombre de usuario", "Importante"
                              , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txt_clave.Text == "")
            {
                MessageBox.Show("Ingresar clave de usuario", "Importante"
               , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            NE_Usuarios usuario = new NE_Usuarios();

            if (usuario.Validar(txt_usuario.Text, txt_clave.Text) == NE_Usuarios.Validacion.correcta)
            {
                //MessageBox.Show("¡Bienvenido!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
                MessageBox.Show("Los datos ingresados son incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "";
            txt_clave.Text = "";
            this.Dispose();
            Application.Exit();
        }

        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (txt_usuario.Text == "")
                {
                    MessageBox.Show("Ingresar nombre de usuario", "Importante"
                                  , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (txt_clave.Text == "")
                {
                    MessageBox.Show("Ingresar clave de usuario", "Importante"
                   , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                NE_Usuarios usuario = new NE_Usuarios();

                if (usuario.Validar(txt_usuario.Text, txt_clave.Text) == NE_Usuarios.Validacion.correcta)
                {
                    //MessageBox.Show("¡Bienvenido!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                    MessageBox.Show("Los datos ingresados son incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}
