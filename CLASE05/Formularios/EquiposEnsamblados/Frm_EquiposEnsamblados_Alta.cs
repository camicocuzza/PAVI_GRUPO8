﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.EquiposEnsamblados
{
    public partial class Frm_EquiposEnsamblados_Alta : CLASE05.Formularios.EquiposEnsamblados.Frm_EquiposEnsamblados
    {
        NE_Stock_Ensamblados ne_stock_ens = new NE_Stock_Ensamblados();
        public Frm_EquiposEnsamblados_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {

                // GRABAR NUEVO REGISTRO
                NE_EquiposEnsamblados equipo = new NE_EquiposEnsamblados();

                equipo.cod_prod_ensamblado = "E" + txt_cod_p_ensamblado._Text;
                equipo.precio = txt_precio._Text;
                equipo.nombre = txt_nombre._Text;


                equipo.Insertar();
                ne_stock_ens.Insertar(txt_cod_p_ensamblado._Text, _TE.RecuperarFechaSistema().ToString(), 1);
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }
    }
}
