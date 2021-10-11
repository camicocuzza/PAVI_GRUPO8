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
        public enum ResultadoBusqueda { encontre, no_encontre }

        public string precio_articulo { get; set; }
        public Frm_SistemaCompras_Alta()
        {
            InitializeComponent();
        }

        private void Frm_SistemaCompras_Alta_Load(object sender, EventArgs e)
        {
            TratamientosEspeciales TE = new TratamientosEspeciales();
            cmb_proveedor._Cargar();
            txt_fecha._Text = TE.RecuperarFechaSistema();
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
            if(cmb_articulo.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txt_cantidad._Text == "")
            {
                MessageBox.Show("Complete la cantidad", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AgregarFilaGrilla();
            cmb_proveedor.Enabled = false;
            

        }

        private void AgregarFilaGrilla()
        {
            if(BuscarArticulo(cmb_articulo.SelectedValue.ToString())== ResultadoBusqueda.encontre)
            {
                MessageBox.Show("Este artículo ya está cargado");
                return;
            }
            precio_articulo = articulo.BuscarPrecio(cmb_articulo.SelectedValue.ToString());
            grid_articulos.Rows.Add(cmb_articulo.SelectedValue.ToString(), cmb_articulo.Text, precio_articulo, txt_cantidad._Text);
        }

        private ResultadoBusqueda BuscarArticulo(string id_articulo)
        {
            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                if (grid_articulos.Rows[i].Cells[0].Value.ToString()==id_articulo)
                {
                    return ResultadoBusqueda.encontre;
                }
            }
            return ResultadoBusqueda.no_encontre;
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
