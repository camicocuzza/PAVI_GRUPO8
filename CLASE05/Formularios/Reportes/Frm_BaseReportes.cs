using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Reportes
{
    public partial class Frm_BaseReportes : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_BaseReportes()
        {
            InitializeComponent();
        }

        private void btn_rpt_compras_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Compras frm_reporte_compras = new Frm_Reporte_Compras();
            frm_reporte_compras.Show();
        }

        private void btn_rpt_ventas_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Ventas frm_reporte_ventas = new Frm_Reporte_Ventas();
            frm_reporte_ventas.Show();
        }
    }
}
