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
    public partial class Frm_Cliente_Alta : CLASE05.Formularios.Clientes.Frm_Cliente
    {
        NE_Clientes cli = new NE_Clientes();
        public Frm_Cliente_Alta()
        {
            InitializeComponent();
        }

        private void Frm_Cliente_Alta_Load(object sender, EventArgs e)
        {
            cmb_pais._Cargar();
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            NE_Empleados ne_emp = new NE_Empleados();           

            if (_TE.Validar(base.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                // VALIDACION ESPECIFICA
                if (_TE.ValidarCuit(txt_cuit_cliente.Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                {
                    MessageBox.Show("El cuit ingresado está incompleto");
                    txt_cuit_cliente.Focus();
                    return;
                }
                if (cli.ValidarExistencia(txt_cuit_cliente.Text) == true)
                {
                    MessageBox.Show("El cuit de cliente '" + txt_cuit_cliente.Text + "' ya está registrado", "Importante");
                    txt_cuit_cliente.Focus();
                    return;
                }
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

                double ent = double.Parse(txt_limite_credito.Text);
                double dec = (double.Parse(txt_decimales.Text)) / 100;

                cli.limite_credito = (ent + dec).ToString().Replace(",", "."); ;
               //MessageBox.Show(cli.limite_credito);

                cli.Insertar();
                MessageBox.Show("Se grabó correctamente el cliente " + txt_razon_social._Text, "Importante");

            }
        } 

        private void Frm_Cliente_Alta_Activated(object sender, EventArgs e)
        {
            this.txt_cuit_cliente.Focus();
        }
    }
}
