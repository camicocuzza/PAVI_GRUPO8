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
    class NE_EquiposEspeciales
    {
        public string cod_prod_ensamblado { get; set; }
        public string cuit_cliente { get; set; }
        public byte[] logo_cliente { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarEquipoEspecial (string patron, string columna)
        {
            string sql = @"SELECT cod_prod_ensamblado, cuit_cliente 
                          FROM equipo_especial WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarEquipo(string cod_prod_ensamblado)
        {
            string sql = @"SELECT * 
                          FROM equipo_especial WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO equipo_especial (cod_prod_ensamblado, cuit_cliente, logo_cliente) VALUES (";
            sqlInsert += "'" + cod_prod_ensamblado + "'";
            sqlInsert += ", '" + cuit_cliente + "'";
            sqlInsert += ", " + logo_cliente + ")";

            MessageBox.Show(sqlInsert);
            //_BD.Insertar(sqlInsert);
        }

        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE equipo_especial SET ";
            sqlUpdate += "cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";
            sqlUpdate += ", cuit_cliente = " + cuit_cliente;
            sqlUpdate += " WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";


            MessageBox.Show(sqlUpdate);
            //_BD.Modificar(sqlUpdate);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM equipo_especial WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            MessageBox.Show(sqlDelete);
            //_BD.Borrar(sqlDelete);

        }

    }
}
