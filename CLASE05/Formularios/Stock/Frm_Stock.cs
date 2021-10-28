using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;
using CLASE05.Clases;

namespace CLASE05.Formularios.Stock
{
    public partial class Frm_Stock : CLASE05.Formularios.FrmBASE.FrmBase
    {
        NE_Stock ne_stockArt = new NE_Stock();
        NE_Stock_Ensamblados ne_stockEns = new NE_Stock_Ensamblados();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
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
                grid_stock_articulos.Cargar(ne_stockArt.BuscarGrilla("", "s.cod_articulo"));
                return;
            }
           
            if (rb_fecha_articulo.Checked == true)
            {
                if (txt_patron_art.Text == string.Empty)
                {
                    MessageBox.Show("Falta completar la fecha", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if(_TE.ValidarFecha(txt_patron_art.Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                {
                    MessageBox.Show("Fecha ínválida", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string[] f = txt_patron_art.Text.Split('/');

                string fecha_buscar = f[2] + "-" + f[1] + "-" + f[0];

                grid_stock_articulos.Cargar(ne_stockArt.BuscarPorFecha(fecha_buscar));
                if (grid_stock_articulos.Rows.Count == 0)
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_patron_art.Text != string.Empty)
            {
                if (rb_cod_articulo.Checked == true)
                {
                    grid_stock_articulos.Cargar(ne_stockArt.BuscarPorCodigo(txt_patron_art.Text));
                    return;
                }
                if (rb_n_articulo.Checked == true)
                    columna = "a.nombre";
                if (rb_fecha_articulo.Checked == true)
                    columna = "s.fecha";

                grid_stock_articulos.Cargar(ne_stockArt.BuscarGrilla(txt_patron_art.Text, columna));
                if (grid_stock_articulos.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún registro de stock", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btn_buscar_ens_Click(object sender, EventArgs e)
        {
            string columna = "";

            if (rb_todos_ensamblado.Checked == true)
            {
                grid_stock_ensamblados.Cargar(ne_stockEns.BuscarGrilla("", "s.cod_prod_ensamblado"));
                return;
            }
            
            if (rb_fecha_ensamblado.Checked == true)
            {
                if (txt_patron_ens.Text == string.Empty)
                {
                    MessageBox.Show("Falta completar la fecha", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (_TE.ValidarFecha(txt_patron_ens.Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                {
                    MessageBox.Show("Fecha ínválida", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string[] f = txt_patron_ens.Text.Split('/');

                string fecha_buscar = f[2] + "-" + f[1] + "-" + f[0];

                grid_stock_ensamblados.Cargar(ne_stockEns.BuscarPorFecha(fecha_buscar));
                if (grid_stock_ensamblados.Rows.Count == 0)
                    MessageBox.Show("Búsqueda sin resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_patron_ens.Text != string.Empty)
            {
                if (rb_codigo_ensamblado.Checked == true)
                {
                    grid_stock_ensamblados.Cargar(ne_stockEns.BuscarPorCodigo(txt_patron_ens.Text));
                    return;
                }
                if (rb_n_ensamblado.Checked == true)
                    columna = "e.nombre";
                if (rb_fecha_ensamblado.Checked == true)
                    columna = "s.fecha";

                grid_stock_ensamblados.Cargar(ne_stockEns.BuscarGrilla(txt_patron_ens.Text, columna));
                if (grid_stock_ensamblados.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún registro de stock", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btn_blan_art_Click(object sender, EventArgs e)
        {
            this.txt_patron_art.Text = string.Empty;
        }

        private void btn_blan_ens_Click(object sender, EventArgs e)
        {
            this.txt_patron_ens.Text = string.Empty;
        }        


    }
}
