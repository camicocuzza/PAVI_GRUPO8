﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;
using System.Data;
using System.Windows.Forms;

namespace CLASE05.Negocios
{
    public class NE_DetalleFactura_EquiposEnsamblados
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarCombo(ref ComboBox01 combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "cod_prod_ensamblado";
            combo.DataSource = _BD.EjecutarSelect("SELECT cod_prod_ensamblado FROM producto_ensamblado WHERE eliminado = 0");
        }
        public string RecuperarPrecioProdEnsamblado(string cod_prod_ensamblado)
        {
            string sql = "SELECT precio FROM producto_ensamblado WHERE eliminado = 0 AND cod_prod_ensamblado = " + cod_prod_ensamblado;
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }
        public DataTable BuscarDetalles(string cod_prod_ensamblado)
        {
            string sql = @"SELECT cod_articulo, cantidad 
                          FROM detalle_prod_ensamblado WHERE eliminado = 0 AND cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM detalle_prod_ensamblado WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
    }
}
