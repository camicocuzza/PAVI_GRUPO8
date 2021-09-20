using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CLASE05.Clases
{
    class BE_Acceso_Datos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();

       
        //string cadena_conexion = "Data Source = 200.69.137.167,11333; Initial Catalog = BD3K7G15_2021; User ID = BD3K7G15_2021; Password=BDG15_3922";
        string cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G08_2021;Persist Security Info=True;User ID=BD3K3G08_2021;Password=BDG08_3214";



        private void Conectar()
        {
            Conexion.ConnectionString = cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }
        private void Cerrar()
        {
            Conexion.Close();
        }
        public DataTable EjecutarSelect (string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Cerrar();
            return tabla;
        }

        public void EjecutarNoSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            Cerrar();
        }

        public void Insertar(string sql)
        {
            EjecutarNoSelect(sql);
        }

        public void Borrar(string sql)
        {
            EjecutarNoSelect(sql);
        }

        public void Modificar(string sql)
        {
            EjecutarNoSelect(sql);
        }
    }
}
