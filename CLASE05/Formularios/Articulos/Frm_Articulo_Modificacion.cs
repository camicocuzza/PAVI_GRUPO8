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
    public partial class Frm_Articulo_Modificacion : CLASE05.Formularios.Articulos.Frm_Articulo
    {
        public Frm_Articulo_Modificacion()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {

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

                articulo.Modificar();
                MessageBox.Show("Se modificó correctamente el artículo " + txt_nombre._Text, "Importante");
            }
        }

        private void Frm_Articulo_Modificacion_Load(object sender, EventArgs e)
        {
            NE_Articulos articulo = new NE_Articulos();
            CargarFormulario(articulo.RecuperarArticulo(cod_articulo));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_cod_articulo._Text = tabla.Rows[0]["cod_articulo"].ToString();
            txt_num_serie._Text = tabla.Rows[0]["num_serie"].ToString();
            cmb_lote.SelectedValue = tabla.Rows[0]["num_lote"].ToString();
            txt_precio._Text = tabla.Rows[0]["precio"].ToString();
            txt_tiempo_envio._Text = tabla.Rows[0]["tiempo_envio"].ToString();
            txt_plazo_pago._Text = tabla.Rows[0]["plazo_pago"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
            cmb_rubros.SelectedValue = int.Parse(tabla.Rows[0]["id_rubro"].ToString());
            cmb_paises.SelectedValue = int.Parse(tabla.Rows[0]["id_pais"].ToString());
            cmb_proveedor.SelectedValue = tabla.Rows[0]["cuit_proveedor"].ToString();

        }
    }
    }
