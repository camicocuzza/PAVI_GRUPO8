using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Informes.Reportes.Ventas;
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
            cargarComboAño();
            this._FormularioMovil = true;
        }

        private void cargarComboAño()
        {
            cmb_año.DisplayMember = "Text";
            cmb_año.ValueMember = "Value";
            int val = 0;
            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                cmb_año.Items.Add(new { Text = i.ToString(), Value=val.ToString() });
                val++;
            }
        }
        private void btn_cargarVentasFecha_Click(object sender, EventArgs e)
        {
            if (cmb_año.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar año", "Importante");
                return;
            }            
            int mes = cmb_mes.SelectedIndex + 1;
            int año = int.Parse(cmb_año.Text);
            ReportDataSource reporteVentas;

            if (cmb_mes.SelectedIndex == -1)
            {
                reporteVentas = new ReportDataSource("Datos_Reporte_Ventas", ne_factura.DataSourceReporte_Ventas_Año(año.ToString()));
            }
            else
            {
                 reporteVentas = new ReportDataSource("Datos_Reporte_Ventas", ne_factura.DataSourceReporte_Ventas_Fecha(mes.ToString(), año.ToString()));
            }                
           
            IList<ReportParameter> parametros = new List<ReportParameter>
            {
                new ReportParameter("mes", mes.ToString()),
                new ReportParameter("año", año.ToString())
            };
            this.rv_ventasFecha.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Reportes.Ventas.Reporte_Ventas_Fecha.rdlc";
            this.rv_ventasFecha.LocalReport.DataSources.Clear();
            this.rv_ventasFecha.LocalReport.DataSources.Add(reporteVentas);
            this.rv_ventasFecha.LocalReport.SetParameters(parametros);
            this.rv_ventasFecha.RefreshReport();
        }

        private void btn_cargarVentasCliente_Click(object sender, EventArgs e)
        {
            if(cmb_clientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar cliente", "Importante");
                return;
            }
            ReportDataSource reporteVentas = new ReportDataSource("Datos_Reporte_Ventas", ne_factura.DataSourceReporte_Ventas_Cliente(cmb_clientes.SelectedValue.ToString()));
            IList<ReportParameter> parametros = new List<ReportParameter>
            {
                new ReportParameter("cuit_cliente", cmb_clientes.SelectedValue.ToString()),
                new ReportParameter("razon_social", cmb_clientes.Text)
            };
            this.rv_ventasCliente.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Reportes.Ventas.Reporte_Ventas_Cliente.rdlc";
            this.rv_ventasCliente.LocalReport.DataSources.Clear();
            this.rv_ventasCliente.LocalReport.DataSources.Add(reporteVentas);
            this.rv_ventasCliente.LocalReport.SetParameters(parametros);
            this.rv_ventasCliente.RefreshReport();
        }
    }
}
