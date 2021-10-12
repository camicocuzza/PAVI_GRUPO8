using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Compras
{
    public partial class Frm_SistemaCompras_Baja : CLASE05.Formularios.Compras.Frm_SistemaCompras
    {
        public Frm_SistemaCompras_Baja()
        {
            InitializeComponent();
        }

        private void Frm_SistemaCompras_Baja_Load(object sender, EventArgs e)
        {
            DataTable tabla_compra = compra.RecuperarCompra(num_compra);
            CargarFormulario(proveedor.RecuperarProveedor(tabla_compra.Rows[0]["cuit_proveedor"].ToString()), tabla_compra);
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar la compra "+ num_compra + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                compra.BorrarCompra(num_compra, txt_fecha._Text, grid_articulos);
                this.Dispose();
            }
            else
                MessageBox.Show("Eliminación cancelada");

        }
    }
}
