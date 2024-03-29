﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Formularios.InicioSistema;
using CLASE05.Formularios.FrmBASE;
using CLASE05.Formularios.Usuarios;
using CLASE05.Formularios.Clientes;
using CLASE05.Formularios.Lotes;
using CLASE05.Formularios.Proveedores;
using CLASE05.Formularios.EquiposEnsamblados;
using CLASE05.Formularios.EquiposEspeciales;
using CLASE05.Formularios.Facturas;
using CLASE05.Formularios._FrmBASE;
using CLASE05.Formularios.Compras;
using CLASE05.Formularios.Reportes;
using CLASE05.Formularios.Estadísticas;
using CLASE05.Formularios.Stock;



namespace CLASE05
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Escritorio());
            //Application.Run(new Frm_Login());
            //Application.Run(new FrmLogin());
            //Application.Run(new Frm_ABM_Usuario_Entrada());
            //Application.Run(new Frm_Usuario_Alta());
            //Application.Run(new Frm_Log());
            //Application.Run(new Frm_Cliente());
            //Application.Run(new Frm_ABM_Cliente_Entrada());
            //Application.Run(new Frm_ABM_Articulos_Entrada());
            //Application.Run(new Frm_Articulo_Alta());
            //Application.Run(new Frm_ABM_EquiposEspeciales_Entrada());
            //Application.Run(new Frm_ABM_EquiposEnsamblados_Entrada());
            //Application.Run(new Frm_EquiposEspeciales_Alta());
            //Application.Run(new Frm_ABM_Proveedores_Entrada());
            //Application.Run(new Frm_ABM_Lote_Entrada());
            //Application.Run(new Frm_Proveedor_Consulta());
            //Application.Run(new Frm_SistemaFacturas_Entrada());
            //Application.Run(new Frm_SistemaFacturas_Alta());
            //Application.Run(new Frm_VentaFactura());
            //Application.Run(new FrmBase_Prueba_ABM_Entrada());
            //Application.Run(new Frm_Reporte_Ventas());
            //Application.Run(new Frm_Reporte_Compras());
            //Application.Run(new Frm_Estadisticas_Ventas());
            //Application.Run(new Frm_Stock());
            //Application.Run(new Frm_Estadisticas_Compras());
        }
    }
}
