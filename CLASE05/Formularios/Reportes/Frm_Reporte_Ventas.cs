using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Reportes.Ventas;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Reportes
{
    public partial class Frm_Reporte_Ventas : CLASE05.Formularios.FrmBASE.FrmBase
    {
        NE_Facturas ne_factura = new NE_Facturas();        
        public Frm_Reporte_Ventas()
        {
            InitializeComponent();
        }
        private void Frm_Reporte_Ventas_Load(object sender, EventArgs e)
        {
            cmb_clientes._Cargar();
        }

        private void btn_cargarVentasFecha_Click(object sender, EventArgs e)
        {
            int mes = cmb_mes.SelectedIndex + 1;
            int año = cmb_año.SelectedIndex + 2010;
            ReportDataSource reporteVentas = new ReportDataSource("Datos_Reporte_Ventas", ne_factura.DataSourceReporte_Ventas_Fecha(mes.ToString(), año.ToString()));
           
            IList<ReportParameter> parametros = new List<ReportParameter>
            {
                new ReportParameter("mes", mes.ToString()),
                new ReportParameter("año", año.ToString())
            };
            this.rv_ventasFecha.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Ventas.Reporte_Ventas_Fecha.rdlc";
            this.rv_ventasFecha.LocalReport.DataSources.Clear();
            this.rv_ventasFecha.LocalReport.DataSources.Add(reporteVentas);
            this.rv_ventasFecha.LocalReport.SetParameters(parametros);
            this.rv_ventasFecha.RefreshReport();
        }

        private void btn_cargarVentasCliente_Click(object sender, EventArgs e)
        {
            ReportDataSource reporteVentas = new ReportDataSource("Datos_Reporte_Ventas", ne_factura.DataSourceReporte_Ventas_Cliente(cmb_clientes.SelectedValue.ToString()));
            IList<ReportParameter> parametros = new List<ReportParameter>
            {
                new ReportParameter("cuit_cliente", cmb_clientes.SelectedValue.ToString())
            };
            this.rv_ventasFecha.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Ventas.Reporte_Ventas_Cliente.rdlc";
            this.rv_ventasFecha.LocalReport.DataSources.Clear();
            this.rv_ventasFecha.LocalReport.DataSources.Add(reporteVentas);
            this.rv_ventasFecha.LocalReport.SetParameters(parametros);
            this.rv_ventasFecha.RefreshReport();
        }
    }
}
