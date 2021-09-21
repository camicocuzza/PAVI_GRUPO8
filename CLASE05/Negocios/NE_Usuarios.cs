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
    class NE_Usuarios
    {
        public enum Validacion {correcta, incorrecta } 

        public string id_usuario { get; set; }
        public string n_usuario    {get; set; }
        public string password   {get; set; }
             
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public Validacion Validar (string n_usuario, string password)
        {
            string sql = @"SELECT * FROM usuario
                          WHERE n_usuario = '" + n_usuario + "'"
                         + " AND password = '" + password + "'";

            DataTable tabla = new DataTable(); 
            tabla =  _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
            {
                return Validacion.correcta;
            }
            else
            {
                return Validacion.incorrecta;
            }
        }
        public bool ValidarExistenciaNombre(string n_usuario)
        {
            string sql = @"SELECT * FROM usuario
                          WHERE n_usuario = '" + n_usuario + "'";                    

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
        public int RecuperarId (string nombre, string password)
        {
            string sql = @"SELECT id_usuario FROM usuario
                         WHERE n_usuario = '" + nombre + "'"
                        + " AND password = '" + password + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return int.Parse(tabla.Rows[0][0].ToString());
            else
                return 0;
        }
        public DataTable BuscarUsuario (string patron, string columna)
        {
            string sql = @"SELECT id_usuario, n_usuario 
                          FROM usuario WHERE " + columna + " like '%" + patron + "%'";

            MessageBox.Show(sql);
            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarUsuario(string id_usuario)
        {
            string sql = @"SELECT id_usuario, n_usuario 
                          FROM usuario WHERE id_usuario = " + id_usuario;

            //MessageBox.Show(sql);
            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarUsuario(string id_usuario)
        {
            string sql = @"SELECT * 
                          FROM usuario WHERE id_usuario = " + id_usuario;

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO usuario (n_usuario, password) VALUES (";
            sqlInsert += "'" + n_usuario + "'";
            sqlInsert += ", '" + password + "')";

            //MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE usuario SET ";
            sqlUpdate += "n_usuario = '" + n_usuario + "'";
            sqlUpdate += ", password = '" + password + "'";
            sqlUpdate += " WHERE id_usuario = " + id_usuario;

            _BD.Modificar(sqlUpdate);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM usuario WHERE id_usuario = " + id_usuario;

            _BD.Borrar(sqlDelete);
        }

    }
}
