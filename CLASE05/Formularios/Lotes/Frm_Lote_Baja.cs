using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Lotes
{
    public partial class Frm_Lote_Baja : CLASE05.Formularios.Lotes.Frm_Lote
    {
        public Frm_Lote_Baja()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Lotes lote = new NE_Lotes();

                lote.num_lote = txt_n_lote._Text;

                if (MessageBox.Show("¿Está seguro de que desea eliminar el lote " + txt_n_lote._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lote.Borrar();
                    MessageBox.Show("Se eliminó correctamente el lote " + txt_n_lote._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            }
        }

        private void Frm_Lote_Baja_Load(object sender, EventArgs e)
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
    }
}
