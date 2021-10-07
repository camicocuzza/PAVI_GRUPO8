using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_SistemaFacturas_Modificacion : CLASE05.Formularios.Facturas.Frm_BaseFactura
    {
        public Frm_SistemaFacturas_Modificacion()
        {
            InitializeComponent();
        }

        private void Frm_SistemaFacturas_Modificacion_Load(object sender, EventArgs e)
        {
            this.RecuperarDatosFormulario();
        }
    }
}
