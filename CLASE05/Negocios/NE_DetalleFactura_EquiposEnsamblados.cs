using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;

namespace CLASE05.Negocios
{
    class NE_DetalleFactura_EquiposEnsamblados
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarCombo(ref ComboBox01 combo)
        {
            combo.DisplayMember = "cod_prod_ensamblado";
            combo.ValueMember = "cod_prod_ensamblado";
            combo.DataSource = _BD.EjecutarSelect("SELECT cod_prod_ensamblado FROM producto_ensamblado");
        }
        public string RecuperarPrecioProdEnsamblado(string cod_prod_ensamblado)
        {
            string sql = "SELECT precio FROM producto_ensamblado WHERE cod_prod_ensamblado = " + cod_prod_ensamblado;
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }
    }
}
