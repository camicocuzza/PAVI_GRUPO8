using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.EquiposEnsamblados
{
    
    public partial class Frm_EquiposEnsamblados : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }

        public string cod_prod_ensamblado { get; set; }
        public Frm_EquiposEnsamblados()
        {
            InitializeComponent();
           
        }

        private void Frm_EquiposEnsamblados_Load(object sender, EventArgs e)
        {

        }

        private void txt_precio_Click(object sender, EventArgs e)
        {
      
        }
    }
}
