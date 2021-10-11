using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Compras
{
    public partial class Frm_SistemaCompras : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public NE_Proveedores proveedor = new NE_Proveedores();
        public NE_Articulos articulo = new NE_Articulos();
        public NE_Compras compra = new NE_Compras();
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }

        public Frm_SistemaCompras()
        {
            InitializeComponent();
        }

        private void Frm_SistemaCompras_Load(object sender, EventArgs e)
        {
            grid_articulos.Formatear("Código Artículo, 70, C; Nombre, 201, C; Precio, 82, D; Cantidad, 82, D");
            txt_total.Text = "$0";
        }

        public void CalcularTotal()
        {
            double sumarArticulos = 0;

            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                sumarArticulos += double.Parse(grid_articulos.Rows[i].Cells[2].Value.ToString().Replace(".", ","))
                * double.Parse(grid_articulos.Rows[i].Cells[3].Value.ToString().Replace(".", ","));
            }
            
            txt_total.Text = "$" + (sumarArticulos).ToString();
        }

        private void btn_eliminar_a_Click(object sender, EventArgs e)
        {
            
        }
    }
}
