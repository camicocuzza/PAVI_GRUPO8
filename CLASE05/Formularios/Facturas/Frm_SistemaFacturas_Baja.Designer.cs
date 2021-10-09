
namespace CLASE05.Formularios.Facturas
{
    partial class Frm_SistemaFacturas_Baja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SistemaFacturas_Baja));
            this.btn_eliminar_venta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_limite
            // 
            this.txt_limite.Enabled = false;
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
            // txt_ciudad
            // 
            this.txt_ciudad.Enabled = false;
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Enabled = false;
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
            // btn_buscar
            // 
            this.btn_buscar.Enabled = false;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar.FlatAppearance.BorderSize = 2;
            this.btn_buscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
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
            this.btnMostrarFactura.Location = new System.Drawing.Point(164, 562);
            this.btnMostrarFactura.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGuardar.Location = new System.Drawing.Point(164, 563);
            this.btnGuardar.Visible = false;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnNuevaVenta.FlatAppearance.BorderSize = 2;
            this.btnNuevaVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnNuevaVenta.Location = new System.Drawing.Point(164, 563);
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
            // btn_eliminar_venta
            // 
            this.btn_eliminar_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_eliminar_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_venta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_eliminar_venta.FlatAppearance.BorderSize = 2;
            this.btn_eliminar_venta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_eliminar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_venta.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_venta.Location = new System.Drawing.Point(476, 563);
            this.btn_eliminar_venta.Name = "btn_eliminar_venta";
            this.btn_eliminar_venta.Size = new System.Drawing.Size(123, 29);
            this.btn_eliminar_venta.TabIndex = 120;
            this.btn_eliminar_venta.TabStop = false;
            this.btn_eliminar_venta.Text = "Eliminar Venta";
            this.btn_eliminar_venta.UseVisualStyleBackColor = false;
            this.btn_eliminar_venta.Click += new System.EventHandler(this.btn_eliminar_venta_Click);
            // 
            // Frm_SistemaFacturas_Baja
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1063, 667);
            this.Controls.Add(this.btn_eliminar_venta);
            this.Name = "Frm_SistemaFacturas_Baja";
            this.Load += new System.EventHandler(this.Frm_SistemaFacturas_Baja_Load);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.txt_stock_ensamblado, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_razon_social, 0);
            this.Controls.SetChildIndex(this.txt_ciudad, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lbl_pais, 0);
            this.Controls.SetChildIndex(this.cmb_estado_provincia, 0);
            this.Controls.SetChildIndex(this.lbl_estado_provincia, 0);
            this.Controls.SetChildIndex(this.cmb_pais, 0);
            this.Controls.SetChildIndex(this.txt_cuit_cliente, 0);
            this.Controls.SetChildIndex(this.txt_limite, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txt_total_venta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_precio_articulo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_cantidad_articulo, 0);
            this.Controls.SetChildIndex(this.cmb_articulos, 0);
            this.Controls.SetChildIndex(this.btn_agregar_articulo, 0);
            this.Controls.SetChildIndex(this.btn_agregar_ensamblado, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txt_precio_ensamblado, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txt_cantidad_ensamblado, 0);
            this.Controls.SetChildIndex(this.cmb_ensamblados, 0);
            this.Controls.SetChildIndex(this.txt_fechaActual, 0);
            this.Controls.SetChildIndex(this.btn_quitar_ensamblado, 0);
            this.Controls.SetChildIndex(this.btn_quitar_articulo, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btnNuevaVenta, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnMostrarFactura, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txt_legajo_empleado, 0);
            this.Controls.SetChildIndex(this.cmb_tipo_factura, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txt_stock_articulo, 0);
            this.Controls.SetChildIndex(this.btn_eliminar_venta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_eliminar_venta;
    }
}
