using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;



namespace CLASE05.Negocios
{
    public class NE_Compras
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        NE_Stock _Stock = new NE_Stock();


        public DataTable BuscarCompra(string patron, string columna)
        {
            string sql = "";

            sql = @"SELECT * 
                          FROM compra WHERE " + columna + " like '%" + patron + "%'";



            return _BD.EjecutarSelect(sql);
        }

        public void AgregarCompra(string cuit_proveedor, string fecha, string monto_total, Grid01 grid_articulos)
        {
            string sqlInsert = "INSERT INTO compra (cuit_proveedor, fecha, monto_total) VALUES (";

            sqlInsert += "'" + cuit_proveedor + "'";
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + monto_total + ")";

            _BD.IniciarTransaccion();
            _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                string sqlInsertArticulo = "INSERT INTO detalle_compra (cod_articulo, num_compra, cantidad, precio) VALUES (";

                sqlInsertArticulo += grid_articulos.Rows[i].Cells[0].Value.ToString();

                sqlInsertArticulo += ", " + grid_articulos.Rows[i].Cells[2].Value.ToString();
                sqlInsertArticulo += ", " + grid_articulos.Rows[i].Cells[3].Value.ToString() + ")";

            }
        }
    }
}
