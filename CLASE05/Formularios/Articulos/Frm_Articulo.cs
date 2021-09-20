using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Articulos
{
    public partial class Frm_Articulo : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        { 
            get { return lbl_titulo.Text; } set { lbl_titulo.Text = value; } 
        }

        public string cod_articulo { get; set; }
        
        public Frm_Articulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Articulo_Load(object sender, EventArgs e)
        {
            cmb_paises._Cargar();
            cmb_rubros._Cargar();
            cmb_proveedor._Cargar();
            cmb_lote._Cargar();


        }
    }
}
