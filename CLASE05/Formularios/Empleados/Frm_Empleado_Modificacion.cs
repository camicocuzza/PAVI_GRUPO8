﻿using System;
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
    public partial class Frm_Empleado_Modificacion : CLASE05.Formularios.Empleados.Frm_Empleado
    {
        public Frm_Empleado_Modificacion()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Modificacion_Load(object sender, EventArgs e)
        {
            NE_Empleados empleado = new NE_Empleados();
            CargarFormulario(empleado.RecuperarEmpleado(legajo_empleado));
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_legajo._Text = tabla.Rows[0]["legajo_empleado"].ToString();
            cmb_tipo_documento.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_documento"].ToString());
            txt_n_documento._Text = tabla.Rows[0]["nro_documento"].ToString();
            txt_apellido._Text = tabla.Rows[0]["apellido"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
            txt_fecha_ingreso._Text = tabla.Rows[0]["fecha_ingreso"].ToString();
            txt_direccion._Text = tabla.Rows[0]["direccion"].ToString();
            cmb_estado_provincia.SelectedValue = int.Parse(tabla.Rows[0]["id_estado_provincia"].ToString());
            txt_ciudad._Text = tabla.Rows[0]["ciudad"].ToString();
            txt_telefono._Text = tabla.Rows[0]["telefono"].ToString();

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

                NE_Empleados empleado = new NE_Empleados();

                empleado.legajo_empleado = txt_legajo._Text.ToString();
                empleado.id_tipo_documento = cmb_tipo_documento.SelectedValue.ToString();
                empleado.nro_documento = txt_n_documento._Text.ToString();
                empleado.apellido = txt_apellido._Text;
                empleado.nombre = txt_nombre._Text;
                empleado.fecha_ingreso = txt_fecha_ingreso._Text.ToString();
                empleado.direccion = txt_direccion._Text;
                empleado.id_estado_provincia = cmb_estado_provincia.SelectedValue.ToString();
                empleado.ciudad = txt_ciudad._Text;
                empleado.telefono = txt_telefono._Text;

                empleado.Modificar();
                
                MessageBox.Show("Se modificó correctamente el empleado " + txt_legajo._Text, "Importante");
                this.Dispose();
            }
        }
    }
}
