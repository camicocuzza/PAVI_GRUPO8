using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Consulta : CLASE05.Formularios.Facturas.Frm_BaseFactura
    {
        public Frm_SistemaFacturas_Consulta()
        {
            InitializeComponent();
        }

        private void Frm_SistemaFacturas_Consulta_Load(object sender, EventArgs e)
        {
            this.RecuperarDatosFormulario();
        }
    }
}
