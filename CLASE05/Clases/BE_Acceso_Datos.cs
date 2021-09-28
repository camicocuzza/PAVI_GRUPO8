using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CLASE05.Clases
{
    class BE_Acceso_Datos
    {
        public enum EstadoTransaccion { correcto, error }
        public enum TipoConexion { transaccion, simple }

        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;

        public EstadoTransaccion ControlTransaccion { get; set; } = EstadoTransaccion.correcto;
        public TipoConexion ControlConexion { get; set; } = TipoConexion.simple;

       string cadena_conexion = "Data Source = 200.69.137.167,11333; Initial Catalog = BD3K3G08_2021; User ID = BD3K3G08_2021; Password=BDG08_3214";

        public void IniciarTransaccion()
        {
            ControlConexion = TipoConexion.transaccion;
            ControlTransaccion = EstadoTransaccion.correcto;
        }
        public EstadoTransaccion CerrarTransaccion()
        {
            if (ControlTransaccion == EstadoTransaccion.correcto)
            {
                Transaccion.Commit();
            }
            else
            {
                Transaccion.Rollback();
            }
            ControlConexion = TipoConexion.simple;
            Cerrar();
            return ControlTransaccion;
        }
        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = cadena_conexion;

                try
                {
                    Conexion.Open();
                    Cmd.Connection = Conexion;
                    Cmd.CommandType = System.Data.CommandType.Text;
                    if (ControlConexion == TipoConexion.transaccion)
                    {
                        Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                        Cmd.Transaction = Transaccion;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en apertura de conexión.\n"
                                     + "Mensaje del error: \n" + e.Message);
                    ControlTransaccion = EstadoTransaccion.error;
                }

            }
        }
        private void Cerrar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
        }
        public DataTable EjecutarSelect (string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en ejecución de SELECT.\n\n"
                    + sql
                    + "\n Mensaje del error: \n" + e.Message);
                ControlTransaccion = EstadoTransaccion.error;
            }
            Cerrar();
            return tabla;
        }

        public EstadoTransaccion EjecutarNoSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en ejecución de comando.\n\n"
                                + sql
                                + "\n Mensaje del error: \n" + e.Message);
                ControlTransaccion = EstadoTransaccion.error;                
            }
            Cerrar();
            return ControlTransaccion;
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

        public void InsertarEquipoEspecial(string cod_prod_en, string cuit_cliente, PictureBox imagen)
        {
            Conectar();
            Cmd.CommandText = "INSERT INTO equipo_especial (cod_prod_ensamblado, cuit_cliente, logo_cliente) VALUES (@cod_prod_ensamblado, @cuit_cliente, @logo_cliente)";
            Cmd.Parameters.Add("@cod_prod_ensamblado", SqlDbType.NVarChar);
            Cmd.Parameters.Add("@cuit_cliente", SqlDbType.NVarChar);
            Cmd.Parameters.Add("@logo_cliente", SqlDbType.Image);
            Cmd.Parameters["@cod_prod_ensamblado"].Value = cod_prod_en;
            Cmd.Parameters["@cuit_cliente"].Value = cuit_cliente;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Cmd.Parameters["@logo_cliente"].Value = ms.GetBuffer();
            Cmd.ExecuteNonQuery();
            Cerrar();
        }

        public void ModificarEquipoEspecial(string cod_prod_en, string cuit_cliente, PictureBox imagen)
        {
            Conectar();
            Cmd.CommandText = "UPDATE equipo_especial SET cod_prod_ensamblado = @cod_prod_ensamblado, cuit_cliente = @cuit_cliente, logo_cliente = @logo_cliente WHERE cod_prod_ensamblado = '" + cod_prod_en + "'";
            Cmd.Parameters.Add("@cod_prod_ensamblado", SqlDbType.NVarChar);
            Cmd.Parameters.Add("@cuit_cliente", SqlDbType.NVarChar);
            Cmd.Parameters.Add("@logo_cliente", SqlDbType.Image);
            Cmd.Parameters["@cod_prod_ensamblado"].Value = cod_prod_en;
            Cmd.Parameters["@cuit_cliente"].Value = cuit_cliente;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Cmd.Parameters["@logo_cliente"].Value = ms.GetBuffer();
            Cmd.ExecuteNonQuery();
            Cerrar();
        }
    }
}
