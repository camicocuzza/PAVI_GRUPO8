using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Clientes
{
    public partial class Frm_Cliente : CLASE05.Formularios.FrmBASE.FrmBase_Datos
    {
        int contador = 0;
        NE_Clientes cli = new NE_Clientes();
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }
        public string cuit_cliente { get; set; }
        public Frm_Cliente()
        {
            InitializeComponent();
        }
        private void Frm_Cliente_Load(object sender, EventArgs e)
        {            
        }
        private void cmb_estado_provincia_Click(object sender, EventArgs e)
        {

        }
        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            contador += 1;

            if (cmb_pais.SelectedIndex != -1 & contador > 2)
            {
                cmb_estado_provincia._CargarConJoin(int.Parse(cmb_pais.SelectedValue.ToString()));
            }
        }
        private void txt_cuit_cliente_Click(object sender, EventArgs e)
        {
            txt_cuit_cliente.SelectionStart = 0;
        }      
    }
}

        
