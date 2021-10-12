
namespace CLASE05.Formularios.Compras
{
    partial class Frm_SistemaCompras_Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SistemaCompras_Alta));
            this.btn_nueva_compra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_eliminar_a
            // 
            this.btn_eliminar_a.Click += new System.EventHandler(this.btn_eliminar_a_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.DisplayMember = "razon_social";
            this.cmb_proveedor.ValueMember = "cuit_proveedor";
            this.cmb_proveedor.SelectedIndexChanged += new System.EventHandler(this.cmb_proveedor_SelectedIndexChanged);
            // 
            // txt_total
            // 
            this.txt_total.Text = "$0";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(787, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(717, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(752, 2);
            // 
            // btn_nueva_compra
            // 
            this.btn_nueva_compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_nueva_compra.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_nueva_compra.Location = new System.Drawing.Point(45, 411);
            this.btn_nueva_compra.Name = "btn_nueva_compra";
            this.btn_nueva_compra.Size = new System.Drawing.Size(118, 30);
            this.btn_nueva_compra.TabIndex = 107;
            this.btn_nueva_compra.Text = "Nueva Compra";
            this.btn_nueva_compra.UseVisualStyleBackColor = false;
            this.btn_nueva_compra.Click += new System.EventHandler(this.btn_nueva_compra_Click);
            // 
            // Frm_SistemaCompras_Alta
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Agregar Compra";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(824, 464);
            this.Controls.Add(this.btn_nueva_compra);
            this.Name = "Frm_SistemaCompras_Alta";
            this.Load += new System.EventHandler(this.Frm_SistemaCompras_Alta_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_cantidad, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.cmb_articulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btn_eliminar_a, 0);
            this.Controls.SetChildIndex(this.cmb_proveedor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.txt_fecha, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_total, 0);
            this.Controls.SetChildIndex(this.btn_grabar, 0);
            this.Controls.SetChildIndex(this.txt_fecha_inicio, 0);
            this.Controls.SetChildIndex(this.txt_direccion, 0);
            this.Controls.SetChildIndex(this.txt_cuit_p, 0);
            this.Controls.SetChildIndex(this.btn_nueva_compra, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_nueva_compra;
    }
}
