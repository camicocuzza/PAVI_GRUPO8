using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Formularios.Estadísticas;

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

        private void btn_est_ventas_Click(object sender, EventArgs e)
        {
            Frm_Estadisticas_Ventas frm_estadisticas_ventas = new Frm_Estadisticas_Ventas();
            frm_estadisticas_ventas.Show();
       
        }

        private void btn_est_compras_Click(object sender, EventArgs e)
        {
            Frm_Estadisticas_Compras frm_estadisticas_compras = new Frm_Estadisticas_Compras();
            frm_estadisticas_compras.Show();
        }
    }
}
