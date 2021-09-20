using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Articulos
{
    public partial class Frm_ABM_Articulos_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Articulos_Entrada()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Articulos_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_articulos.Formatear("cod_articulo, 75, C; lote, 100, I; precio, 100, I; nombre, 170, I; id_pais, 75, I; cuit_proveedor, 150, I");
        }

        private void rb_n_usuario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Articulos articulos = new NE_Articulos();
            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_cod_articulo.Checked == true)
                    columna = "cod_articulo";
                if (rb_n_articulo.Checked == true)
                    columna = "nombre";
                if (rb_lote_articulo.Checked == true)
                    columna = "num_lote";

                grid_articulos.Cargar(articulos.BuscarArticulo(txt_patron.Text, columna));
                if (grid_articulos.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Articulo_Alta frm_altas = new Frm_Articulo_Alta();
            frm_altas.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_articulos.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar artículos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_articulos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_Articulo_Modificacion frm_modificacion = new Frm_Articulo_Modificacion();
            frm_modificacion.cod_articulo = grid_articulos.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_articulos.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar artículos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_articulos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Articulo_Baja frm_baja = new Frm_Articulo_Baja();
            frm_baja.cod_articulo = grid_articulos.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_articulos.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_articulos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Articulo_Consulta frm_consulta = new Frm_Articulo_Consulta();
            frm_consulta.cod_articulo = grid_articulos.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }
    }
}
