using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Proveedores
{
    public partial class Frm_Proveedor_Alta : CLASE05.Formularios.Proveedores.Frm_Proveedor
    {
        public Frm_Proveedor_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {

                if (_TE.ValidarFecha1(txt_fecha_inicio._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                {
                    MessageBox.Show("La fecha es inválida");
                    txt_fecha_inicio.Focus();
                    return;
                }

                // GRABAR NUEVO REGISTRO
                NE_Proveedores proveedor = new NE_Proveedores();

                proveedor.cuit_proveedor = txt_cuit_p._Text;
                proveedor.razon_social = txt_razon_social._Text;
                proveedor.fecha_inicio_operacion = txt_fecha_inicio._Text.ToString();
                proveedor.legajo_empleado = cmb_empleado.SelectedValue.ToString();
                proveedor.direccion = txt_direccion._Text;
                proveedor.id_estado_provincia = cmb_estado_provincia.SelectedValue.ToString();
                proveedor.ciudad = txt_ciudad._Text;
                
                proveedor.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }
    }
}
