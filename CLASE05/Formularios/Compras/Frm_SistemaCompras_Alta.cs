using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Compras
{
    public partial class Frm_SistemaCompras_Alta : CLASE05.Formularios.Compras.Frm_SistemaCompras
    {
        public Frm_SistemaCompras_Alta()
        {
            InitializeComponent();
        }

        private void Frm_SistemaCompras_Alta_Load(object sender, EventArgs e)
        {
            cmb_proveedor._Cargar();
        }

        private void cmb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_proveedor.SelectedIndex != -1)
            {
                CargarProveedor(proveedor.RecuperarProveedor(cmb_proveedor.SelectedValue.ToString()));
                cmb_articulo.SelectedIndex = -1;
                articulo.CargarComboXProveedor(ref cmb_articulo, cmb_proveedor.SelectedValue.ToString());

            }
            else
            {
                txt_cuit_p._Text = "";
                txt_fecha_inicio._Text = "";
                txt_direccion._Text = "";
            }
           
        }
        private void CargarProveedor(DataTable tabla)
        {
            txt_cuit_p._Text = tabla.Rows[0]["cuit_proveedor"].ToString();
            txt_fecha_inicio._Text = tabla.Rows[0]["fecha_inicio_operacion"].ToString();
            txt_direccion._Text = tabla.Rows[0]["direccion"].ToString();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_nueva_compra_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item.GetType().Name=="LabelText02")
                {
                    ((LabelText02)item)._Text = "";
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    ((ComboBox01)item).SelectedValue = -1;
                }
                if (item.GetType().Name == "Grid01")
                {
                    ((Grid01)item).Rows.Clear();
                }
            }
        }
    }
}
