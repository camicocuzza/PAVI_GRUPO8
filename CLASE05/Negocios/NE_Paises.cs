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
    class NE_Paises
    {
        public enum Validacion { correcta, incorrecta }

        public string id_pais { get; set; }
        public string nombre_pais { get; set; }   

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
       
        public bool ValidarExistenciaNombre(string nombre_pais)
        {
            string sql = @"SELECT * FROM pais
                          WHERE eliminado = 0 AND nombre_pais = '" + nombre_pais + "'";

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
        public int RecuperarId(string nombre_pais)
        {
            string sql = @"SELECT id_usuario FROM pais
                         WHERE eliminado = 0 AND nombre_pais = '" + nombre_pais + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return int.Parse(tabla.Rows[0][0].ToString());
            else
                return 0;
        }
        public DataTable BuscarPais(string patron, string columna)
        {
            string sql = @"SELECT id_pais, nombre_pais 
                          FROM pais WHERE eliminado = 0 AND " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarPais(string id_pais)
        {
            string sql = @"SELECT id_pais, nombre_pais 
                          FROM pais WHERE eliminado = 0 AND id_pais = " + id_pais;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarPais(string id_pais)
        {
            string sql = @"SELECT * 
                          FROM pais WHERE eliminado = 0 AND id_pais = " + id_pais;

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO pais (nombre_pais, eliminado) VALUES (";
            sqlInsert += "'" + nombre_pais + "'";
            sqlInsert += ", 0)";

            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE pais SET ";
            sqlUpdate += "nombre_pais = '" + nombre_pais + "'";
            sqlUpdate += " WHERE id_pais = " + id_pais;

            _BD.Modificar(sqlUpdate);
        }
        public void Borrar()
        {
            string sqlDelete = "UPDATE pais SET eliminado = 1 WHERE id_pais = " + id_pais;

            _BD.Borrar(sqlDelete);
        }
        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM pais WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
    }
}