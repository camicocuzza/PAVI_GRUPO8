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
    public class NE_Articulos
    {
        public string cod_articulo { get; set; }
        public string num_serie { get; set; }
        public string num_lote { get; set; }
        public string precio { get; set; }
        public string tiempo_envio { get; set; }
        public string plazo_pago { get; set; }
        public string nombre { get; set; }
        public string id_rubro { get; set; }
        public string id_pais { get; set; }
        public string cuit_proveedor { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarComboXProveedor(ref ComboBox01 combo, string cuit_proveedor)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "cod_articulo";
            combo.DataSource = _BD.EjecutarSelect("SELECT cod_articulo, nombre FROM articulo WHERE cuit_proveedor = '" + cuit_proveedor + "'");
        }
        public DataTable BuscarArticulo(string patron, string columna)
        {
            string sql = "";

            sql = @"SELECT cod_articulo, num_lote, precio, nombre, id_pais, cuit_proveedor 
                          FROM articulo WHERE " + columna + " like '%" + patron + "%'";



            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarArticulo(string cod_articulo)
        {
            string sql = @"SELECT * 
                          FROM articulo WHERE cod_articulo = '" + cod_articulo + "'";

            return _BD.EjecutarSelect(sql);
        }
        public string RecuperarNombreArticulo(string cod_articulo)
        {
            string sql = @"SELECT nombre 
                          FROM articulo WHERE cod_articulo = '" + cod_articulo + "'";

            return _BD.EjecutarSelect(sql).Rows[0]["nombre"].ToString();
        }

        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO articulo (cod_articulo, num_serie, num_lote, precio, tiempo_envio, plazo_pago, nombre, id_rubro, id_pais, cuit_proveedor) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + num_serie + "'";
            sqlInsert += ", '" + num_lote + "'";
            sqlInsert += ", " + precio;
            sqlInsert += ", '" + tiempo_envio + "'";
            sqlInsert += ", '" + plazo_pago + "'";
            sqlInsert += ", '" + nombre + "'";
            sqlInsert += ", " + id_rubro;
            sqlInsert += ", " + id_pais;
            sqlInsert += ", '" + cuit_proveedor + "')";

            MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }

        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE articulo SET ";
            sqlUpdate += "num_serie = '" + num_serie + "'";
            sqlUpdate += ", num_lote = '" + num_lote + "'";
            sqlUpdate += ", precio = " + precio;
            sqlUpdate += ", tiempo_envio = '" + tiempo_envio + "'";
            sqlUpdate += ", plazo_pago = '" + plazo_pago + "'";
            sqlUpdate += ", nombre = '" + nombre + "'";
            sqlUpdate += ", id_rubro = " + id_rubro;
            sqlUpdate += ", id_pais = " + id_pais;
            sqlUpdate += ", cuit_proveedor = '" + cuit_proveedor + "'";
            sqlUpdate += " WHERE cod_articulo = '" + cod_articulo + "'";

            MessageBox.Show(sqlUpdate);
            _BD.Modificar(sqlUpdate);
        }

        public string BuscarPrecio(string cod_articulo)
        {
            string sql = @"SELECT precio 
                          FROM articulo WHERE cod_articulo = '" + cod_articulo + "'";

            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla.Rows[0]["precio"].ToString();
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM articulo WHERE cod_articulo = '" + cod_articulo + "'";

            //_BD.Borrar(sqlDelete);

        }
    }
}
