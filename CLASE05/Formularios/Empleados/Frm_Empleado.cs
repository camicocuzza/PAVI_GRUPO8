using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Empleados
{
    public partial class Frm_Empleado : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }

        public string legajo_empleado { get; set; }
        public Frm_Empleado()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Load(object sender, EventArgs e)
        {
            cmb_estado_provincia._Cargar();
            cmb_tipo_documento._Cargar();

        }
    }
}
