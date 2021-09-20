using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Lotes
{
    public partial class Frm_Lote_Consulta : CLASE05.Formularios.Lotes.Frm_Lote
    {
        public Frm_Lote_Consulta()
        {
            InitializeComponent();
        }

        private void Frm_Lote_Consulta_Load(object sender, EventArgs e)
        {
            NE_Lotes lote = new NE_Lotes();
            CargarFormulario(lote.RecuperarLote(num_lote));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_n_lote._Text = tabla.Rows[0]["num_lote"].ToString();
            txt_n_remito._Text = tabla.Rows[0]["nro_remito_proveedor"].ToString();
            txt_fecha_compra._Text = tabla.Rows[0]["fecha_compra"].ToString();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
