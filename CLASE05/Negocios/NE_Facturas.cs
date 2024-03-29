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
    public class NE_Facturas
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        NE_Stock ne_stock = new NE_Stock();
        NE_Stock_Ensamblados ne_stock_ens = new NE_Stock_Ensamblados();

        public string num_factura { get; set; }
        //num_factura, id_tipo_factura, fecha, monto_total, cuit_cliente, legajo_empleado
        public DataTable BuscarFactura(string patron, string columna)
        {
            string sql = @"SELECT num_factura, id_tipo_factura, fecha, monto_total, cuit_cliente, legajo_empleado  
                          FROM factura WHERE " + columna + " = '" + patron + "' AND eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarPorFecha(string fecha)
        {
            string sql = @"SELECT num_factura, id_tipo_factura, fecha, monto_total, cuit_cliente, legajo_empleado 
                            FROM factura WHERE convert(date, fecha, 103) = '" + fecha + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTodas()
        {
            string sql = @"SELECT num_factura, id_tipo_factura, fecha, monto_total, cuit_cliente, legajo_empleado   
                          FROM factura WHERE eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarFacturaNum(string num_factura)
        {
            string sql = @"SELECT num_factura, id_tipo_factura, fecha, monto_total, cuit_cliente, legajo_empleado   
                          FROM factura WHERE num_factura = " + num_factura + " AND eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable Buscar_x_Cuit_Cliente(string cuit_cliente)
        {
            string sql = @"SELECT f.num_factura, f.id_tipo_factura, f.fecha, f.monto_total, f.cuit_cliente, f.legajo_empleado
                          c.cuit_cliente, c.razon_social
                          FROM factura f JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
                          WHERE c.cuit_cliente = '" + cuit_cliente + "' AND f.eliminado = 0";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Buscar_x_Razon_Social(string razon_social)
        {
            string sql = @"SELECT f.num_factura, f.id_tipo_factura, f.fecha, f.monto_total, f.cuit_cliente, f.legajo_empleado
                          c.cuit_cliente, c.razon_social
                          FROM factura f JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
                          WHERE c.razon_social = '" + razon_social + "' AND f.eliminado = 0";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Buscar_x_Num_Factura_tipo_factura(int num_factura, int id_tipo_factura)
        {
            string sql = @"SELECT num_factura, id_tipo_factura, fecha, monto_total, cuit_cliente, legajo_empleado 
                          FROM factura f JOIN tipo_factura tf ON f.id_tipo_factura = tf.id_tipo_factura
                          WHERE f.num_factura = " + num_factura + " AND tf.id_tipo_factura = " + id_tipo_factura + " AND f.eliminado = 0";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_num_factura(string cuit_cliente, string fecha)
        {
            string sql = @"SELECT f.num_factura
                          FROM factura f
                          WHERE f.cuit_cliente = '" + cuit_cliente + "' AND f.eliminado = 0 " +
                          "                         AND fecha = (SELECT max(f1.fecha) FROM factura f1 " +
                                                    "WHERE f1.cuit_cliente = f.cuit_cliente)";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Buscar_x_legajo(int legajo_empleado)
        {
            string sql = @"SELECT f.num_factura, f.id_tipo_factura, f.fecha, f.monto_total, f.cuit_cliente, f.legajo_empleado
                          e.id_tipo_documento, e.nro_documento, e.apellido, e.nombre 
                          FROM factura f JOIN empleado e ON f.legajo_empleado = e.legajo_empleado
                          WHERE e.legajo_empleado = " + legajo_empleado + " AND f.eliminado = 0";
            return _BD.EjecutarSelect(sql);
        }       
        public DataTable ConsultarListadoFacturasPorPeriodo(string fechaDesde, string fechaHasta)
        {
            string sql = @"SELECT f.id_tipo_factura, f.numero_factura, c.cuit_cliente, c.razon_social,  FORMAT(f.fecha, 'dd/MM/yyyy') as fecha
                         FROM factura f, cliente c, empleado e
                         WHERE f.cuit_cliente = c.cuit_cliente AND f.legajo_empleado = e.legajo_empleado
                         AND f.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "' AND f.eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarDetallesArticulos(string num_factura, string id_tipo_factura)
        {
            string sql = @"SELECT d.cod_articulo, a.nombre, d.cantidad, d.precio, d.cantidad * d.precio as subtotal
                            FROM factura f, detalle_factura_articulo d, articulo a
                            WHERE d.cod_articulo = a.cod_articulo AND
	                        f.num_factura = d.num_factura AND
	                        f.id_tipo_factura = d.id_tipo_factura AND
	                        f.id_tipo_factura = d.id_tipo_factura AND 
                            f.num_factura = " + num_factura + " AND f.id_tipo_factura = " + id_tipo_factura + " AND d.eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarDetallesArticulos(string num_factura)
        {
            string sql = @"SELECT d.cod_articulo, a.nombre, d.cantidad, d.precio, d.cantidad * d.precio as subtotal
                            FROM factura f, detalle_factura_articulo d, articulo a
                            WHERE d.cod_articulo = a.cod_articulo AND
	                        f.num_factura = d.num_factura AND
	                        f.id_tipo_factura = d.id_tipo_factura AND
	                        f.id_tipo_factura = d.id_tipo_factura AND 
                            f.num_factura = " + num_factura + " AND d.eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarDetallesEnsamblados(string num_factura, string id_tipo_factura)
        {
            string sql = @"SELECT d.cod_prod_ensamblado, e.nombre, d.cantidad, d.precio, d.cantidad * d.precio as subtotal
                        FROM factura f, detalle_factura_prodEnsamblado d, producto_ensamblado e
                        WHERE d.cod_prod_ensamblado = e.cod_prod_ensamblado AND
	                    f.num_factura = d.num_factura AND
	                    f.id_tipo_factura = d.id_tipo_factura AND
	                    f.id_tipo_factura = d.id_tipo_factura AND 
	                    f.num_factura = " + num_factura + " AND f.id_tipo_factura = " + id_tipo_factura + " AND d.eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarDetallesEnsamblados(string num_factura)
        {
            string sql = @"SELECT d.cod_prod_ensamblado, e.nombre, d.cantidad, d.precio, d.cantidad * d.precio as subtotal
                        FROM factura f, detalle_factura_prodEnsamblado d, producto_ensamblado e
                        WHERE d.cod_prod_ensamblado = e.cod_prod_ensamblado AND
	                    f.num_factura = d.num_factura AND
	                    f.id_tipo_factura = d.id_tipo_factura AND
	                    f.id_tipo_factura = d.id_tipo_factura AND 
	                    f.num_factura = " + num_factura + " AND d.eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }

        public void InsertarFactura(int id_tipo_factura, string fecha, string total_venta, 
            string cuit_cliente, string legajo_empleado, Grid01 Grid_Detalle_Articulo, 
            Grid01 Grid_Detalle_Ensamblado)
        {
            string sqlInsert = @"INSERT INTO factura 
                (id_tipo_factura, fecha, monto_total, cuit_cliente, legajo_empleado, eliminado) VALUES (";

            sqlInsert += id_tipo_factura;         
            sqlInsert += ", GETDATE()";
            sqlInsert += ", " + total_venta;
            sqlInsert += ", '" + cuit_cliente + "'";
            sqlInsert += ", " + legajo_empleado;
            sqlInsert += ", 0)";


            _BD.IniciarTransaccion();
            _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

            //recuperar el número
            num_factura = this.Recuperar_num_factura(cuit_cliente, fecha).Rows[0][0].ToString();

            if (Grid_Detalle_Articulo.Rows.Count > 1)
            {
                for (int i = 0; i < Grid_Detalle_Articulo.Rows.Count - 1; i++)
                {
                    string sqlInsertDA = @"INSERT INTO detalle_factura_articulo (cod_articulo, num_factura, id_tipo_factura, 
                                        cantidad, precio, eliminado) VALUES (";

                    //Grilla: cod_articulo, nombre, cantidad, precio
                    sqlInsertDA += Grid_Detalle_Articulo.Rows[i].Cells[0].Value.ToString();
                    sqlInsertDA += ", " + num_factura;
                    sqlInsertDA += ", " + id_tipo_factura;
                    sqlInsertDA += ", " + Grid_Detalle_Articulo.Rows[i].Cells[2].Value.ToString();
                    sqlInsertDA += ", " + Grid_Detalle_Articulo.Rows[i].Cells[3].Value.ToString().Replace(',', '.');
                    sqlInsertDA += ", 0)";

                    _BD.Insertar(sqlInsertDA, BE_Acceso_Datos.RecuperacionPk.no_recuperar);
                    
                    //STOCK
                    int cantidadVendida = int.Parse(Grid_Detalle_Articulo.Rows[i].Cells[2].Value.ToString());                    
                    DataTable tablastock = ne_stock.ObtenerStock(Grid_Detalle_Articulo.Rows[i].Cells[0].Value.ToString());
                    int cantidadanterior = int.Parse(tablastock.Rows[0]["cantidad"].ToString());
                    int nuevaCantidad = cantidadanterior - cantidadVendida;

                    ne_stock.Insertar(Grid_Detalle_Articulo.Rows[i].Cells[0].Value.ToString(), _TE.RecuperarFechaSistema(), nuevaCantidad);
                }
            }
            if (Grid_Detalle_Ensamblado.Rows.Count > 1)
            {
                for (int i = 0; i < Grid_Detalle_Ensamblado.Rows.Count - 1; i++)
                {
                    string sqlInsertDE = @"INSERT INTO detalle_factura_prodEnsamblado (cod_prod_ensamblado, num_factura, id_tipo_factura, 
                                        cantidad, precio, eliminado) VALUES (";

                    sqlInsertDE += "'" + Grid_Detalle_Ensamblado.Rows[i].Cells[0].Value.ToString() + "'";
                    sqlInsertDE += ", " + num_factura;
                    sqlInsertDE += ", " + id_tipo_factura;
                    sqlInsertDE += ", " + Grid_Detalle_Ensamblado.Rows[i].Cells[2].Value.ToString();
                    sqlInsertDE += ", " + Grid_Detalle_Ensamblado.Rows[i].Cells[3].Value.ToString().Replace(',', '.');
                    sqlInsertDE += ", 0)";

                    _BD.Insertar(sqlInsertDE, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

                    //STOCK
                    int cantidadVendida = int.Parse(Grid_Detalle_Ensamblado.Rows[i].Cells[2].Value.ToString());
                    DataTable tablastock = ne_stock_ens.ObtenerStock(Grid_Detalle_Ensamblado.Rows[i].Cells[0].Value.ToString());
                    int cantidadanterior = int.Parse(tablastock.Rows[0]["cantidad"].ToString());
                    int nuevaCantidad = cantidadanterior - cantidadVendida;

                    ne_stock_ens.Insertar(Grid_Detalle_Ensamblado.Rows[i].Cells[0].Value.ToString(), _TE.RecuperarFechaSistema(), nuevaCantidad);
                }
            }
            if (_BD.CerrarTransaccion() == BE_Acceso_Datos.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente la venta Nro. " + num_factura);
              
               
            }
            else
            {
                MessageBox.Show("No se grabó la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void BorrarFactura(string num_factura, string fecha, Grid01 Grid_Detalle_Articulo, Grid01 Grid_Detalle_Ensamblado)
        {

            string sqlDelete = @"UPDATE factura SET eliminado = 1 WHERE num_factura = " + num_factura;

            _BD.IniciarTransaccion();
            _BD.Borrar(sqlDelete, BE_Acceso_Datos.RecuperacionPk.no_recuperar);         


            string sqlDeleteDA = @"UPDATE detalle_factura_articulo SET eliminado = 1  
                                            WHERE num_factura = " + num_factura;
            _BD.Borrar(sqlDeleteDA, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

            //string sqlDeleteStock = @"UPDATE stock SET eliminado = 1 WHERE fecha = '" + fecha + "'";
            //_BD.Borrar(sqlDeleteStock);


            string sqlDeleteDE = @"UPDATE detalle_factura_prodEnsamblado SET eliminado = 1 
                                            WHERE num_factura = " + num_factura;
            _BD.Borrar(sqlDeleteDE, BE_Acceso_Datos.RecuperacionPk.no_recuperar);


            //string sqlDeleteStockEns = @"UPDATE stock_prod_ensamblado SET eliminado = 1 WHERE fecha = '" + fecha + "'";
            //_BD.Borrar(sqlDeleteStockEns);

            if (Grid_Detalle_Articulo.Rows.Count > 1)
            {
                for (int i = 0; i < Grid_Detalle_Articulo.Rows.Count - 1; i++)
                {

                    //RECUPERAR STOCK

                    int cantidadVendida = int.Parse(Grid_Detalle_Articulo.Rows[i].Cells[2].Value.ToString());
                    DataTable tablastock = ne_stock.ObtenerStock(Grid_Detalle_Articulo.Rows[i].Cells[0].Value.ToString());
                    int cantidadanterior = int.Parse(tablastock.Rows[0]["cantidad"].ToString());
                    int nuevaCantidad = cantidadanterior + cantidadVendida;

                    string sqldeletestock = "DELETE FROM stock WHERE cod_articulo = '" + Grid_Detalle_Articulo.Rows[i].Cells[0].Value.ToString() + "' AND fecha = '" + fecha + "'";
                    _BD.Modificar(sqldeletestock, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

                    string sqlStock = @"INSERT INTO stock (cod_articulo, fecha, cantidad, eliminado) VALUES(";
                    sqlStock += "'" + Grid_Detalle_Articulo.Rows[i].Cells[0].Value.ToString() + "'";
                    sqlStock += ", '" + _TE.RecuperarFechaSistema() + "'";
                    sqlStock += ", " + nuevaCantidad;
                    sqlStock += ", 0)";
                    _BD.Insertar(sqlStock, BE_Acceso_Datos.RecuperacionPk.no_recuperar);
                }
            }

            if (Grid_Detalle_Ensamblado.Rows.Count > 1)
            {
                for (int i = 0; i < Grid_Detalle_Ensamblado.Rows.Count - 1; i++)
                {

                    // RECUPERAR STOCK
                    int cantidadVendida = int.Parse(Grid_Detalle_Ensamblado.Rows[i].Cells[2].Value.ToString());
                    DataTable tablastock = ne_stock_ens.ObtenerStock(Grid_Detalle_Ensamblado.Rows[i].Cells[0].Value.ToString());
                    int cantidadanterior = int.Parse(tablastock.Rows[0]["cantidad"].ToString());
                    int nuevaCantidad = cantidadanterior + cantidadVendida;

                    string sqldeletestock = "DELETE FROM stock_prod_ensamblado WHERE cod_prod_ensamblado = '" + Grid_Detalle_Ensamblado.Rows[i].Cells[0].Value.ToString() + "' AND fecha = '" + fecha + "'";
                    _BD.Modificar(sqldeletestock, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

                    string sqlStock = @"INSERT INTO stock_prod_ensamblado (cod_prod_ensamblado, fecha, cantidad, eliminado) VALUES(";
                    sqlStock += "'" + Grid_Detalle_Ensamblado.Rows[i].Cells[0].Value.ToString() + "'";
                    sqlStock += ", '" + _TE.RecuperarFechaSistema() + "'";
                    sqlStock += ", " + nuevaCantidad;
                    sqlStock += ", 0)";
                    _BD.Insertar(sqlStock, BE_Acceso_Datos.RecuperacionPk.no_recuperar);
                }
            }

            if (_BD.CerrarTransaccion() == BE_Acceso_Datos.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se eliminó correctamente la venta Nro. " + num_factura);
            }
            else
            {
                MessageBox.Show("No se eliminó la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM factura WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable DataSourceEns(string num_factura)
        {
            string sql = @"select * , d.cantidad* d.precio as subtotal
                        from factura f, detalle_factura_prodEnsamblado d, producto_ensamblado a
                        where f.num_factura = d.num_factura AND a.cod_prod_ensamblado = d.cod_prod_ensamblado AND f.num_factura = " + num_factura;
            return _BD.EjecutarSelect(sql);
        }

        public DataTable DataSourceArt(string num_factura)
        {
            string sql = @"select * , d.cantidad * d.precio as subtotal
                        from factura f, detalle_factura_articulo d, articulo a
                        where f.num_factura = d.num_factura AND a.cod_articulo = d.cod_articulo AND f.num_factura = " + num_factura;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable DataSourceReporte_Ventas_Fecha(string mes, string año)
        {
            string sql = @"SELECT c.cuit_cliente, c.razon_social, f.num_factura, f.fecha, f.monto_total
                           FROM factura f JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
                           WHERE MONTH(f.fecha) = " + mes + " AND YEAR(f.fecha) = " + año + " AND f.eliminado = 0" +
                           " ORDER BY f.fecha";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable DataSourceReporte_Ventas_Año(string año)
        {
            string sql = @"SELECT c.cuit_cliente, c.razon_social, f.num_factura, f.fecha, f.monto_total
                           FROM factura f JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
                           WHERE YEAR(f.fecha) = " + año + " AND f.eliminado = 0" +
                           " ORDER BY f.fecha";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable DataSourceReporte_Ventas_Cliente(string cuit_cliente)
        {
            string sql = @"SELECT c.cuit_cliente, c.razon_social, f.num_factura, f.fecha, f.monto_total
                           FROM factura f JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
                           WHERE f.cuit_cliente = '" + cuit_cliente + " AND f.eliminado = 0" +
                           "' ORDER BY f.fecha";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable Estadisticas_Ventas_Articulos(string fechaDesde, string fechaHasta)
        {
            string sql = @"SELECT d.cod_articulo, a.nombre, SUM(d.cantidad) AS CantidadVendida
                            FROM factura f, detalle_factura_articulo d, articulo a 
                            WHERE f.num_factura = d.num_factura AND d.cod_articulo = a.cod_articulo
                            AND f.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "' AND f.eliminado = 0" +
                            " GROUP BY d.cod_articulo, a.nombre" +
                            " ORDER BY len(d.cod_articulo), d.cod_articulo";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Estadisticas_Ventas_Clientes(string fechaDesde, string fechaHasta)
        {
            string sql = @"SELECT c.cuit_cliente, c.razon_social, COUNT(c.cuit_cliente) AS CantidadVentas, SUM(f.monto_total) AS MontoTotal
                            FROM factura f
                            JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
                            WHERE f.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "' AND f.eliminado = 0" +
                            " GROUP BY c.cuit_cliente, c.razon_social";

            return _BD.EjecutarSelect(sql);
        }


    }
}
