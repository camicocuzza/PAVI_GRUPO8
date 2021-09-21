using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Empleados
{
    public partial class Frm_Empleado_Alta : CLASE05.Formularios.Empleados.Frm_Empleado
    {
        public Frm_Empleado_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {

                if (_TE.ValidarFecha1(txt_fecha_ingreso._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                {
                    MessageBox.Show("La fecha es inválida");
                    txt_fecha_ingreso.Focus();
                    return;
                }

                // GRABAR NUEVO REGISTRO
                NE_Empleados empleado = new NE_Empleados();

                //empleado.legajo_empleado = txt_legajo._Text;
                empleado.id_tipo_documento = cmb_tipo_documento.SelectedValue.ToString();
                empleado.nro_documento = txt_n_documento._Text.ToString();
                empleado.apellido = txt_apellido._Text;
                empleado.nombre = txt_nombre._Text;
                empleado.fecha_ingreso = txt_fecha_ingreso._Text.ToString();
                empleado.direccion = txt_direccion._Text;
                empleado.id_estado_provincia = cmb_estado_provincia.SelectedValue.ToString();
                empleado.ciudad = txt_ciudad._Text;
                empleado.telefono = txt_telefono._Text;

                empleado.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }
    }
    
}
