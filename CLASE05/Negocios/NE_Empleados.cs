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
    class NE_Empleados
    {

        public enum Validacion { correcta, incorrecta }

        public string legajo_empleado { get; set; }
        public string id_tipo_documento { get; set; }
        public string nro_documento { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string fecha_ingreso { get; set; }
        public string direccion { get; set; }
        public string id_estado_provincia { get; set; }
        public string ciudad { get; set; }
        public string telefono { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public bool ValidarExistencia(string legajo_empleado)
        {
            string sql = @"SELECT * FROM empleado
                          WHERE legajo_empleado = " + legajo_empleado;

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable RecuperarEmpleado(string legajo_empleado)
        {
            string sql = @"SELECT * 
                          FROM empleado WHERE legajo_empleado = '" + legajo_empleado + "'";

            return _BD.EjecutarSelect(sql);
        }
        public string RecuperarLegajo(string id_tipo_documento, string nro_documento)
        {
            string sql = @"SELECT legajo_empleado FROM empleado
                         WHERE id_tipo_documento = " + id_tipo_documento +
                        " AND nro_documento = '" + nro_documento + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return tabla.Rows[0][0].ToString();
            else
                return "";
        }
        
        public DataTable BuscarEmpleado(string patron, string columna)
        {
            string sql = @"SELECT legajo_empleado, id_tipo_documento, nro_documento, apellido, nombre, telefono  
                          FROM empleado WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarEmpleado(string legajo_empleado)
        {
            string sql = @"SELECT legajo_empleado, id_tipo_documento, nro_documento, apellido, nombre, fecha_ingreso, telefono
                          FROM empleado WHERE legajo_empleado = " + legajo_empleado;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarCliente(string cuit_cliente)
        {
            string sql = @"SELECT * 
                          FROM empleado WHERE legajo_empleado = " + legajo_empleado;

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO empleado (id_tipo_documento, nro_documento, apellido, nombre, fecha_ingreso, 
                        direccion, id_estado_provincia, ciudad, telefono) VALUES (";
            sqlInsert += id_tipo_documento;
            sqlInsert += ", '" + nro_documento + "'";
            sqlInsert += ", '" + apellido + "'";
            sqlInsert += ", '" + nombre + "'";
            sqlInsert += ", '" + fecha_ingreso + "'";
            sqlInsert += ", '" + direccion + "'";
            sqlInsert += ", " + id_estado_provincia;
            sqlInsert += ", '" + ciudad + "'";
            sqlInsert += ", '" + telefono + "')";

            //MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE empleado SET ";
            sqlUpdate += "id_tipo_documento = " + id_tipo_documento;
            sqlUpdate += ", nro_documento = '" + nro_documento + "'";
            sqlUpdate += ", apellido = '" + apellido + "'";
            sqlUpdate += ", nombre = '" + nombre + "'";
            sqlUpdate += ", fecha_ingreso = '" + fecha_ingreso + "'";
            sqlUpdate += ", direccion = '" + direccion + "'";
            sqlUpdate += ", id_estado_provincia = " + id_estado_provincia;
            sqlUpdate += ", ciudad = '" + ciudad + "'";
            sqlUpdate += ", telefono = '" + telefono + "'";
            sqlUpdate += " WHERE legajo_empleado = " + legajo_empleado;

            _BD.Modificar(sqlUpdate);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM empleado WHERE legajo_empleado = " + legajo_empleado;

            _BD.Borrar(sqlDelete);
        }

    }
}

