using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Formularios;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_SistemaFacturas_Entrada()
        {
            InitializeComponent();
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
            rb_num_factura.Checked = false;
            rb_cuit_cliente.Checked = false;
            rb_todas.Checked = false;
            rb_legajo_empleado.Checked = false;
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_SistemaFacturas_Alta frm_altas = new Frm_SistemaFacturas_Alta();
            frm_altas.ShowDialog();
        }      
        private void Frm_SistemaFacturas_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_facturas.Formatear("num_factura, 100, C; id_tipo_factura, 100, I; fecha, 80, I; monto_total, 100, I; cuit_cliente, 90, I; legajo_empleado, 120, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Facturas ne_facturas = new NE_Facturas();

            string columna = "";
            MaskedTextBox cuadroTexto = new MaskedTextBox();
            cuadroTexto.Text = "";

            if (rb_cuit_cliente.Checked == false & rb_num_factura.Checked == false & rb_todas.Checked == false & rb_legajo_empleado.Checked == false)
            {
                MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rb_todas.Checked == true)
            {
                grid_facturas.Cargar(ne_facturas.BuscarTodas());
                if (grid_facturas.Rows.Count == 0)
                {
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                return;
            }
            if (rb_cuit_cliente.Checked == true)
            {
                columna = rb_cuit_cliente.Text;
                cuadroTexto = txt_patron;
            }
            if (rb_num_factura.Checked == true)
            {
                columna = rb_num_factura.Text;
                cuadroTexto = txt_patron;               
            }
          
            if (rb_legajo_empleado.Checked == true)
            {
                columna = rb_legajo_empleado.Text;
                cuadroTexto = txt_patron;
            }
            if (cuadroTexto.Text == "")
            {
                MessageBox.Show("Ingresar patrón de búsqueda");
                return;
            }
            else
            {
                grid_facturas.Cargar(ne_facturas.BuscarFactura(cuadroTexto.Text, columna));
                if (grid_facturas.Rows.Count == 0)
                {
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            return;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_facturas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_facturas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_SistemaFacturas_Modificacion frm_modificacion = new Frm_SistemaFacturas_Modificacion();
            frm_modificacion.num_factura = grid_facturas.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.id_tipo_factura = grid_facturas.CurrentRow.Cells[1].Value.ToString();
            frm_modificacion.cuit_cliente = grid_facturas.CurrentRow.Cells[4].Value.ToString();
            frm_modificacion.fecha = grid_facturas.CurrentRow.Cells[2].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_facturas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_facturas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_SistemaFacturas_Consulta frm_consulta = new Frm_SistemaFacturas_Consulta();
            frm_consulta.num_factura = grid_facturas.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.id_tipo_factura = grid_facturas.CurrentRow.Cells[1].Value.ToString();
            frm_consulta.cuit_cliente = grid_facturas.CurrentRow.Cells[4].Value.ToString();
            frm_consulta.fecha = grid_facturas.CurrentRow.Cells[2].Value.ToString();
            frm_consulta.ShowDialog();
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_facturas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_facturas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_SistemaFacturas_Baja frm_bajas = new Frm_SistemaFacturas_Baja();
            frm_bajas.num_factura = grid_facturas.CurrentRow.Cells[0].Value.ToString();
            frm_bajas.id_tipo_factura = grid_facturas.CurrentRow.Cells[1].Value.ToString();
            frm_bajas.cuit_cliente = grid_facturas.CurrentRow.Cells[4].Value.ToString();
            frm_bajas.fecha = grid_facturas.CurrentRow.Cells[2].Value.ToString();
            frm_bajas.ShowDialog();
            
        }
    }
}
