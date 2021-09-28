
namespace CLASE05.Formularios.Clientes
{
    partial class Frm_Cliente_Alta
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
            this.SuspendLayout();
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente.TabIndex = 1;
            // 
            // cmb_pais
            // 
            this.cmb_pais.TabIndex = 7;
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia.TabIndex = 8;
            // 
            // txt_legajo_empleado
            // 
            this.txt_legajo_empleado.TabIndex = 5;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.TabIndex = 9;
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.TabIndex = 2;
            // 
            // txt_direccion
            // 
            this.txt_direccion.TabIndex = 6;
            // 
            // txt_nombre_contacto
            // 
            this.txt_nombre_contacto.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(195, 31);
            this.label3.Text = "Altas de Cliente";
            this.label3.Visible = true;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // Frm_Cliente_Alta
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(516, 516);
            this.Name = "Frm_Cliente_Alta";
            this.Activated += new System.EventHandler(this.Frm_Cliente_Alta_Activated);
            this.Load += new System.EventHandler(this.Frm_Cliente_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
