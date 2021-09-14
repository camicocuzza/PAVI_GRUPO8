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
    public partial class Frm_Cliente_Modificacion : CLASE05.Formularios.Clientes.Frm_Cliente
    {
        NE_Clientes cli = new NE_Clientes();
        public Frm_Cliente_Modificacion()
        {
            InitializeComponent();
        }

        private void Frm_Cliente_Modificacion_Load(object sender, EventArgs e)
        {
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

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                //// VALIDACION ESPECIFICA
                //if (_TE.ValidarEmail(txt_email._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                //{
                //    MessageBox.Show("El formato de correo es invalido");
                //    txt_email.Focus();
                //    return;
                //}

                // GRABAR NUEVO REGISTRO

                cli.cuit_cliente = txt_cuit_cliente.Text;
                cli.razon_social = txt_razon_social._Text;
                cli.limite_credito = txt_limite_credito.Text;
                cli.nombre_contacto = txt_nombre_contacto._Text;
                cli.legajo_empleado = txt_legajo_empleado._Text;
                cli.direccion = txt_direccion._Text;               
                cli.id_estado_provincia = cmb_estado_provincia.SelectedValue.ToString();
                cli.ciudad = txt_ciudad._Text;

                cli.Modificar();
                MessageBox.Show("Se modificó correctamente el cliente " + txt_cuit_cliente.Text, "Importante");

            }
        }
        private void txt_limite_credito_KeyPress(object sender, KeyPressEventArgs e)
        {           
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {

        }
    }
}
