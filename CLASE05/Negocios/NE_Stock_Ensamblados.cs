using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;
using System.Data;
using System.Windows.Forms;

namespace CLASE05.Negocios
{
    class NE_Stock_Ensamblados
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public DataTable ObtenerStock(string cod_prod_ensamblado)
        {
            string sql = @"SELECT s.cantidad 
                          FROM producto_ensamblado e JOIN stock_prod_ensamblado s ON e.cod_prod_ensamblado = s.cod_prod_ensamblado
                          WHERE e.cod_prod_ensamblado = '" + cod_prod_ensamblado + "' AND s.eliminado = 0 " +
                          "AND s.fecha = (SELECT max(s1.fecha) FROM stock_prod_ensamblado s1 " +
                                          "WHERE s1.cod_prod_ensamblado = s.cod_prod_ensamblado)";

            return _BD.EjecutarSelect(sql);
        }

        public void Insertar(string cod_prod_ensamblado, string fecha, int cantidad)
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO stock_prod_ensamblado (cod_prod_ensamblado, fecha, cantidad, eliminado) VALUES (";
            sqlInsert += "'" + cod_prod_ensamblado + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + cantidad;
            sqlInsert += ", 0)";

            _BD.Insertar(sqlInsert);
        }
        public void ActualizarStockVenta(string cod_prod_ensamblado, string fecha, int cantidad)
        {
            string sqlInsert = "";

            int stockanterior = int.Parse(this.ObtenerStock(cod_prod_ensamblado).Rows[0][0].ToString());
            int stockactual = stockanterior - cantidad;

            sqlInsert = @"INSERT INTO stock_prod_ensamblado (cod_prod_ensamblado, fecha, cantidad, eliminado) VALUES (";
            sqlInsert += "'" + cod_prod_ensamblado + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + stockactual;
            sqlInsert += ", 0)";

            MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }

        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM stock_prod_ensamblado WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
    }
}

