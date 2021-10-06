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
    class NE_Stock
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public DataTable ObtenerStock(string cod_articulo)
        {
            string sql = @"SELECT s.cantidad 
                          FROM articulo a JOIN stock s ON a.cod_articulo = s.cod_articulo
                          WHERE a.cod_articulo = '" + cod_articulo + "' " +
                          "AND s.fecha = (SELECT max(s1.fecha) FROM stock s1 " +
                                          "WHERE s1.cod_articulo = s.cod_articulo)";

            return _BD.EjecutarSelect(sql);
        }

        public void Insertar(string cod_articulo, string fecha, int cantidad)
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO stock (cod_articulo, fecha, cantidad) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + cantidad + ")";

            _BD.Insertar(sqlInsert);
        }

        public void ActualizarStockVenta(string cod_articulo, string fecha, int cantidad)
        {
            string sqlInsert = "";

            int stockanterior = int.Parse(this.ObtenerStock(cod_articulo).Rows[0][0].ToString());
            int stockactual = stockanterior - cantidad;

            sqlInsert = @"INSERT INTO stock (cod_articulo, fecha, cantidad) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + stockactual + ")";

            MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void ActualizarStockCompra(string cod_articulo, string fecha, int cantidad)
        {
            string sqlInsert = "";

            int stockanterior =  int.Parse(this.ObtenerStock(cod_articulo).Rows[0][0].ToString());
            int stockactual = stockanterior + cantidad;

            sqlInsert = @"INSERT INTO stock (cod_articulo, fecha, cantidad) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + stockactual + ")";

            MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }

    }
}
