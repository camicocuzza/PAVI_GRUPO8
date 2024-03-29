﻿using System;
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
            frm_altas.Show();
        }      
        private void Frm_SistemaFacturas_Entrada_Load(object sender, EventArgs e)
        {
            this.grid_facturas.Formatear("Nro. Venta, 100, C; ID Tipo Factura, 100, I; Fecha, 80, I; Monto Total, 100, I; CUIT Cliente, 90, I; Legajo empleado, 120, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Facturas ne_facturas = new NE_Facturas();

            string columna = "";
            MaskedTextBox cuadroTexto = new MaskedTextBox();
            cuadroTexto.Text = "";

            if (rb_cuit_cliente.Checked == false & rb_num_factura.Checked == false & rb_todas.Checked == false & rb_legajo_empleado.Checked == false & rb_fecha.Checked == false)
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
            if (rb_fecha.Checked == true)
            {
                if (txt_patron.Text == string.Empty)
                {
                    MessageBox.Show("Falta completar la fecha", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string[] f = txt_patron.Text.Split('/');

                string fecha_buscar = f[2] + "-" + f[1] + "-" + f[0];

                grid_facturas.Cargar(ne_facturas.BuscarPorFecha(fecha_buscar));
                if (grid_facturas.Rows.Count == 0)
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (rb_cuit_cliente.Checked == true)
            {
                columna = "cuit_cliente";
                cuadroTexto = txt_patron;
            }
            if (rb_num_factura.Checked == true)
            {
                columna = "num_factura";
                cuadroTexto = txt_patron;               
            }
          
            if (rb_legajo_empleado.Checked == true)
            {
                columna = "legajo_empleado";
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
            Frm_SistemaFacturas_Consulta frm_consulta = new Frm_SistemaFacturas_Consulta();
            frm_consulta.num_factura = grid_facturas.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.id_tipo_factura = grid_facturas.CurrentRow.Cells[1].Value.ToString();
            frm_consulta.cuit_cliente = grid_facturas.CurrentRow.Cells[4].Value.ToString();
            frm_consulta.fecha = grid_facturas.CurrentRow.Cells[2].Value.ToString();
            frm_consulta.Show();            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //if (grid_facturas.Rows.Count == 0)
            //{
            //    MessageBox.Show("Falta buscar registros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}
            //if (grid_facturas.CurrentCell.RowIndex == -1)
            //{
            //    MessageBox.Show("Falta seleccionar un registro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}
            //Frm_SistemaFacturas_Modificacion frm_modificacion = new Frm_SistemaFacturas_Modificacion();
            //frm_modificacion.num_factura = grid_facturas.CurrentRow.Cells[0].Value.ToString();
            //frm_modificacion.id_tipo_factura = grid_facturas.CurrentRow.Cells[1].Value.ToString();
            //frm_modificacion.cuit_cliente = grid_facturas.CurrentRow.Cells[4].Value.ToString();
            //frm_modificacion.fecha = grid_facturas.CurrentRow.Cells[2].Value.ToString();
            //frm_modificacion.ShowDialog();

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
            frm_bajas.Show();
            
        }

        private void txt_patron_Click(object sender, EventArgs e)
        {
            if(rb_cuit_cliente.Checked == false && rb_fecha.Checked == false)
            {
                txt_patron.Mask = "999999999";
                txt_patron.SelectionStart = txt_patron.Text.Length;
                txt_patron.Focus();
            }
            if (rb_fecha.Checked == true)
            {
                txt_patron.Mask = "99/99/9999";
                txt_patron.SelectionStart = 0;
                txt_patron.Focus();
            }
            if (rb_cuit_cliente.Checked == true)
            {
                txt_patron.Mask = "99-99999999-9";
                txt_patron.SelectionStart = 0;
                txt_patron.Focus();
            }
        }

        private void rb_cuit_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cuit_cliente.Checked == true)
            {
                txt_patron.Mask = "99-99999999-9";                
            }
        }

        private void rb_num_factura_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_num_factura.Checked == true || rb_legajo_empleado.Checked == true || rb_todas.Checked == true) 
            {
                txt_patron.Mask = "999999999";
            }
        }

        private void rb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fecha.Checked == true)
            {
                txt_patron.Mask = "99/99/9999";
            }
        }
    }
}
