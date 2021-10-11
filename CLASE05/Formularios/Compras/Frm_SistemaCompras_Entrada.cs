using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Compras
{
    public partial class Frm_SistemaCompras_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_SistemaCompras_Entrada()
        {
            InitializeComponent();
        }

        private void rb_num_compra_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_num_compra.Checked == true)
            {
                txt_fecha.Visible = false;
                txt_numero.Visible = true;
                cmb_proveedores.Visible = false;

            }
        }

        private void rb_proveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_proveedor.Checked == true)
            {
                txt_fecha.Visible = false;
                txt_numero.Visible = false;
                cmb_proveedores._Cargar();
                cmb_proveedores.Visible = true;

            }
        }

        private void rb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fecha.Checked == true)
            {
                txt_fecha.Visible = true;
                cmb_proveedores.Visible = false;
                txt_numero.Visible = false;


            }
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_todos.Checked == true)
            {
                txt_fecha.Visible = false;
                cmb_proveedores.Visible = false;
                txt_numero.Visible = false;

            }
        }

        private void Frm_SistemaCompras_Entrada_Load(object sender, EventArgs e)
        {
            grid_compras.Formatear("Número de compra, 100, C; Cuit Proveedor, 250, C; Fecha, 100, D; Monto total, 150, D");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Compras compras = new NE_Compras();

            if(rb_num_compra.Checked == false & rb_fecha.Checked == false & rb_proveedor.Checked == false & rb_todos.Checked == false)
            {
                MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rb_todos.Checked == true)
            {
                grid_compras.Cargar(compras.BuscarCompra("", "num_compra"));
                if (grid_compras.Rows.Count == 0)
                    MessageBox.Show("No se encontró ninguna compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (rb_num_compra.Checked == true)
            {
                if (txt_numero.Text == string.Empty)
                {
                    MessageBox.Show("Falta completar el número", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                grid_compras.Cargar(compras.BuscarCompra(txt_numero._Text, "num_compra"));
                if (grid_compras.Rows.Count == 0)
                    MessageBox.Show("No se encontró ninguna compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (rb_fecha.Checked == true)
            {
                if (txt_fecha.Text == string.Empty)
                {
                    MessageBox.Show("Falta completar la fecha", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                grid_compras.Cargar(compras.BuscarCompra(txt_fecha._Text, "fecha"));
                if (grid_compras.Rows.Count == 0)
                    MessageBox.Show("No se encontró ninguna compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (rb_proveedor.Checked == true)
            {
                if (cmb_proveedores.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccionar proveedor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                grid_compras.Cargar(compras.BuscarCompra(cmb_proveedores.SelectedValue.ToString(), "cuit_proveedor"));
                if (grid_compras.Rows.Count == 0)
                    MessageBox.Show("No se encontró ninguna compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           
        }
    }
}
