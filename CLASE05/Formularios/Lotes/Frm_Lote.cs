using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Lotes
{
    public partial class Frm_Lote : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }
        public string num_lote { get; set; }
        public Frm_Lote()
        {
            InitializeComponent();
        }
    }
}
