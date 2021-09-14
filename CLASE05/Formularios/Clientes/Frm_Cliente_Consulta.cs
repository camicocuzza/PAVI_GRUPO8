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
    public partial class Frm_Cliente_Consulta : CLASE05.Formularios.Clientes.Frm_e
    {
        public Frm_Cliente_Consulta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Cliente_Consulta_Load(object sender, EventArgs e)
        {
            NE_Clientes cli = new NE_Clientes();
            CargarFormulario(cli.RecuperarCliente(cuit_cliente));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_cuit_cliente.Text = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_razon_social._Text = tabla.Rows[0]["razon_social"].ToString();
            txt_limite_credito.Text = tabla.Rows[0]["limite_credito"].ToString();
            txt_nombre_contacto._Text = tabla.Rows[0]["nombre_contacto"].ToString();
            txt_legajo_empleado._Text = tabla.Rows[0]["legajo_empleado"].ToString();
            txt_direccion._Text = tabla.Rows[0]["direccion"].ToString();
            //cmb_pais.SelectedValue = int.Parse(tabla.Rows[0]["id_pais"].ToString());
            cmb_estado_provincia.SelectedValue = int.Parse(tabla.Rows[0]["id_estado_provincia"].ToString());
            txt_ciudad._Text = tabla.Rows[0]["ciudad"].ToString();

            //NE_estados_provincias ne_prov = new NE_estados_provincias();
            //NE_pais ne_pais = new NE_pais();
            //int id_estado_provincia = int.Parse(tabla.Rows[0]["id_estado_provincia"].ToString());

            //int id_pais = ne_prov.ObtenerIdPais();
            //cmb_pais.SelectedValue = id_pais.ToString());            
        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}