﻿using System;
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
    public partial class Frm_Usuario_Modificacion : CLASE05.Formularios.Usuarios.Frm_Usuario
    {
        string n_usuario_anterior;

        NE_Usuarios usu = new NE_Usuarios();
        public Frm_Usuario_Modificacion()
        {
            InitializeComponent();
        }              

        private void Frm_Usuario_Modificaciones_Load(object sender, EventArgs e)
        {
            NE_Usuarios usu = new NE_Usuarios();
            CargarFormulario(usu.RecuperarUsuario(id_usuario));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_id_usuario._Text = tabla.Rows[0]["id_usuario"].ToString();
            txt_n_usuario._Text = tabla.Rows[0]["n_usuario"].ToString();
            txt_password._Text = tabla.Rows[0]["password"].ToString();

            n_usuario_anterior = txt_n_usuario._Text;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (txt_n_usuario._Text != n_usuario_anterior)
            {
                if (usu.ValidarExistenciaNombre(txt_n_usuario._Text) == true)
                {
                    MessageBox.Show("El nombre de usuario '" + txt_n_usuario._Text + "' ya está registrado", "Importante");
                    txt_n_usuario.Focus();
                    return;
                }
            }
            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {  
                // GRABAR NUEVO REGISTRO             

                usu.id_usuario = txt_id_usuario._Text;
                usu.n_usuario = txt_n_usuario._Text;
                usu.password = txt_password._Text;

                usu.Modificar();
                MessageBox.Show("Se modificó correctamente el usuario " + txt_n_usuario._Text, "Importante");

            }
        }
    }
}
