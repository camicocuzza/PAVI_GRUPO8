﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;
using System.Data;
using System.Windows.Forms;


namespace CLASE05.Negocios
{
    public class NE_EquiposEnsamblados
    {
        public string cod_prod_ensamblado { get; set; }
        public string precio { get; set; }
        public string nombre { get; set; }
        public string cod_articulo { get; set; }
        public string cantidad { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public void CargarCombo(ref ComboBox01 combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "cod_prod_ensamblado";
            combo.DataSource = _BD.EjecutarSelect("SELECT nombre, cod_prod_ensamblado FROM producto_ensamblado WHERE eliminado = 0");
        }
        public DataTable BuscarEnsambladoNombre(string patron)
        {
            string sql = "";

            sql = @"SELECT cod_prod_ensamblado, nombre, precio FROM producto_ensamblado WHERE eliminado = 0 AND nombre like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarEquipoEnsamblado (string cod_eq_en)
        {
            string sql = @"SELECT cod_prod_ensamblado, nombre, precio 
                          FROM producto_ensamblado WHERE eliminado = 0 AND cod_prod_ensamblado = '" + cod_eq_en + "'";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarEquipo(string cod_prod_ensamblado)
        {
            string sql = @"SELECT * 
                          FROM producto_ensamblado WHERE eliminado = 0 AND cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarDetalles(string cod_eq_en)
        {
            string sql = @"SELECT cod_articulo, cantidad 
                          FROM detalle_prod_ensamblado WHERE eliminado = 0 AND cod_prod_ensamblado = '" + cod_eq_en + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarArticulo(string articulo)
        {
            string sql = @"SELECT * 
                          FROM articulo WHERE eliminado = 0 AND cod_articulo = '" + articulo + "'";

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO producto_ensamblado (cod_prod_ensamblado, nombre, precio, eliminado) VALUES (";
            sqlInsert += "'" + cod_prod_ensamblado + "'";
            sqlInsert += ", " + nombre;
            sqlInsert += ", " + precio;
            sqlInsert += ", 0)";

            _BD.Insertar(sqlInsert);
        }

        public void InsertarArticulo()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO detalle_prod_ensamblado (cod_articulo, cod_prod_ensamblado, cantidad, eliminado) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += ", '" + cod_prod_ensamblado + "'";
            sqlInsert += ", " + cantidad;
            sqlInsert += ", 0)";

            _BD.Insertar(sqlInsert);
        }

        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE producto_ensamblado SET ";
            sqlUpdate += "nombre = '" + nombre + "'";
            sqlUpdate += ", precio = " + precio;            
            sqlUpdate += " WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            _BD.Modificar(sqlUpdate);
        }

        public void Borrar()
        {
            string sqlDelete = "UPDATE producto_ensamblado SET eliminado = 1 WHERE cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";

            _BD.Borrar(sqlDelete);

        }
        public void BorrarDetalle(string cod_art)
        {
            string sqlDelete = "UPDATE detalle_prod_ensamblado SET eliminado = 1 WHERE cod_articulo = '" + cod_art + "'";

            _BD.Borrar(sqlDelete);

        }
        public string RecuperarPrecioProdEnsamblado(string cod_prod_ensamblado)
        {
            string sql = "SELECT precio FROM producto_ensamblado WHERE eliminado = 0 AND cod_prod_ensamblado = '" + cod_prod_ensamblado + "'";
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString().Trim();
        }
        public DataTable RecuperarEliminados()
        {
            string sql = @"SELECT * 
                          FROM cliente producto_ensamblado WHERE eliminado = 1";

            return _BD.EjecutarSelect(sql);
        }
    }
}
