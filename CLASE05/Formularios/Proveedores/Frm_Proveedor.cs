using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Proveedores
{
    public partial class Frm_Proveedor : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }

        public string cuit_proveedor { get; set; }
        public Frm_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Proveedor_Load(object sender, EventArgs e)
        {
            cmb_empleado._Cargar();
            cmb_estado_provincia._Cargar();
        }
    }
}
