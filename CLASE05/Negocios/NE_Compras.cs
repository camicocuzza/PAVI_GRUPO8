using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;



namespace CLASE05.Negocios
{
    class NE_Compras
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();


        public DataTable BuscarCompra(string patron, string columna)
        {
            string sql = "";

            sql = @"SELECT * 
                          FROM compra WHERE " + columna + " like '%" + patron + "%'";



            return _BD.EjecutarSelect(sql);
        }
    }
}
