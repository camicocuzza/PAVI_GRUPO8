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
        NE_Usuarios usu = new NE_Usuarios();
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
            txt_patron.Text = string.Empty;
            txt_id_usuario.Text = string.Empty;
            rb_id_usuario.Checked = false;
            rb_n_usuario.Checked = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Usuarios usu = new NE_Usuarios();

            string columna = "";
            MaskedTextBox cuadroTexto = new MaskedTextBox();
            cuadroTexto.Text = "";

            if (rb_id_usuario.Checked == false & rb_n_usuario.Checked == false & rb_todos.Checked == false & rb_eliminados.Checked == false)
            {
                MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rb_todos.Checked == true)
            {
                grid_usuarios.Cargar(usu.BuscarUsuario("", rb_id_usuario.Text));
                return;
            }
            if (rb_eliminados.Checked == true)
            {
                grid_usuarios.Cargar(usu.ObtenerEliminados());
                return;
            }
            if (rb_n_usuario.Checked == true)
            {
                columna = rb_n_usuario.Text;
                cuadroTexto = txt_patron;
            }
            if (rb_id_usuario.Checked == true)
            {
                columna = rb_id_usuario.Text;
                cuadroTexto = txt_id_usuario;
            }
            if (cuadroTexto.Text == "")
            {
                MessageBox.Show("Ingresar patrón de búsqueda");
                return;
            }
            else
            {
                grid_usuarios.Cargar(usu.BuscarUsuario(cuadroTexto.Text, columna));
                if (grid_usuarios.Rows.Count == 0)
                {
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            return;                
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
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_usuarios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_usuarios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_usuarios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Usuario_Consulta frm_consulta = new Frm_Usuario_Consulta();
            frm_consulta.id_usuario = grid_usuarios.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();

        }

        private void rb_n_usuario_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        private void rb_id_usuario_CheckedChanged(object sender, EventArgs e)
        {
           
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
            if (e.KeyChar == (char)13)
            {
                NE_Usuarios usu = new NE_Usuarios();

                string columna = "";
                MaskedTextBox cuadroTexto = new MaskedTextBox();
                cuadroTexto.Text = "";

                if (rb_id_usuario.Checked == false & rb_n_usuario.Checked == false & rb_todos.Checked == false)
                {
                    MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (rb_todos.Checked == true)
                {
                    grid_usuarios.Cargar(usu.BuscarUsuario("", rb_id_usuario.Text));
                    return;
                }
                if (rb_n_usuario.Checked == true)
                {
                    columna = rb_n_usuario.Text;
                    cuadroTexto = txt_patron;
                }
                if (rb_id_usuario.Checked == true)
                {
                    columna = rb_id_usuario.Text;
                    cuadroTexto = txt_id_usuario;
                }
                if (cuadroTexto.Text == "")
                {
                    MessageBox.Show("Ingresar patrón de búsqueda");
                }
                else
                {
                    grid_usuarios.Cargar(usu.BuscarUsuario(cuadroTexto.Text, columna));
                    if (grid_usuarios.Rows.Count == 0)
                    {
                        MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                return;
            }
        }

        private void grid_usuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (usu.EstaEliminado(grid_usuarios.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                if (MessageBox.Show("¿Desea restaurar el usuario '" + grid_usuarios.CurrentRow.Cells[1].Value.ToString() + "'?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usu.RestaurarEliminado(grid_usuarios.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Se restauró correctamente el usuario '" + grid_usuarios.CurrentRow.Cells[1].Value.ToString() + "'", "Importante"); 
                }
            }
        }
    }
}

    

