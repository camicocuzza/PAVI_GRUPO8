using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.EquiposEspeciales
{
    public partial class Frm_ABM_EquiposEspeciales_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_EquiposEspeciales_Entrada()
        {
            InitializeComponent();
        }

        private void Frm_ABM_EquiposEspeciales_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_equiposEspeciales.Formatear("cod_prod_ensamblado, 150, C; cuit_cliente, 150, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_EquiposEspeciales producto = new NE_EquiposEspeciales();
            string columna = "";
            if (rb_todos.Checked == true)
            {
                grid_equiposEspeciales.Cargar(producto.BuscarEquipoEspecial("", "cod_prod_ensamblado"));
                return;
            }

            if (txt_patron.Text != string.Empty)
            {
                if (rb_cod_prodEnsamblado.Checked == true)
                    columna = "cod_prod_ensamblado";
                if (rb_cuit_cliente.Checked == true)
                    columna = "cuit_cliente";

                grid_equiposEspeciales.Cargar(producto.BuscarEquipoEspecial(txt_patron.Text, columna));
                if (grid_equiposEspeciales.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún equipo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_equiposEspeciales.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar equipos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_equiposEspeciales.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Equipo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_EquiposEspeciales_Modificacion frm_modificacion = new Frm_EquiposEspeciales_Modificacion();
            frm_modificacion.cod_prod_ensamblado = grid_equiposEspeciales.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_equiposEspeciales.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar equipos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_equiposEspeciales.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Equipo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_EquiposEspeciales_Baja frm_baja = new Frm_EquiposEspeciales_Baja();
            frm_baja.cod_prod_ensamblado = grid_equiposEspeciales.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_EquiposEspeciales_Alta frm_altas = new Frm_EquiposEspeciales_Alta();
            frm_altas.ShowDialog();
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_equiposEspeciales.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar equipos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_equiposEspeciales.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Equipo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_EquiposEspeciales_Consulta frm_consulta = new Frm_EquiposEspeciales_Consulta();
            frm_consulta.cod_prod_ensamblado = grid_equiposEspeciales.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }

        private void txt_patron_Click(object sender, EventArgs e)
        {
            txt_patron.SelectionStart = txt_patron.Text.Length;
        }
    }
}
