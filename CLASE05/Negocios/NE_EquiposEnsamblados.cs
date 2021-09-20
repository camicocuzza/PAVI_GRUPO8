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
    class NE_EquiposEnsamblados
    {
        public string cod_prod_ensamblado { get; set; }
        public string precio { get; set; }
        public string stock { get; set; }
        public string cod_articulo { get; set; }
        public string cantidad { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarEquipoEnsamblado (string cod_eq_en)
        {
            string sql = @"SELECT cod_prod_ensamblado, precio, stock 
                          FROM producto_ensamblado WHERE cod_prod_ensamblado like '%" + cod_eq_en + "%'";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarEquipo(string cod_prod_ensamblado)
        {
            string sql = @"SELECT * 
                          FROM producto_ensamblado WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarDetalles(string cod_eq_en)
        {
            string sql = @"SELECT cod_articulo, cantidad 
                          FROM detalle_prod_ensamblado WHERE cod_prod_ensamblado = '" + cod_eq_en + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarArticulo(string articulo)
        {
            string sql = @"SELECT * 
                          FROM articulo WHERE cod_articulo = '" + articulo + "'";

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO producto_ensamblado (cod_prod_ensamblado, precio, stock) VALUES (";
            sqlInsert += "'" + cod_prod_ensamblado + "'";
            sqlInsert += ", " + precio;
            sqlInsert += ", " + stock + ")";

            MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }

        public void InsertarArticulo()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO detalle_prod_ensamblado (cod_articulo, cod_prod_ensamblado,cantidad) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + cod_prod_ensamblado + "'";
            sqlInsert += ", " + cantidad + ")";

            MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }

        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE producto_ensamblado SET ";
            sqlUpdate += "precio = " + precio;
            sqlUpdate += ", stock = " + stock;
            sqlUpdate += " WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";


            MessageBox.Show(sqlUpdate);
            _BD.Modificar(sqlUpdate);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM producto_ensamblado WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            MessageBox.Show(sqlDelete);
            _BD.Borrar(sqlDelete);

        }
        public void BorrarDetalle(string cod_art)
        {
            string sqlDelete = "DELETE FROM detalle_prod_ensamblado WHERE cod_articulo = '" + cod_art + "'";

            MessageBox.Show(sqlDelete);
            _BD.Borrar(sqlDelete);

        }

    }
}
