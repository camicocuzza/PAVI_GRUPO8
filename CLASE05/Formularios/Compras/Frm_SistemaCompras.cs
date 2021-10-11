﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Compras
{
    public partial class Frm_SistemaCompras : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public NE_Proveedores proveedor = new NE_Proveedores();
        public NE_Articulos articulo = new NE_Articulos();
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }
        public Frm_SistemaCompras()
        {
            InitializeComponent();
        }

        private void Frm_SistemaCompras_Load(object sender, EventArgs e)
        {
            grid_articulos.Formatear("Código Artículo, 100, C; Nombre, 235, C; Precio, 100, D");
        }
    }
}
