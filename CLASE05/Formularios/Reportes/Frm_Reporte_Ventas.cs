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
        public string mes;
        public string año;
        public string cuit_cliente;
        public IList<string> parametros = new List<string>();
        public Frm_Reporte_Ventas()
        {
            InitializeComponent();
        }
        public Frm_Reporte_Ventas(string año, string mes, IList<string> parametros)
        {
            this.año = año;
            this.mes = mes;
            this.parametros = parametros;
            InitializeComponent();
        }
        public Frm_Reporte_Ventas(string cuit_cliente, IList<string> parametros)
        {
            this.cuit_cliente = cuit_cliente;
            this.parametros = parametros;
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Reporte_Ventas_Load(object sender, EventArgs e)
        {
            ReportDataSource reporteArt = new ReportDataSource("DataFacturaArt", ne_factura.DataSourceArt(num_factura));
            ReportDataSource reporteEns = new ReportDataSource("DataFacturaEns", ne_factura.DataSourceEns(num_factura));
            IList<ReportParameter> param = new List<ReportParameter>
            {

                new ReportParameter("fecha", parametros[0].ToString()),
                new ReportParameter("cuit_cliente", parametros[1].ToString()),
                new ReportParameter("razon_social", parametros[2].ToString()),
                new ReportParameter("estado_provincia", parametros[3].ToString()),
                new ReportParameter("pais", parametros[4].ToString()),
                new ReportParameter("num_factura", parametros[5].ToString()),
                new ReportParameter("domicilio", parametros[6].ToString()),
                new ReportParameter("monto_total", parametros[7].ToString()),
                new ReportParameter("ciudad", parametros[8].ToString())
            };
            this.rv_ventasFecha.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Ventas.VentaFactura.rdlc";
            this.rv_ventasFecha.LocalReport.DataSources.Clear();
            this.rv_ventasFecha.LocalReport.DataSources.Add(reporteArt);
            this.rv_ventasFecha.LocalReport.DataSources.Add(reporteEns);
            this.rv_ventasFecha.LocalReport.SetParameters(param);
            this.rv_ventasFecha.RefreshReport();
        }

    }
}
