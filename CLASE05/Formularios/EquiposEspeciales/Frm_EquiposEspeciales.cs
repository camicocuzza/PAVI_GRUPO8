using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.EquiposEspeciales
{
    public partial class Frm_EquiposEspeciales : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }
        public string cod_prod_ensamblado { get; set; }
        public Frm_EquiposEspeciales()
        {
            InitializeComponent();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
          

        }

        private void Frm_EquiposEspeciales_Load(object sender, EventArgs e)
        {
            cmb_clientes._Cargar();
            cmb_equipos._Cargar();
        }
    }
}
