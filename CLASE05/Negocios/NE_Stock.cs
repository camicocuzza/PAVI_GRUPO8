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
                          WHERE a.cod_articulo = '" + cod_articulo + "' AND s.eliminado = 0" +
                          "AND s.fecha = (SELECT max(s1.fecha) FROM stock s1 " +
                                          "WHERE s1.cod_articulo = s.cod_articulo)";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarGrilla(string patron, string columna)
        {
            string sql = @"SELECT a.cod_articulo, a.nombre, s.cantidad, s.fecha 
                          FROM articulo a JOIN stock s ON a.cod_articulo = s.cod_articulo
                          WHERE " + columna + " like '%" + patron + "%' AND s.eliminado = 0" +
                          " ORDER BY s.fecha";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarActualGrilla()
        {
            string sql = @"select stock.cod_articulo, a.nombre, stock.cantidad, stock.fecha
                        from stock
                        join articulo a on stock.cod_articulo = a.cod_articulo join
                        (
                            select cod_articulo, max(fecha) as max_dt
                            from stock
                            group by cod_articulo
                        ) t
                        on stock.cod_articulo= t.cod_articulo and stock.fecha = t.max_dt
                        order by len(stock.cod_articulo), stock.cod_articulo";

            return _BD.EjecutarSelect(sql);
        }
        
        public DataTable BuscarPorCodigo(string codigo)
        {
            string sql = @"SELECT a.cod_articulo, a.nombre, s.cantidad, s.fecha 
                          FROM articulo a JOIN stock s ON a.cod_articulo = s.cod_articulo
                          WHERE a.cod_articulo = " + codigo + " AND s.eliminado = 0" +
                          " ORDER BY s.fecha";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarPorFecha(string fecha)
        {
            string sql = @"SELECT a.cod_articulo, a.nombre, s.cantidad, s.fecha 
                          FROM articulo a JOIN stock s ON a.cod_articulo = s.cod_articulo
                          WHERE convert(date, s.fecha, 103) = '" + fecha + "'" +
                          " ORDER BY s.fecha ";

            return _BD.EjecutarSelect(sql);
        }

        public void Insertar(string cod_articulo, string fecha, int cantidad)
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO stock (cod_articulo, fecha, cantidad, eliminado) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + cantidad;
            sqlInsert += ", 0)";

            _BD.Insertar(sqlInsert);
        }

        public void ActualizarStockVenta(string cod_articulo, string fecha, int cantidad)
        {
            string sqlInsert = "";

            int stockanterior = int.Parse(this.ObtenerStock(cod_articulo).Rows[0][0].ToString());
            int stockactual = stockanterior - cantidad;

            sqlInsert = @"INSERT INTO stock (cod_articulo, fecha, cantidad, eliminado) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + stockactual;
            sqlInsert += ", 0)";

            MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void ActualizarStockCompra(string cod_articulo, string fecha, int cantidad)
        {
            string sqlInsert = "";

            int stockanterior =  int.Parse(this.ObtenerStock(cod_articulo).Rows[0][0].ToString());
            int stockactual = stockanterior + cantidad;

            sqlInsert = @"INSERT INTO stock (cod_articulo, fecha, cantidad, eliminado) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + stockactual;
            sqlInsert += ", 0)";

            _BD.Insertar(sqlInsert);
        }

        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM stock WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
    }
}
