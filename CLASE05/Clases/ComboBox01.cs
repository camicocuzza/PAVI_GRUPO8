using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace CLASE05.Clases
{
    public class ComboBox01 : ComboBox
    {
        public bool _Validable { get; set; } = true;
        public string _Nombre_campo { get; set; }
        public string _Nombre_tabla { get; set; }
        public string _MensajeError { get; set; }
        public bool _ComboSinSeleccion { get; set; } = true;
        //public bool _SelectConJoin { get; set; } = false;

        //public bool _Formatear { get; set; } = true;

        public string _tabla_cargar_combo { get; set; }
        public string _tabla_cargar_descriptor { get; set; }
        public string _tabla_cargar_pk { get; set; }
        public string _tabla_join { get; set; }
        public string _tabla_join_pk { get; set; }

        public void _Cargar()
        {            
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            string sql = "SELECT " + _tabla_cargar_pk + ", " + _tabla_cargar_descriptor + " FROM " + _tabla_cargar_combo;
            this.DisplayMember = _tabla_cargar_descriptor;
            this.ValueMember = _tabla_cargar_pk;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (_ComboSinSeleccion == true)
                this.SelectedIndex = -1;
            else
                this.SelectedIndex = 0;
        }
        public void _Cargar_Ordenado_x_Columna(string columna)
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            string sql = "SELECT " + _tabla_cargar_pk + ", " + _tabla_cargar_descriptor + " FROM " + _tabla_cargar_combo + " ORDER BY " + columna;
            this.DisplayMember = _tabla_cargar_descriptor;
            this.ValueMember = _tabla_cargar_pk;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (_ComboSinSeleccion == true)
                this.SelectedIndex = -1;
            else
                this.SelectedIndex = 0;
        }

        public void _CargarConJoin(int seleccion)
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            seleccion += 1;

            //string sql = @"SELECT e." + _tabla_cargar_pk + ", e." + _tabla_cargar_descriptor + " FROM " + _tabla_cargar_combo + " e";
            //sql += " INNER JOIN " + _tabla_join + " p ON e." + _tabla_join_pk + " = p." + _tabla_join_pk;
            //sql += " WHERE p." + _tabla_join_pk + " = " + seleccion;

            string sql = @"SELECT e.id_estado_provincia, e.nombre_estado_provincia 
                           FROM estado_provincia e INNER JOIN pais p ON e.id_pais = p.id_pais
                           WHERE p.id_pais = " + seleccion;

            this.DisplayMember = _tabla_cargar_descriptor;
            this.ValueMember = _tabla_cargar_pk;
            this.DataSource = _BD.EjecutarSelect(sql);
            
            if (_ComboSinSeleccion == true)
                this.SelectedIndex = -1;
            else
                this.SelectedIndex = 0;

            //SELECT a.[CUSTOMER ID], a.[NAME], SUM(b.[AMOUNT]) AS[TOTAL AMOUNT]
            // FROM RES_DATA a INNER JOIN INV_DATA b
            // ON a.[CUSTOMER ID] = b.[CUSTOMER ID]
            // GROUP BY a.[CUSTOMER ID], a.[NAME
        }
        
        public void Formatear()
        {
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Font = new Font("Microsoft JhengHei", 10);
            this.BackColor = Color.FromArgb(255, 25, 25, 25);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
}
