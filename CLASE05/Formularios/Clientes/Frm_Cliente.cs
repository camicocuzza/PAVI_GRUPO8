using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Clientes
{
    public partial class Frm_Cliente : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void txt_limite_credito_Click(object sender, EventArgs e)
        {
            txt_limite_credito.SelectionStart = txt_limite_credito.Text.Length;
        }
    }
}
