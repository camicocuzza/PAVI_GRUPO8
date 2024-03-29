﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Negocios;
using CLASE05.Formularios.Usuarios;
using CLASE05.Formularios.Clientes;
using CLASE05.Formularios.FrmBASE;
using CLASE05.Formularios.Articulos;
using CLASE05.Formularios.EquiposEnsamblados;
using CLASE05.Formularios.EquiposEspeciales;
using CLASE05.Formularios.Lotes;
using CLASE05.Formularios.Empleados;
using CLASE05.Formularios.Proveedores;
using CLASE05.Formularios.Compras;
using CLASE05.Formularios.Facturas;
using CLASE05.Formularios.Reportes;
using CLASE05.Formularios.Estadísticas;
using CLASE05.Formularios.Stock;


namespace CLASE05.Formularios.InicioSistema
{
    public partial class Frm_Escritorio : Form
    {
        string usuario = "";
        string clave = "";
        int id_usuario = 0;
        NE_Usuarios ne_usu = new NE_Usuarios();
        

        public Frm_Escritorio()
        {
            InitializeComponent();
            Screen screen = Screen.FromControl(this);
            int x = screen.WorkingArea.X - screen.Bounds.X;
            int y = screen.WorkingArea.Y - screen.Bounds.Y;
            this.MaximizedBounds = new Rectangle(x, y,
                screen.WorkingArea.Width, screen.WorkingArea.Height);
            this.MaximumSize = screen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
        }

        Frm_ABM_Usuario_Entrada abm_usu_open;

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {           
            this.Plogin();
        }      

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirDeSistemaConLoginActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Plogin();
        }
        
        private void Plogin()
        {
            this.usuario = "";
            this.clave = "";
            this.id_usuario = 0;

            Frm_Login login = new Frm_Login();
            login.ShowDialog();
            if (login.Pp_usuario == "")
            {
                login.Dispose();
                this.Close();
                return;
            }
            this.usuario = login.Pp_usuario;
            this.clave = login.Pp_clave;
            login.Dispose();
            id_usuario = ne_usu.RecuperarId(this.usuario, this.clave);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Usuario_Entrada frm_usuario = new Frm_ABM_Usuario_Entrada();
            frm_usuario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Cliente_Entrada frm_usuario = new Frm_ABM_Cliente_Entrada();
            frm_usuario.Show();

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Articulos_Entrada frm_articulos = new Frm_ABM_Articulos_Entrada();
            frm_articulos.Show();
        }

        private void ensambladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_EquiposEnsamblados_Entrada frm_equiposEnsamblados = new Frm_ABM_EquiposEnsamblados_Entrada();
            frm_equiposEnsamblados.Show();
        }

        private void especialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_EquiposEspeciales_Entrada frm_equiposEspeciales = new Frm_ABM_EquiposEspeciales_Entrada();
            frm_equiposEspeciales.Show();
        }

        private void lotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Lote_Entrada frm_lotes = new Frm_ABM_Lote_Entrada();
            frm_lotes.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Empleados_Entrada frm_empleados = new Frm_ABM_Empleados_Entrada();
            frm_empleados.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Proveedores_Entrada frm_proveedores = new Frm_ABM_Proveedores_Entrada();
            frm_proveedores.Show();
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            Frm_ABM_Articulos_Entrada frm_articulos = new Frm_ABM_Articulos_Entrada();
            frm_articulos.Show();
        }

        private void btn_ensamblados_Click(object sender, EventArgs e)
        {
            Frm_ABM_EquiposEnsamblados_Entrada frm_equiposEnsamblados = new Frm_ABM_EquiposEnsamblados_Entrada();
            frm_equiposEnsamblados.Show();
        }

        private void btn_especiales_Click(object sender, EventArgs e)
        {
            Frm_ABM_EquiposEspeciales_Entrada frm_equiposEspeciales = new Frm_ABM_EquiposEspeciales_Entrada();
            frm_equiposEspeciales.Show();

        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Frm_SistemaCompras_Entrada frm_compras = new Frm_SistemaCompras_Entrada();
            frm_compras.Show();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Frm_ABM_Proveedores_Entrada frm_proveedores = new Frm_ABM_Proveedores_Entrada();
            frm_proveedores.Show();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Frm_BaseReportes frm_basereportes = new Frm_BaseReportes();
            frm_basereportes.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Frm_ABM_Cliente_Entrada frm_usuario = new Frm_ABM_Cliente_Entrada();
            frm_usuario.Show();

        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Frm_SistemaFacturas_Entrada frm_facturas = new Frm_SistemaFacturas_Entrada();
            frm_facturas.Show();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            Frm_ABM_Empleados_Entrada frm_empleados = new Frm_ABM_Empleados_Entrada();
            frm_empleados.Show();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Frm_Stock frm_stock = new Frm_Stock();
            frm_stock.Show();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
                if (abm_usu_open == null)
                {
                abm_usu_open = new Frm_ABM_Usuario_Entrada();
                // To make absolutely sure:
                abm_usu_open.FormClosed += (o, ea) => abm_usu_open = null;
                }
                else
                {
                abm_usu_open.WindowState = FormWindowState.Normal;
                }
            abm_usu_open.Show();                        
            //Frm_ABM_Usuario_Entrada frm_usuario = new Frm_ABM_Usuario_Entrada();
            //frm_usuario.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SistemaCompras_Entrada frm_compras = new Frm_SistemaCompras_Entrada();
            frm_compras.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SistemaFacturas_Entrada frm_facturas = new Frm_SistemaFacturas_Entrada();
            frm_facturas.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Compras frm_reporte_compras = new Frm_Reporte_Compras();
            frm_reporte_compras.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Ventas frm_reporte_ventas = new Frm_Reporte_Ventas();
            frm_reporte_ventas.Show();
        }

        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_Estadisticas_Ventas frm_estadisticas_ventas = new Frm_Estadisticas_Ventas();
            frm_estadisticas_ventas.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Stock frm_stock = new Frm_Stock();
            frm_stock.Show();
        }

        private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_Estadisticas_Compras frm_estadisticas_compras = new Frm_Estadisticas_Compras();
            frm_estadisticas_compras.Show();
        }
    }
}
