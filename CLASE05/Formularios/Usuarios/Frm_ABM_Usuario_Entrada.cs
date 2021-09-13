using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Usuarios
{
    public partial class Frm_ABM_Usuario_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Usuario_Entrada()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Usuario_Load(object sender, EventArgs e)
        {
            this.grid_usuarios.Formatear("id, 75, C; n_usuario, 200, I");
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
            this.txt_id_usuario.Text = string.Empty;
            txt_id_usuario.Enabled = false;
            txt_patron.Enabled = false;
           // btn_buscar.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Usuarios usu = new NE_Usuarios();

            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_n_usuario.Checked == true)
                    columna = rb_n_usuario.Text;
                
                grid_usuarios.Cargar(usu.BuscarUsuario(txt_patron.Text, columna));
                if (grid_usuarios.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_id_usuario.Text != string.Empty)
            {
                grid_usuarios.Cargar(usu.BuscarUsuario(txt_id_usuario.Text));
                if (grid_usuarios.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

           // btn_buscar.Enabled = false;
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Usuario_Alta frm_altas = new Frm_Usuario_Alta();
            frm_altas.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar usuarios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_usuarios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_Usuario_Modificacion frm_modificar = new Frm_Usuario_Modificacion();
            frm_modificar.id_usuario = grid_usuarios.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar usuarios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_usuarios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_Usuario_Baja frm_baja = new Frm_Usuario_Baja();
            frm_baja.id_usuario = grid_usuarios.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();

            grid_usuarios.Rows.Clear();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar usuarios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_usuarios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_Usuario_Consulta frm_consulta = new Frm_Usuario_Consulta();
            frm_consulta.id_usuario = grid_usuarios.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();

        }

        private void rb_n_usuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_n_usuario.Checked == true)
            {
                txt_id_usuario.Enabled = false;
                txt_id_usuario.Clear();
                txt_patron.Enabled = true;
            }
        }
        
        private void rb_id_usuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_id_usuario.Checked == true)
            {
                txt_id_usuario.Enabled = true;
                txt_patron.Enabled = false;
                txt_patron.Clear();
            }
        }
        private void txt_patron_Click(object sender, EventArgs e)
        {
            txt_patron.SelectionStart = txt_patron.Text.Length;
        }

        private void txt_id_usuario_Click(object sender, EventArgs e)
        {
            txt_id_usuario.SelectionStart = txt_id_usuario.Text.Length;
        }

        private void txt_patron_KeyPress(object sender, KeyPressEventArgs e)
        {
            NE_Usuarios usu = new NE_Usuarios();

            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_n_usuario.Checked == true)
                    columna = rb_n_usuario.Text;

                grid_usuarios.Cargar(usu.BuscarUsuario(txt_patron.Text, columna));
                if (grid_usuarios.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_id_usuario.Text != string.Empty)
            {
                grid_usuarios.Cargar(usu.BuscarUsuario(txt_id_usuario.Text));
                if (grid_usuarios.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

    

