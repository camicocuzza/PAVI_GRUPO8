using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CLASE05.Negocios;
using CLASE05.Clases;

namespace CLASE05.Formularios.Estadísticas
{
    public partial class Frm_Estadisticas_Ventas : CLASE05.Formularios.FrmBASE.FrmBase
    {
        NE_Facturas ne_factura = new NE_Facturas();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public Frm_Estadisticas_Ventas()
        {
            InitializeComponent();
        }

        private void Frm_Estadisticas_Ventas_Load(object sender, EventArgs e)
        {
            this._FormularioMovil = true;
        }

        private void btn_cargarVentasArticulos_Click(object sender, EventArgs e)
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

            ReportDataSource reporteVentas;

            reporteVentas = new ReportDataSource("Datos_Estadisticas_Ventas", ne_factura.Estadisticas_Ventas_Articulos(txt_fechaDesde_articulos.Text, txt_fechaHasta_articulos.Text));

            IList<ReportParameter> parametros = new List<ReportParameter>
            {
                new ReportParameter("fechaDesde",txt_fechaDesde_articulos.Text),
                new ReportParameter("fechaHasta", txt_fechaHasta_articulos.Text)
            };
            this.rv_ventasArticulos.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Estadisticas.Ventas.Ventas_Articulos_Periodo.rdlc";
            this.rv_ventasArticulos.LocalReport.DataSources.Clear();
            this.rv_ventasArticulos.LocalReport.DataSources.Add(reporteVentas);
            this.rv_ventasArticulos.LocalReport.SetParameters(parametros);
            this.rv_ventasArticulos.RefreshReport();
        }

        private void btn_cargarVentasClientes_Click(object sender, EventArgs e)
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

            ReportDataSource reporteVentas;

            reporteVentas = new ReportDataSource("Datos_Estadisticas_Ventas", ne_factura.Estadisticas_Ventas_Articulos(txt_fechaDesde_articulos.Text, txt_fechaHasta_articulos.Text));

            IList<ReportParameter> parametros = new List<ReportParameter>
            {
                new ReportParameter("fechaDesde",txt_fechaDesde_articulos.Text),
                new ReportParameter("fechaHasta", txt_fechaHasta_articulos.Text)
            };
            this.rv_ventasClientes.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Estadisticas.Ventas.Ventas_Clientes_Periodo.rdlc";
            this.rv_ventasClientes.LocalReport.DataSources.Clear();
            this.rv_ventasClientes.LocalReport.DataSources.Add(reporteVentas);
            this.rv_ventasClientes.LocalReport.SetParameters(parametros);
            this.rv_ventasClientes.RefreshReport();
        }
    }
}