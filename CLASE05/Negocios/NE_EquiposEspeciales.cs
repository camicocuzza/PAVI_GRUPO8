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
        public void Insertar(PictureBox imagen)
        { 
            _BD.InsertarEquipoEspecial(cod_prod_ensamblado, cuit_cliente, imagen);
        }

        public void Modificar(PictureBox imagen)
        {
            _BD.ModificarEquipoEspecial(cod_prod_ensamblado, cuit_cliente, imagen);
            
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM equipo_especial WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            _BD.Borrar(sqlDelete);
        }

        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM equipo_especial WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }

    }
}
