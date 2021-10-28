using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Stock
{
    public partial class Frm_Stock : CLASE05.Formularios.FrmBASE.FrmBase
    {
        NE_Stock ne_stockArt = new NE_Stock();
        NE_Stock_Ensamblados ne_stockEns = new NE_Stock_Ensamblados();
        public Frm_Stock()
        {
            InitializeComponent();
        }

        private void Frm_Stock_Load(object sender, EventArgs e)
        {
            this.grid_stock_articulos.Formatear("Código, 75, C; Nombre, 170, I; Cantidad, 75, I; Fecha, 150, I");
            this.grid_stock_ensamblados.Formatear("Código, 75, C; Nombre, 170, I; Cantidad, 75, I; Fecha, 150, I");
        }

        private void btn_buscar_articulos_Click(object sender, EventArgs e)
        {
            string columna = "";

            if (rb_todos_articulo.Checked == true)
            {
                grid_stock_articulos.Cargar(ne_stockArt.grid_StockArticulos("", "cod_articulo"));
                return;
            }
            if (txt_patron_art.Text != string.Empty)
            {
                if (rb_cod_articulo.Checked == true)
                    columna = "cod_articulo";
                if (rb_n_articulo.Checked == true)
                    columna = "nombre";
                if (rb_fecha_articulo.Checked == true)
                    columna = "fecha";

                grid_stock_articulos.Cargar(ne_stockArt.grid_StockArticulos(txt_patron_art.Text, columna));
                if (grid_stock_articulos.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún registro de stock", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btn_buscar_ens_Click(object sender, EventArgs e)
        {

        }
        private void btn_blan_art_Click(object sender, EventArgs e)
        {

        }

        private void btn_blan_ens_Click(object sender, EventArgs e)
        {

        }

        
    }
}
