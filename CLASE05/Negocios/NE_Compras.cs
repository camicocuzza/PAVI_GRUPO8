using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Clases;



namespace CLASE05.Negocios
{
    public class NE_Compras
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        NE_Stock _Stock = new NE_Stock();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public DataTable BuscarCompra(string patron, string columna)
        {
            string sql = "";

            sql = @"SELECT num_compra, cuit_proveedor, fecha, monto_total 
                          FROM compra WHERE " + columna + " like '%" + patron + "%' AND eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarPorFecha(string fecha)
        {
            string sql = @"SELECT num_compra, cuit_proveedor, fecha, monto_total
                            FROM compra WHERE convert(date, fecha, 103) = '" + fecha + " AND eliminado = 0" ;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarCompra_x_mesAño(string mes, string año)
        {
            string sql = @"SELECT p.cuit_proveedor, p.razon_social, c.num_compra, c.fecha, c.monto_total
                           FROM compra c JOIN proveedor p ON c.cuit_proveedor = p.cuit_proveedor
                           WHERE MONTH(c.fecha) = " + mes + " AND YEAR(c.fecha) = " + año + " AND c.eliminado = 0" +
                           " ORDER BY c.fecha";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarCompra_x_Año(string año)
        {
            string sql = @"SELECT p.cuit_proveedor, p.razon_social, c.num_compra, c.fecha, c.monto_total
                           FROM compra c JOIN proveedor p ON c.cuit_proveedor = p.cuit_proveedor
                           WHERE YEAR(c.fecha) = " + año + " AND c.eliminado = 0" +
                           " ORDER BY c.fecha";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarCompra_x_proveedor(string cuit_proveedor)
        {
            string sql = @"SELECT p.cuit_proveedor, p.razon_social, c.num_compra, c.fecha, c.monto_total
                           FROM compra c JOIN proveedor p ON c.cuit_proveedor = p.cuit_proveedor
                           WHERE c.cuit_proveedor = " + cuit_proveedor + " AND c.eliminado = 0" +
                           " ORDER BY c.fecha";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarCompra(string num_compra)
        {
            string sql = @"SELECT * 
                          FROM compra WHERE num_compra = '" + num_compra + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarDetalleCompra(string num_compra)
        {
            string sql = "";

            sql = @"SELECT cod_articulo, cantidad, precio 
                          FROM detalle_compra WHERE num_compra = '" + num_compra + "' AND eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public void AgregarCompra(string cuit_proveedor, string fecha, string monto_total, Grid01 grid_articulos)
        {
            string sqlInsert = "INSERT INTO compra (cuit_proveedor, fecha, monto_total, eliminado) VALUES (";

            sqlInsert += "'" + cuit_proveedor + "'";
            sqlInsert += ", GETDATE()";
            sqlInsert += ", " + monto_total.Replace(',', '.');
            sqlInsert += ", 0)";

            _BD.IniciarTransaccion();
            _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

            string num_compra = this.Recuperar_num_compra(cuit_proveedor, fecha).Rows[0][0].ToString();

            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                string sqlInsertArticulo = "INSERT INTO detalle_compra (cod_articulo, num_compra, cantidad, precio, eliminado) VALUES (";

                sqlInsertArticulo += grid_articulos.Rows[i].Cells[0].Value.ToString();
                sqlInsertArticulo += ", " + num_compra;
                sqlInsertArticulo += ", " + grid_articulos.Rows[i].Cells[3].Value.ToString();
                sqlInsertArticulo += ", " + grid_articulos.Rows[i].Cells[2].Value.ToString().Replace(',', '.'); 
                sqlInsertArticulo += ", 0)";

                _BD.Insertar(sqlInsertArticulo, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

                int cantidadComprada = int.Parse(grid_articulos.Rows[i].Cells[3].Value.ToString());
                DataTable tablastock = _Stock.ObtenerStock(grid_articulos.Rows[i].Cells[0].Value.ToString());
                int cantidadAnterior = int.Parse(tablastock.Rows[0]["cantidad"].ToString());
                int nuevaCantidad = cantidadAnterior + cantidadComprada;

                _Stock.Insertar(grid_articulos.Rows[i].Cells[0].Value.ToString(), _TE.RecuperarFechaSistema(), nuevaCantidad);
            }

            if(_BD.CerrarTransaccion() == BE_Acceso_Datos.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente la compra");
            }
            else
            {
                MessageBox.Show("No se grabó la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void BorrarCompra(string num_compra, string fecha, Grid01 grid_articulos)
        {

            string sqlDelete = @"UPDATE compra SET eliminado = 1 WHERE num_compra = " + num_compra;

            _BD.IniciarTransaccion();
            _BD.Borrar(sqlDelete, BE_Acceso_Datos.RecuperacionPk.no_recuperar);


            string sqlDeleteDcompra = @"UPDATE detalle_compra SET eliminado = 1  
                                            WHERE num_compra = " + num_compra;

            _BD.Borrar(sqlDeleteDcompra, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

                for (int i = 0; i < grid_articulos.Rows.Count; i++)
                {

                int cantidadComprada = int.Parse(grid_articulos.Rows[i].Cells[3].Value.ToString());
                DataTable tablastock = _Stock.ObtenerStock(grid_articulos.Rows[i].Cells[0].Value.ToString());
                int cantidadAnterior = int.Parse(tablastock.Rows[0]["cantidad"].ToString());
                int nuevaCantidad = cantidadAnterior - cantidadComprada;

                string sqldeletestock = "DELETE FROM stock WHERE cod_articulo = '" + grid_articulos.Rows[i].Cells[0].Value.ToString() + "' AND fecha = '" + fecha + "'";
                    _BD.Modificar(sqldeletestock, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

                    string sqlStock = @"INSERT INTO stock (cod_articulo, fecha, cantidad, eliminado) VALUES(";
                    sqlStock += "'" + grid_articulos.Rows[i].Cells[0].Value.ToString() + "'";
                    sqlStock += ", '" + _TE.RecuperarFechaSistema() + "'";
                    sqlStock += ", " + nuevaCantidad;
                    sqlStock += ", 0)";
                    _BD.Insertar(sqlStock, BE_Acceso_Datos.RecuperacionPk.no_recuperar);
                }

            if (_BD.CerrarTransaccion() == BE_Acceso_Datos.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se eliminó correctamente la Compra Nro. " + num_compra);
            }
            else
            {
                MessageBox.Show("No se eliminó la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public DataTable Recuperar_num_compra(string cuit_proveedor, string fecha)
        {
            string sql = @"SELECT f.num_compra
                          FROM compra f
                          WHERE f.cuit_proveedor = '" + cuit_proveedor + "' AND f.eliminado = 0 " +
                          "                         AND fecha = (SELECT max(f1.fecha) FROM compra f1 " +
                                                    "WHERE f1.cuit_proveedor = f.cuit_proveedor)";
            return _BD.EjecutarSelect(sql);
        }
    }
}
