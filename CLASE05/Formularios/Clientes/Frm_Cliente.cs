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
            cmb_pais._Cargar();
            cmb_estado_provincia._Cargar();
        }

        private void cmb_estado_provincia_Click(object sender, EventArgs e)
        {
            if (cmb_pais.SelectedIndex == -1)
            {
                cmb_estado_provincia._tabla_cargar_combo = "";
                cmb_estado_provincia._tabla_cargar_descriptor = "";
                cmb_estado_provincia._tabla_cargar_pk = "";
            }
        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            contador += 1;

            // MessageBox.Show(cmb_pais.SelectedIndex.ToString() + contador);
            if (cmb_pais.SelectedIndex != -1 & contador > 2)
            {
                cmb_estado_provincia._CargarConJoin(cmb_pais.SelectedIndex);

                //NE_Paises p = NE_Paises;
                //string nombre_pais = cmb_pais.SelectedText;
                //p.RecuperarId(nombre_pais);

                //cmb_estado_provincia._CargarConJoin(p.RecuperarId(nombre_pais);
            }
        }

        private void txt_cuit_cliente_Click(object sender, EventArgs e)
        {
            txt_cuit_cliente.SelectionStart = 0;
        }
        private void txt_limite_credito_Click(object sender, EventArgs e)
        {
            txt_limite_credito.SelectionStart = txt_limite_credito.Text.Length;
        }
    }
}

        
