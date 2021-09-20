using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Lotes
{
    public partial class Frm_ABM_Lote_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Lote_Entrada()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Lote_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_lotes.Formatear("Número lote, 100, C; Número remito, 100, I; Fecha de compra, 100, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Lotes lotes = new NE_Lotes();
            string columna = "";

            if (rb_todos.Checked == true)
            {
                grid_lotes.Cargar(lotes.BuscarLote("", "num_lote"));
                return;
            }
            if (txt_patron.Text != string.Empty)
            {
                if (rb_n_lote.Checked == true)
                    columna = "num_lote";    
                if (rb_n_remito.Checked == true)
                    columna = "nro_remito_proveedor";
                if (rb_fecha_compra.Checked == true)
                    columna = "fecha_compra";

                grid_lotes.Cargar(lotes.BuscarLote(txt_patron.Text, columna));
                if (grid_lotes.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún lote", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Lote_Alta frm_altas = new Frm_Lote_Alta();
            frm_altas.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_lotes.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar lotes", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_lotes.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un lote", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_Lote_Modificacion frm_modificacion = new Frm_Lote_Modificacion();
            frm_modificacion.num_lote = grid_lotes.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_lotes.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar lotes", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_lotes.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un lote", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Lote_Baja frm_baja = new Frm_Lote_Baja();
            frm_baja.num_lote = grid_lotes.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_lotes.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_lotes.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Lote_Consulta frm_consulta = new Frm_Lote_Consulta();
            frm_consulta.num_lote = grid_lotes.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }
    }
}
