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
    public class NE_Clientes
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
        public string decimales { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public bool ValidarExistencia(string cuit_cliente)
        {
            string sql = @"SELECT * FROM cliente
                          WHERE cuit_cliente = '" + cuit_cliente + "' AND eliminado = 0";

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
       
        public string RecuperarCuit(string razon_social)
        {
            string sql = @"SELECT cuit_cliente FROM usuario
                         WHERE razon_social = '" + razon_social + "' AND eliminado = 0";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return tabla.Rows[0][0].ToString();
            else
                return "";
        }
        public DataTable BuscarCliente(string patron, string columna)
        {
            string sql = @"SELECT cuit_cliente, razon_social, limite_credito, nombre_contacto, legajo_empleado  
                          FROM cliente WHERE " + columna + " like '%" + patron + "%' AND eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarCliente(string cuit_cliente)
        {
            string sql = @"SELECT cuit_cliente, razon_social, limite_credito, nombre_contacto, legajo_empleado
                          FROM cliente WHERE cuit_cliente = '" + cuit_cliente + "' AND eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarCliente(string cuit_cliente)
        {
            string sql = @"SELECT * 
                          FROM cliente WHERE cuit_cliente = '" + cuit_cliente + "' AND eliminado = 0"; 

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarCliente_x_RazonSocial(string razon_social)
        {
            string sql = @"SELECT * 
                          FROM cliente WHERE razon_social = '" + razon_social + "' AND eliminado = 0";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable ObtenerProvincia_Pais(string cuit_cliente)
        {
            string sql = @"SELECT e.nombre_estado_provincia, p.nombre_pais
                          FROM cliente c, estado_provincia e, pais p
                          WHERE c.id_estado_provincia = e.id_estado_provincia
                          AND e.id_pais = p.id_pais 
                          AND cuit_cliente = '" + cuit_cliente + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM cliente WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO cliente (cuit_cliente, razon_social, limite_credito, nombre_contacto, 
                                           legajo_empleado, direccion, id_estado_provincia, ciudad, eliminado) VALUES (";

            sqlInsert += "'" + cuit_cliente + "'";
            sqlInsert += ", '" + razon_social + "'";
            sqlInsert += ", " + limite_credito;
            sqlInsert += ", '" + nombre_contacto + "'";
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
            //string sqlDelete = "DELETE FROM cliente WHERE cuit_cliente = '" + cuit_cliente + "'";
            string sqlDelete = "UPDATE cliente SET eliminado = 1 WHERE cuit_cliente = '" + cuit_cliente + "'";

            _BD.Borrar(sqlDelete);
        }

    }
}

