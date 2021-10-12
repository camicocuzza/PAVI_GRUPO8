using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;
using CLASE05.Formularios.Articulos;

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
        public string num_compra { get; set; }
        public Frm_SistemaCompras()
        {
            InitializeComponent();
        }

        private void Frm_SistemaCompras_Load(object sender, EventArgs e)
        {
            grid_articulos.Formatear("Código Artículo, 70, C; Nombre, 201, C; Precio, 82, D; Cantidad, 82, D");
            txt_total.Text = "$0";
            cmb_proveedor._Cargar();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (grid_articulos.Rows.Count == 0)
            {
                MessageBox.Show("No hay artículos agregados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_articulos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Articulo_Consulta frm_articulo = new Frm_Articulo_Consulta();
            frm_articulo.cod_articulo = grid_articulos.CurrentRow.Cells[0].Value.ToString();
            frm_articulo.ShowDialog();
        }
        public void CargarFormulario(DataTable tabla_proveedor, DataTable tabla_compra)
        {
            txt_fecha._Text = tabla_compra.Rows[0]["fecha"].ToString();
            cmb_proveedor.SelectedValue = double.Parse(tabla_compra.Rows[0]["cuit_proveedor"].ToString());
            txt_cuit_p._Text = tabla_compra.Rows[0]["cuit_proveedor"].ToString();
            txt_fecha_inicio._Text = tabla_proveedor.Rows[0]["fecha_inicio_operacion"].ToString();
            txt_direccion._Text = tabla_proveedor.Rows[0]["direccion"].ToString();
            txt_total.Text = tabla_compra.Rows[0]["monto_total"].ToString();

            DataTable detalles_compra = compra.BuscarDetalleCompra(num_compra);

            for(int i = 0; i < detalles_compra.Rows.Count; i++)
            {
                grid_articulos.Rows.Add(detalles_compra.Rows[0]["cod_articulo"].ToString()
                    , articulo.RecuperarNombreArticulo(detalles_compra.Rows[0]["cod_articulo"].ToString())
                    , detalles_compra.Rows[0]["precio"].ToString()
                    , detalles_compra.Rows[0]["cantidad"].ToString());
            }
            

        }
    }
}
