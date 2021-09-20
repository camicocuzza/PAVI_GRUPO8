using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Clientes
{
    public partial class Frm_Cliente_Baja : CLASE05.Formularios.Clientes.Frm_Cliente
    {
        NE_Clientes cli = new NE_Clientes();
        public Frm_Cliente_Baja()
        {
            InitializeComponent();
        }

        private void Frm_Cliente_Baja1_Load(object sender, EventArgs e)
        {
            cmb_pais._Cargar();
            cmb_estado_provincia._Cargar();
            CargarFormulario(cli.RecuperarCliente(cuit_cliente));
        }
        private void CargarFormulario(DataTable tabla)
        {
            NE_Estados_Provincias ne_prov = new NE_Estados_Provincias();
            NE_Paises ne_pais = new NE_Paises();
            string id_estado_provincia = tabla.Rows[0]["id_estado_provincia"].ToString();
            DataTable tabla_IdPais = ne_prov.RecuperarIdPais(id_estado_provincia);
            string id_pais = tabla_IdPais.Rows[0]["id_pais"].ToString();

            txt_cuit_cliente.Text = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_razon_social._Text = tabla.Rows[0]["razon_social"].ToString();
            txt_limite_credito.Text = tabla.Rows[0]["limite_credito"].ToString();
            txt_nombre_contacto._Text = tabla.Rows[0]["nombre_contacto"].ToString();
            txt_legajo_empleado._Text = tabla.Rows[0]["legajo_empleado"].ToString();
            txt_direccion._Text = tabla.Rows[0]["direccion"].ToString();
            cmb_pais.SelectedValue = id_pais.ToString();
            cmb_estado_provincia.SelectedValue = int.Parse(tabla.Rows[0]["id_estado_provincia"].ToString());
            txt_ciudad._Text = tabla.Rows[0]["ciudad"].ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            //if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            //{
                cli.cuit_cliente = txt_cuit_cliente.Text;

                if (MessageBox.Show("¿Está seguro de que desea eliminar al cliente " + txt_razon_social._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cli.Borrar();
                    MessageBox.Show("Se eliminó correctamente el cliente " + txt_razon_social._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            //}
        }
    }
}
