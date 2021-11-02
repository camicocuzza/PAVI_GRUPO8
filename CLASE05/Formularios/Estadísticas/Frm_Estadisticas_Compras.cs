using CLASE05.Clases;
using CLASE05.Negocios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Estadísticas
{
    public partial class Frm_Estadisticas_Compras : CLASE05.Formularios.FrmBASE.FrmBase
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        NE_Compras compra = new NE_Compras();
        public Frm_Estadisticas_Compras()
        {
            InitializeComponent();
        }

        private void btn_cargarVentasClientes_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Estadisticas_Compras_Load(object sender, EventArgs e)
        {

            this.rv_comprasArticulos.RefreshReport();
        }

        private void btn_cargarComprasArticulos_Click(object sender, EventArgs e)
        {
            //VALIDAR FECHAS
            if (_TE.ValidarFecha(txt_fechaDesde_articulos.Text) == TratamientosEspeciales.RespuestaValidacion.Error)
            {
                MessageBox.Show("Fecha Desde inválida", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (_TE.ValidarFecha(txt_fechaHasta_articulos.Text) == TratamientosEspeciales.RespuestaValidacion.Error)
            {
                MessageBox.Show("Fecha Hasta inválida", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DateTime.Parse(txt_fechaDesde_articulos.Text) >= DateTime.Parse(txt_fechaHasta_articulos.Text))
            {
                MessageBox.Show("La fecha desde debe ser anterior a la fecha hasta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ReportDataSource datos = new ReportDataSource("DataSet1", compra.Estadisticas_Compras_Articulos(txt_fechaDesde_articulos.Text , txt_fechaHasta_articulos.Text));
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("fechaDesde", txt_fechaDesde_articulos.Text);
            parametro[1] = new ReportParameter("fechaHasta", txt_fechaHasta_articulos.Text);
            this.rv_comprasArticulos.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Estadisticas.Compras.Compras_Articulos_Periodo.rdlc";
            this.rv_comprasArticulos.LocalReport.SetParameters(parametro);
            this.rv_comprasArticulos.LocalReport.DataSources.Clear();
            this.rv_comprasArticulos.LocalReport.DataSources.Add(datos);
            this.rv_comprasArticulos.RefreshReport();
        }

        private void btn_cargarComprasProveedores_Click(object sender, EventArgs e)
        {
            if (_TE.ValidarFecha(txt_fechaDesde_proveedor.Text) == TratamientosEspeciales.RespuestaValidacion.Error)
            {
                MessageBox.Show("Fecha Desde inválida", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (_TE.ValidarFecha(txt_fechaHasta_proveedor.Text) == TratamientosEspeciales.RespuestaValidacion.Error)
            {
                MessageBox.Show("Fecha Hasta inválida", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DateTime.Parse(txt_fechaDesde_proveedor.Text) >= DateTime.Parse(txt_fechaHasta_proveedor.Text))
            {
                MessageBox.Show("La fecha desde debe ser anterior a la fecha hasta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ReportDataSource datos = new ReportDataSource("DataSet1", compra.Estadisticas_Compras_Proveedores(txt_fechaDesde_proveedor.Text, txt_fechaHasta_proveedor.Text));
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("fechaDesde", txt_fechaDesde_proveedor.Text);
            parametro[1] = new ReportParameter("fechaHasta", txt_fechaHasta_proveedor.Text);
            this.rv_comprasProveedor.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Estadisticas.Compras.Compras_Proveedores_Periodo.rdlc";
            this.rv_comprasProveedor.LocalReport.SetParameters(parametro);
            this.rv_comprasProveedor.LocalReport.DataSources.Clear();
            this.rv_comprasProveedor.LocalReport.DataSources.Add(datos);
            this.rv_comprasProveedor.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_año._Text == "")
            {
                MessageBox.Show("Completar año", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ReportDataSource datos = new ReportDataSource("DataSet1", compra.Estadisticas_Compras_año(txt_año._Text));
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("año", txt_año._Text);
            this.rv_comprasMes.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Estadisticas.Compras.Compras_Mes.rdlc";
            this.rv_comprasMes.LocalReport.SetParameters(parametro);
            this.rv_comprasMes.LocalReport.DataSources.Clear();
            this.rv_comprasMes.LocalReport.DataSources.Add(datos);
            this.rv_comprasMes.RefreshReport();
        }
    }
}
