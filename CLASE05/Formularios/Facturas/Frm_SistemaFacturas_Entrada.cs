using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Formularios;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Entrada : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_SistemaFacturas_Entrada()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_SistemaFacturas_Alta frm_altas = new Frm_SistemaFacturas_Alta();
            frm_altas.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_SistemaFacturas_Baja frm_bajas = new Frm_SistemaFacturas_Baja();
            frm_bajas.ShowDialog();
        }
    }
}
