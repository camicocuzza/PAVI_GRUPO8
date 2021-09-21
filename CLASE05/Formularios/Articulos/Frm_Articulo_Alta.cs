using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Articulos
{
    public partial class Frm_Articulo_Alta : CLASE05.Formularios.Articulos.Frm_Articulo
    {
        public Frm_Articulo_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                
                if (_TE.ValidarFecha1(txt_plazo_pago._Text)== TratamientosEspeciales.RespuestaValidacion.Error)
                {
                    MessageBox.Show("La fecha es inválida");
                    txt_plazo_pago.Focus();
                    return;
                }

                // GRABAR NUEVO REGISTRO
                NE_Articulos articulo = new NE_Articulos();
                
                articulo.cod_articulo = txt_cod_articulo._Text;
                articulo.num_serie = txt_num_serie._Text.ToString();
                articulo.num_lote = cmb_lote.SelectedValue.ToString();
                articulo.precio = txt_precio._Text;
                articulo.tiempo_envio = txt_tiempo_envio._Text;
                articulo.plazo_pago = txt_plazo_pago._Text.ToString();
                articulo.nombre = txt_nombre._Text;
                articulo.id_rubro = cmb_rubros.SelectedValue.ToString();
                articulo.id_pais = cmb_paises.SelectedValue.ToString();
                articulo.cuit_proveedor = cmb_proveedor.SelectedValue.ToString();

                articulo.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }

        private void txt_plazo_pago_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_Articulo_Alta_Load(object sender, EventArgs e)
        {

        }
    }
}
