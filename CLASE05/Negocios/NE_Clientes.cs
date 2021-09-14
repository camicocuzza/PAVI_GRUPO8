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
    class NE_Clientes
    {
        public enum Validacion { correcta, incorrecta }

        public string cuit_cliente { get; set; }
        public string razon_social { get; set; }
        public string limite_credito { get; set; }
        public string nombre_contacto { get; set; }
        public string legajo_empleado { get; set; }
        public string direccion { get; set; }
        public string id_estado_provincia { get; set; }
        public string ciudad { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public string RecuperarCuit(string razon_social, string nombre_contacto)
        {
            string sql = @"SELECT cuit_cliente FROM usuario
                         WHERE razon_social = '" + razon_social + "'"
                        + " AND nombre_contacto = '" + nombre_contacto + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return tabla.Rows[0][0].ToString();
            else
                return "";
        }
        public string RecuperarCuit(string razon_social)
        {
            string sql = @"SELECT cuit_cliente FROM usuario
                         WHERE razon_social = '" + razon_social + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return tabla.Rows[0][0].ToString();
            else
                return "";
        }
        public DataTable BuscarCliente(string patron, string columna)
        {
            string sql = @"SELECT cuit_cliente, razon_social, nombre_contacto, legajo_empleado  
                          FROM cliente WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarCliente(string cuit_cliente)
        {
            string sql = @"SELECT cuit_cliente, razon_social,
                          FROM cliente WHERE cuit_cliente = '" + cuit_cliente + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarCliente(string cuit_cliente)
        {
            string sql = @"SELECT * 
                          FROM cliente WHERE cuit_cliente = '" + cuit_cliente + "'"; 

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO usuario (cuit_cliente, razon_social, limite_credito, nombre_contacto, 
                                           legajo_empleado, direccion, id_estado_provincia, ciudad) VALUES (";

            sqlInsert += "'" + cuit_cliente + "'";
            sqlInsert += ", '" + razon_social + "'";
            sqlInsert += ", " + limite_credito;
            sqlInsert += ", '" + nombre_contacto + "'";
            sqlInsert += ", " + legajo_empleado;
            sqlInsert += ", '" + direccion + "'";
            sqlInsert += ", " + id_estado_provincia;
            sqlInsert += ", '" + ciudad + "')";

            //MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE cliente SET ";
            sqlUpdate += "cuit_cliente = '" + cuit_cliente + "'";
            sqlUpdate += ", razon_social = '" + razon_social + "'";
            sqlUpdate += ", limite_credito =  " + limite_credito;
            sqlUpdate += ", nombre_contacto = '" + nombre_contacto + "'";
            sqlUpdate += ", legajo_empleado = " + legajo_empleado;
            sqlUpdate += ", direccion = '" + direccion + "'";
            sqlUpdate += ", id_estado_provincia = " + id_estado_provincia;
            sqlUpdate += ", ciudad = '" + ciudad + "'";
            sqlUpdate += " WHERE cuit_cliente = '" + cuit_cliente + "'";

            _BD.Modificar(sqlUpdate);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM cliente WHERE cuit_cliente = '" + cuit_cliente + "'";

            _BD.Borrar(sqlDelete);
        }

    }
}

