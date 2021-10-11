
namespace CLASE05.Formularios.Proveedores
{
    partial class Frm_Proveedor_Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedor_Alta));
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.DisplayMember = "legajo_empleado";
            this.cmb_empleado.ValueMember = "legajo_empleado";
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia.DisplayMember = "nombre_estado_provincia";
            this.cmb_estado_provincia.ValueMember = "id_estado_provincia";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(441, 3);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(476, 3);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::CLASE05.Properties.Resources.btn_cerrar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(511, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 28);
            this.button3.TabIndex = 87;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Frm_Proveedor_Alta
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Alta de Proveedor";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(547, 434);
            this.Controls.Add(this.button3);
            this.Name = "Frm_Proveedor_Alta";
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.txt_fecha_inicio, 0);
            this.Controls.SetChildIndex(this.txt_direccion, 0);
            this.Controls.SetChildIndex(this.txt_ciudad, 0);
            this.Controls.SetChildIndex(this.cmb_estado_provincia, 0);
            this.Controls.SetChildIndex(this.cmb_empleado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_razon_social, 0);
            this.Controls.SetChildIndex(this.txt_cuit_p, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button3;
    }
}
