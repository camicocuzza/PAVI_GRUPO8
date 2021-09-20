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

        //public bool ValidarExistenciaNombre(string nombre_estado_provincia)
        //{
        //    string sql = @"SELECT * FROM estado_provincia
        //                  WHERE nombre_estado_provincia = '" + nombre_estado_provincia + "'";

        //    DataTable tabla = new DataTable();
        //    tabla = _BD.EjecutarSelect(sql);

        //    if (tabla.Rows.Count >= 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public int RecuperarId(string nombre_pais)
        //{
        //    string sql = @"SELECT id_usuario FROM pais
        //                 WHERE nombre_pais = '" + nombre_pais + "'";

        //    DataTable tabla = new DataTable();
        //    tabla = _BD.EjecutarSelect(sql);

        //    if (tabla.Rows.Count == 1)
        //        return int.Parse(tabla.Rows[0][0].ToString());
        //    else
        //        return 0;
        //}
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
                          FROM ep.estado_provincia INNER JOIN p.pais ON ep.id_estado_provincia = p.id_pais 
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

    }
}
