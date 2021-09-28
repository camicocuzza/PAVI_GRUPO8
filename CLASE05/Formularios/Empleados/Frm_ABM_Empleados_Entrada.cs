using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Empleados
{
    public partial class Frm_ABM_Empleados_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Empleados_Entrada()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Empleados_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_empleados.Formatear("Legajo, 100, C; Tipo Doc, 50, I; Nro Documento, 100, I; Apellido, 100, I; Nombre, 100, I; Teléfono, 100, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Empleados empleado = new NE_Empleados();
            string columna = "";

            if (rb_todos.Checked == true)
            {
                grid_empleados.Cargar(empleado.BuscarEmpleado("", "legajo_empleado"));
                return;
            }
            if (txt_patron.Text != string.Empty)
            {
                if (rb_legajo.Checked == true)
                    columna = "legajo_empleado";
                if (rb_n_documento.Checked == true)
                    columna = "nro_documento";
                if (rb_apellido.Checked == true)
                    columna = "apellido";

                grid_empleados.Cargar(empleado.BuscarEmpleado(txt_patron.Text, columna));
                if (grid_empleados.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún empleado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_empleados.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_empleados.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Empleado_Consulta frm_consulta = new Frm_Empleado_Consulta();
            frm_consulta.legajo_empleado = grid_empleados.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Alta frm_altas = new Frm_Empleado_Alta();
            frm_altas.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_empleados.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_empleados.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Empleado_Modificacion frm_modificacion = new Frm_Empleado_Modificacion();
            frm_modificacion.legajo_empleado = grid_empleados.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_empleados.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_empleados.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Empleado_Baja frm_baja = new Frm_Empleado_Baja();
            frm_baja.legajo_empleado = grid_empleados.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();
        }

        private void txt_patron_Click(object sender, EventArgs e)
        {
            txt_patron.SelectionStart = txt_patron.Text.Length;
        }
    }
}
