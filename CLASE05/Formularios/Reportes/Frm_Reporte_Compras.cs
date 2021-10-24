using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Reportes
{
    public partial class Frm_Reporte_Compras : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Reporte_Compras()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Compras_Load(object sender, EventArgs e)
        {
            cmb_proveedores._Cargar();
            this.rv01.RefreshReport();
            this._FormularioMovil = true;
        }

        private void btn_cargarComprasFecha_Click(object sender, EventArgs e)
        {
            
            if (txt_año._Text == "")
            {
                MessageBox.Show("Complete el año", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            NE_Compras compra = new NE_Compras();
            ReportDataSource datos;

            if (txt_mes._Text == "")
            {
                datos = new ReportDataSource("DataSet1", compra.BuscarCompra_x_Año(txt_año._Text));
            
            }
            else
            {
                datos = new ReportDataSource("DataSet1", compra.BuscarCompra_x_mesAño(txt_mes._Text, txt_año._Text));

            }
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("año", txt_año._Text);
            parametro[1] = new ReportParameter("mes", txt_mes._Text);
            this.rv01.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Compras.Reporte_Compras_Fecha.rdlc";
            this.rv01.LocalReport.SetParameters(parametro);
            this.rv01.LocalReport.DataSources.Clear();
            this.rv01.LocalReport.DataSources.Add(datos);
            this.rv01.RefreshReport();
        }

        private void btn_cargarComprasProveedor_Click(object sender, EventArgs e)
        {
            if (cmb_proveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar cliente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            NE_Compras compra = new NE_Compras();
            ReportDataSource datos = new ReportDataSource("DataSet1", compra.BuscarCompra_x_proveedor(cmb_proveedores.SelectedValue.ToString()));
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("cuit_proveedor", cmb_proveedores.SelectedValue.ToString());
            parametro[1] = new ReportParameter("razon_social", cmb_proveedores.Text);
            this.rv02.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Compras.Reporte_Compras_Proveedor.rdlc";
            this.rv02.LocalReport.SetParameters(parametro);
            this.rv02.LocalReport.DataSources.Clear();
            this.rv02.LocalReport.DataSources.Add(datos);
            this.rv02.RefreshReport();
        }
    }
}
