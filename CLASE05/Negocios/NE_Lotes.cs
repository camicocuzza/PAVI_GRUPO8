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
    class NE_Lotes
    {
        public string num_lote { get; set; }
        public string nro_remito_proveedor { get; set; }
        public string fecha_compra { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarLote(string patron, string columna)
        {
            string sql = "";

            sql = @"SELECT num_lote, nro_remito_proveedor, fecha_compra 
                          FROM lote WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarLote(string num_lote)
        {
            string sql = @"SELECT * 
                          FROM lote WHERE num_lote = '" + num_lote + "'";

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO lote (num_lote, nro_remito_proveedor, fecha_compra) VALUES (";
            sqlInsert += "'" + num_lote + "'";
            sqlInsert += ", '" + nro_remito_proveedor + "'";
            sqlInsert += ", '" + fecha_compra + "')";

            _BD.Insertar(sqlInsert);
        }

        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE lote SET ";
            sqlUpdate += "num_lote = '" + num_lote + "'";
            sqlUpdate += ", nro_remito_proveedor = '" + nro_remito_proveedor + "'";
            sqlUpdate += ", fecha_compra = '" + fecha_compra + "'";
            sqlUpdate += " WHERE num_lote = '" + num_lote + "'";

            _BD.Modificar(sqlUpdate);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM lote WHERE num_lote = '" + num_lote + "'";

            _BD.Borrar(sqlDelete);

        }

    }
}
