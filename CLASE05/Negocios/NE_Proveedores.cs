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
    public class NE_Proveedores
    {
        public string cuit_proveedor { get; set; }
        public string razon_social { get; set; }
        public string fecha_inicio_operacion { get; set; }
        public string legajo_empleado { get; set; }
        public string direccion { get; set; }
        public string id_estado_provincia { get; set; }
        public string ciudad { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarProveedor(string patron, string columna)
        {
            string sql = "";

            sql = @"SELECT cuit_proveedor, razon_social, fecha_inicio_operacion
                          FROM proveedor WHERE eliminado = 0 AND " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarProveedor(string cuit_proveedor)
        {
            string sql = @"SELECT * 
                          FROM proveedor WHERE eliminado = 0 AND cuit_proveedor = '" + cuit_proveedor + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarProveedor_Compra(string cuit_proveedor)
        {
            string sql = @"SELECT cuit_proveedor, fecha_inicio_operacion, direccion 
                          FROM proveedor WHERE cuit_proveedor = '" + cuit_proveedor + "'";

            return _BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO proveedor (cuit_proveedor, razon_social, fecha_inicio_operacion, legajo_empleado, direccion, id_estado_provincia, ciudad, eliminado) VALUES (";
            sqlInsert += "'" + cuit_proveedor + "'";
            sqlInsert += ", '" + razon_social + "'";
            sqlInsert += ", '" + fecha_inicio_operacion + "'";
            sqlInsert += ", " + legajo_empleado;
            sqlInsert += ", '" + direccion + "'";
            sqlInsert += ", " + id_estado_provincia;
            sqlInsert += ", '" + ciudad + "'";
            sqlInsert += ", 0)";

            _BD.Insertar(sqlInsert);
        }

        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE proveedor SET ";
            sqlUpdate += "cuit_proveedor = '" + cuit_proveedor + "'";
            sqlUpdate += ", razon_social = '" + razon_social + "'";
            sqlUpdate += ", fecha_inicio_operacion = '" + fecha_inicio_operacion + "'";
            sqlUpdate += ", legajo_empleado = " + legajo_empleado;
            sqlUpdate += ", direccion = '" + direccion + "'";
            sqlUpdate += ", id_estado_provincia = " + id_estado_provincia;
            sqlUpdate += ", ciudad = '" + ciudad + "'";
            sqlUpdate += " WHERE cuit_proveedor = " + cuit_proveedor;

            _BD.Modificar(sqlUpdate);
        }

        public void Borrar()
        {
            string sqlDelete = "UPDATE proveedor SET eliminado = 1 WHERE cuit_proveedor = '" + cuit_proveedor + "'";

            _BD.Borrar(sqlDelete);

        }

        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM proveedor WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
    }
}
