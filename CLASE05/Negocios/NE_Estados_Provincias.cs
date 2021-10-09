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
    class NE_Estados_Provincias
    {
        public enum Validacion { correcta, incorrecta }

        public string id_estado_provincia { get; set; }
        public string nombre_estado_provincia{ get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public DataTable BuscarEstadoProvincia(string patron, string columna)
        {
            string sql = @"SELECT id_estado_provincia, nombre_estado_provincia 
                          FROM estado_provincia WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarEstadoProvincia(string id_estado_provincia)
        {
            string sql = @"SELECT id_estado_provincia, nombre_estado_provincia 
                          FROM estado_provincia WHERE id_estado_provincia = " + id_estado_provincia;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarEstadoProvincia(string id_estado_provincia)
        {
            string sql = @"SELECT * 
                          FROM estado_provincia WHERE id_estado_provincia = " + id_estado_provincia;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarIdPais(string id_estado_provincia)
        {
            string sql = @"SELECT id_pais 
                          FROM estado_provincia WHERE id_estado_provincia = " + id_estado_provincia;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarNombrePais(string id_estado_provincia)
        {
            string sql = @"SELECT p.nombre_pais 
                          FROM estado_provincia ep INNER JOIN pais p ON ep.id_pais = p.id_pais 
                          WHERE ep.id_estado_provincia = " + id_estado_provincia;

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO estado_provincia (nombre_estado_provincia) VALUES (";
            sqlInsert += "'" + nombre_estado_provincia + "')";

            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE estado_provincia SET ";
            sqlUpdate += "nombre_estado_provincia = '" + nombre_estado_provincia + "'";
            sqlUpdate += " WHERE id_estado_provincia = " + id_estado_provincia;

            _BD.Modificar(sqlUpdate);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM estado_provincia WHERE id_estado_provincia = " + id_estado_provincia;

            _BD.Borrar(sqlDelete);
        }
        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM estado_provincia WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
    }
}
