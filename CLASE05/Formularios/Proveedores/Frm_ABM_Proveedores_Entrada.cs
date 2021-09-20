using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Proveedores
{
    public partial class Frm_ABM_Proveedores_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Proveedores_Entrada()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Proveedores_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_proveedores.Formatear("CUIT, 100, C; Razon social, 250, I; Fecha inicio de operación, 150, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Proveedores empleado = new NE_Proveedores();
            string columna = "";

            if (rb_todos.Checked == true)
            {
                grid_proveedores.Cargar(empleado.BuscarProveedor("", "cuit_proveedor"));
                return;
            }
            if (txt_patron.Text != string.Empty)
            {
                if (rb_cuit.Checked == true)
                    columna = "cuit_proveedor";
                if (rb_razon_social.Checked == true)
                    columna = "razon_social";

                grid_proveedores.Cargar(empleado.BuscarProveedor(txt_patron.Text, columna));
                if (grid_proveedores.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún proveedor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_proveedores.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Proveedor_Consulta frm_consulta = new Frm_Proveedor_Consulta();
            frm_consulta.cuit_proveedor = grid_proveedores.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Proveedor_Alta frm_altas = new Frm_Proveedor_Alta();
            frm_altas.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_proveedores.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Proveedor_Modificacion frm_modificacion = new Frm_Proveedor_Modificacion();
            frm_modificacion.cuit_proveedor = grid_proveedores.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_proveedores.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Proveedor_Baja frm_baja = new Frm_Proveedor_Baja();
            frm_baja.cuit_proveedor = grid_proveedores.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();
        }
    }
}
