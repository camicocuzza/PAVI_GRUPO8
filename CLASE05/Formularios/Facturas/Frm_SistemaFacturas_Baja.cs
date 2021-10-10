using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Baja : CLASE05.Formularios.Facturas.Frm_BaseFactura
    {
        public Frm_SistemaFacturas_Baja()
        {
            InitializeComponent();
        }
        private void Frm_SistemaFacturas_Baja_Load(object sender, EventArgs e)
        {
            this.RecuperarDatosFormulario();
        }

        private void btn_eliminar_venta_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Está seguro de que desea eliminar la venta nro " + num_factura + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ne_facturas.BorrarFactura(num_factura, fecha, grid_articulos, grid_ensamblados);                
                this.Dispose();
            }
            else
                MessageBox.Show("Eliminación cancelada");
        }
    }
}
