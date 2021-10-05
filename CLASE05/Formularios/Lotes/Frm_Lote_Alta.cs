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
    public partial class Frm_Lote_Alta : CLASE05.Formularios.Lotes.Frm_Lote
    {
        public Frm_Lote_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            
            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {

                if (_TE.ValidarFecha1(txt_fecha_compra._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                {
                    MessageBox.Show("La fecha es inválida");
                    txt_fecha_compra.Focus();
                    return;
                }

                NE_Lotes lote = new NE_Lotes();

                lote.num_lote = txt_n_lote._Text.ToString();
                lote.nro_remito_proveedor = txt_n_remito._Text.ToString();
                lote.fecha_compra = txt_fecha_compra._Text.ToString();                

                lote.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }
    }
}
