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
    public partial class Frm_Usuario_Consulta : CLASE05.Formularios.Usuarios.Frm_Usuario
    {
        public Frm_Usuario_Consulta()
        {
            InitializeComponent();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_Usuario_Consulta_Load(object sender, EventArgs e)
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
    }    
}
