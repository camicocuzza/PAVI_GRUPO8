
namespace CLASE05.Formularios.Facturas
{
    partial class Frm_SistemaFacturas_Consulta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SistemaFacturas_Consulta));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.Text = "Datos de la venta";
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente.Enabled = false;
            // 
            // cmb_pais
            // 
            this.cmb_pais.DisplayMember = "nombre_pais";
            this.cmb_pais.ValueMember = "id_pais";
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia.DisplayMember = "nombre_estado_provincia";
            this.cmb_estado_provincia.ValueMember = "id_estado_provincia";
            // 
            // txt_total_venta
            // 
            this.txt_total_venta.Location = new System.Drawing.Point(900, 551);
            // 
            // txt_cantidad_articulo
            // 
            this.txt_cantidad_articulo.Enabled = false;
            // 
            // cmb_articulos
            // 
            this.cmb_articulos.DisplayMember = "nombre";
            this.cmb_articulos.Enabled = false;
            this.cmb_articulos.ValueMember = "cod_articulo";
            // 
            // cmb_ensamblados
            // 
            this.cmb_ensamblados.DisplayMember = "cod_prod_ensamblado";
            this.cmb_ensamblados.Enabled = false;
            this.cmb_ensamblados.ValueMember = "cod_prod_ensamblado";
            // 
            // txt_cantidad_ensamblado
            // 
            this.txt_cantidad_ensamblado.Enabled = false;
            // 
            // txt_fechaActual
            // 
            this.txt_fechaActual.Text = "7/10/2021 02:05:07";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Enabled = false;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar.FlatAppearance.BorderSize = 2;
            this.btn_buscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(897, 528);
            // 
            // btn_agregar_articulo
            // 
            this.btn_agregar_articulo.Enabled = false;
            this.btn_agregar_articulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_articulo.FlatAppearance.BorderSize = 2;
            this.btn_agregar_articulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            // 
            // btn_agregar_ensamblado
            // 
            this.btn_agregar_ensamblado.Enabled = false;
            this.btn_agregar_ensamblado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_ensamblado.FlatAppearance.BorderSize = 2;
            this.btn_agregar_ensamblado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            // 
            // btn_quitar_ensamblado
            // 
            this.btn_quitar_ensamblado.Enabled = false;
            this.btn_quitar_ensamblado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_ensamblado.FlatAppearance.BorderSize = 2;
            this.btn_quitar_ensamblado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            // 
            // btn_quitar_articulo
            // 
            this.btn_quitar_articulo.Enabled = false;
            this.btn_quitar_articulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_articulo.FlatAppearance.BorderSize = 2;
            this.btn_quitar_articulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            // 
            // btnMostrarFactura
            // 
            this.btnMostrarFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnMostrarFactura.FlatAppearance.BorderSize = 2;
            this.btnMostrarFactura.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnMostrarFactura.Location = new System.Drawing.Point(455, 555);
            this.btnMostrarFactura.Size = new System.Drawing.Size(189, 29);
            this.btnMostrarFactura.Click += new System.EventHandler(this.btnMostrarFactura_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGuardar.Location = new System.Drawing.Point(200, 564);
            this.btnGuardar.Size = new System.Drawing.Size(10, 29);
            this.btnGuardar.Visible = false;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnNuevaVenta.FlatAppearance.BorderSize = 2;
            this.btnNuevaVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnNuevaVenta.Location = new System.Drawing.Point(200, 564);
            this.btnNuevaVenta.Size = new System.Drawing.Size(10, 29);
            this.btnNuevaVenta.Visible = false;
            // 
            // txt_legajo_empleado
            // 
            this.txt_legajo_empleado.Enabled = false;
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura.DisplayMember = "nombre";
            this.cmb_tipo_factura.Enabled = false;
            this.cmb_tipo_factura.ValueMember = "id_tipo_factura";
            // 
            // txt_stock_articulo
            // 
            this.txt_stock_articulo.Visible = false;
            // 
            // label15
            // 
            this.label15.Enabled = false;
            this.label15.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(1024, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(954, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(989, 2);
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.ForeColor = System.Drawing.Color.White;
            // 
            // Frm_SistemaFacturas_Consulta
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1063, 596);
            this.Name = "Frm_SistemaFacturas_Consulta";
            this.Load += new System.EventHandler(this.Frm_SistemaFacturas_Consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
