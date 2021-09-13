using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Clientes
{
    public partial class Frm_ABM_Cliente_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Cliente_Entrada()
        {
            InitializeComponent();
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
            this.txt_cuit_cliente.Text = string.Empty;
            txt_cuit_cliente.Enabled = false;
            txt_patron.Enabled = false;
        }

        private void Frm_ABM_Cliente_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_clientes.Formatear("cuit_cliente, 100, C; razon_social, 170, I; nombre_contacto, 170, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Clientes cli = new NE_Clientes();

            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_razon_social.Checked == true)
                    columna = rb_razon_social.Text;
                if (rb_nombre_contacto.Checked == true)
                    columna = rb_nombre_contacto.Text;

                grid_clientes.Cargar(cli.BuscarCliente(txt_patron.Text, columna));
                if (grid_clientes.Rows.Count == 0)
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_cuit_cliente.Text != string.Empty)
            {
                grid_clientes.Cargar(cli.BuscarCliente(txt_cuit_cliente.Text));
                if (grid_clientes.Rows.Count == 0)
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }



        private void btn_alta_Click(object sender, EventArgs e)
        {
            //Frm_Cliente_Alta frm_altas = new Frm_Cliente_Alta();
            //frm_altas.ShowDialog();
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_clientes.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_clientes.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //Frm_Cliente_Modificacion frm_modificar = new Frm_Cliente_Modificacion();
            //frm_modificar.cuit_cliente = grid_clientes.CurrentRow.Cells[0].Value.ToString();
            //frm_modificar.ShowDialog();

        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_clientes.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_clientes.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            ////Frm_Cliente_Baja frm_baja = new Frm_Cliente_Baja();
            //frm_baja.cuit_cliente = grid_clientes.CurrentRow.Cells[0].Value.ToString();
            //frm_baja.ShowDialog();

            grid_clientes.Rows.Clear();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_clientes.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_clientes.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //Frm_Cliente_Consulta frm_consulta = new Frm_Cliente_Consulta();
            //frm_consulta.cuit_cliente = grid_clientes.CurrentRow.Cells[0].Value.ToString();
            //frm_consulta.ShowDialog();
        }


    }    
    
}
