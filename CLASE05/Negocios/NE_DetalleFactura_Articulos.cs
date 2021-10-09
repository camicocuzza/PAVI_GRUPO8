using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;

namespace CLASE05.Negocios
{
    public class NE_DetalleFactura_Articulos
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarCombo(ref ComboBox01 combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "cod_articulo";
            combo.DataSource = _BD.EjecutarSelect("SELECT nombre, cod_articulo FROM articulo WHERE eliminado = 0");
        }
        public string RecuperarPrecioArticulo(string cod_articulo)
        {
            string sql = "SELECT precio FROM articulo WHERE cod_articulo = " + cod_articulo + " AND eliminado = 0";
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }
        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM detalle_factura_articulo WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
    }

}
