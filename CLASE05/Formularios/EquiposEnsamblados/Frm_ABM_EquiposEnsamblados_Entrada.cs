using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.EquiposEnsamblados
{
    public partial class Frm_ABM_EquiposEnsamblados_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_EquiposEnsamblados_Entrada()
        {
            InitializeComponent();
        }

        private void Frm_ABM_EquiposEnsamblados_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_equiposEnsamblados.Formatear("cod_prod_ensamblado, 100, C; nombre, 250, I; precio, 100, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_EquiposEnsamblados producto = new NE_EquiposEnsamblados();
           
            if (rb_todos.Checked == true)
            {
                grid_equiposEnsamblados.Cargar(producto.BuscarEquipoEnsamblado(""));
                return;
            }
            if (txt_patron.Text != string.Empty)
            {
                if (rb_id.Checked == true)
                { 
                    grid_equiposEnsamblados.Cargar(producto.BuscarEquipoEnsamblado(txt_patron.Text));

                }
                   
                if (rb_nombre.Checked == true)
                {                 
                    grid_equiposEnsamblados.Cargar(producto.BuscarEnsambladoNombre(txt_patron.Text));
                }    

                if (grid_equiposEnsamblados.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún equipo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_equiposEnsamblados.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar equipos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_equiposEnsamblados.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Equipo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_EquiposEnsamblados_Modificacion frm_modificacion = new Frm_EquiposEnsamblados_Modificacion();
            frm_modificacion.cod_prod_ensamblado = grid_equiposEnsamblados.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_equiposEnsamblados.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar equipos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_equiposEnsamblados.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Equipo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_EquiposEnsamblados_Baja frm_baja = new Frm_EquiposEnsamblados_Baja();
            frm_baja.cod_prod_ensamblado = grid_equiposEnsamblados.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_EquiposEnsamblados_Alta frm_altas = new Frm_EquiposEnsamblados_Alta();
            frm_altas.ShowDialog();
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_equiposEnsamblados.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_equiposEnsamblados.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_EquiposEnsamblados_Consulta frm_consulta = new Frm_EquiposEnsamblados_Consulta();
            frm_consulta.cod_prod_ensamblado = grid_equiposEnsamblados.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }

        private void txt_patron_Click(object sender, EventArgs e)
        {
            txt_patron.SelectionStart = txt_patron.Text.Length;
        }
    }
}
