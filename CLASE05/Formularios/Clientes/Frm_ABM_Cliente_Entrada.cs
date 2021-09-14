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
            rb_cuit_cliente.Checked = false;
            rb_razon_social.Checked = false;
            rb_nombre_contacto.Checked = false;
            rb_legajo_empleado.Checked = false;
        }

        private void Frm_ABM_Cliente_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_clientes.Formatear("cuit_cliente, 100, C; razon_social, 170, I; nombre_contacto, 170, I; legajo_empleado, 150, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Clientes cli = new NE_Clientes();

            string columna = "";
            MaskedTextBox cuadroTexto = null;

            if (rb_cuit_cliente.Checked == false & rb_razon_social.Checked == false & rb_nombre_contacto.Checked == false & rb_legajo_empleado.Checked == false)
            {
                //MessageBox.Show("Marcar atributo de búsqueda");
                grid_clientes.Cargar(cli.BuscarCliente("", rb_cuit_cliente.Text));
                return;
            }
            if (rb_cuit_cliente.Checked == true)
            {
                columna = rb_cuit_cliente.Text;
                cuadroTexto = txt_cuit_cliente;
            }
            if (rb_razon_social.Checked == true)
            {
                columna = rb_razon_social.Text;
                cuadroTexto = txt_patron;
            }
            if (rb_nombre_contacto.Checked == true)
            {
                columna = rb_nombre_contacto.Text;
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
            }
            else
            {
                grid_clientes.Cargar(cli.BuscarCliente(cuadroTexto.Text, columna));
                if (grid_clientes.Rows.Count == 0)
                {
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            return;
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
            Frm_Cliente_Consulta frm_consulta = new Frm_Cliente_Consulta();
            frm_consulta.cuit_cliente = grid_clientes.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }

        private void txt_cuit_cliente_Click(object sender, EventArgs e)
        {
            txt_cuit_cliente.SelectionStart = 0;
        }

        private void txt_patron_Click(object sender, EventArgs e)
        {
            txt_patron.SelectionStart = txt_patron.Text.Length;
            if(rb_legajo_empleado.Checked == true)
            {
                txt_patron.Mask = "999999";
            }
            else
                txt_patron.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";

        }
    }    
    
}
