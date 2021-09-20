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
        int contador = 0;
        NE_Clientes cli = new NE_Clientes();
        public Frm_Cliente_Modificacion()
        {
            InitializeComponent();
        }

        private void Frm_Cliente_Modificacion_Load(object sender, EventArgs e)
        {
            cmb_pais._Cargar();
            //cmb_estado_provincia._Cargar();
            cmb_estado_provincia.Enabled = false;

            CargarFormulario(cli.RecuperarCliente(cuit_cliente));

        }
        private void CargarFormulario(DataTable tabla)
        {
            NE_Estados_Provincias ne_prov = new NE_Estados_Provincias();
            NE_Paises ne_pais = new NE_Paises();
            string id_estado_provincia = tabla.Rows[0]["id_estado_provincia"].ToString();
            DataTable tabla_IdPais = ne_prov.RecuperarIdPais(id_estado_provincia);
            string id_pais = tabla_IdPais.Rows[0]["id_pais"].ToString();
            
            float num = float.Parse(tabla.Rows[0]["limite_credito"].ToString());
            double enteros = Math.Truncate(num);
            int decimales = (int)(((decimal)num % 1) * 100);
            
            txt_cuit_cliente.Text = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_razon_social._Text = tabla.Rows[0]["razon_social"].ToString();
            txt_limite_credito.Text = enteros.ToString();
            txt_decimales.Text = decimales.ToString();
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
            NE_Empleados ne_emp = new NE_Empleados();

            if (_TE.Validar(base.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                // VALIDACION ESPECIFICA
                          
                if (ne_emp.ValidarExistencia(txt_legajo_empleado._Text) == false)
                {
                    MessageBox.Show("El legajo '" + txt_legajo_empleado._Text + "' no corresponde a un empleado activo", "Importante");
                    txt_legajo_empleado.Focus();
                    return;
                }

                // GRABAR NUEVO REGISTRO

                cli.cuit_cliente = txt_cuit_cliente.Text;
                cli.razon_social = txt_razon_social._Text;
                cli.limite_credito = txt_limite_credito.Text;
                cli.nombre_contacto = txt_nombre_contacto._Text;
                cli.legajo_empleado = txt_legajo_empleado._Text;
                cli.direccion = txt_direccion._Text;
                cli.id_estado_provincia = cmb_estado_provincia.SelectedValue.ToString();
                cli.ciudad = txt_ciudad._Text;

                cli.decimales = txt_decimales.Text;

                float ent = float.Parse(txt_limite_credito.Text);
                float dec = (float.Parse(txt_decimales.Text)) / 100;

                cli.limite_credito = (ent + dec).ToString().Replace(",", "."); ;
                MessageBox.Show(cli.limite_credito);
                cli.Modificar();

                MessageBox.Show("Se modificó correctamente el cliente " + txt_razon_social.Text, "Importante");

            }
        }
        private void txt_limite_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {

        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            contador += 1;

            // MessageBox.Show(cmb_pais.SelectedIndex.ToString() + contador);
            if (cmb_pais.SelectedIndex != -1 & contador > 2)
            {
                cmb_estado_provincia.Enabled = true;
                cmb_estado_provincia._CargarConJoin(cmb_pais.SelectedIndex);

                //NE_Paises p = NE_Paises;
                //string nombre_pais = cmb_pais.SelectedText;
                //p.RecuperarId(nombre_pais);

                //cmb_estado_provincia._CargarConJoin(p.RecuperarId(nombre_pais);
            }
        }
    }
}
