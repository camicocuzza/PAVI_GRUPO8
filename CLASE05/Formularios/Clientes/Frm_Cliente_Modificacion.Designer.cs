
namespace CLASE05.Formularios.Clientes
{
    partial class Frm_Cliente_Modificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente_Modificacion));
            this.SuspendLayout();
            // 
            // cmb_pais
            // 
            this.cmb_pais.DisplayMember = "nombre_pais";
            this.cmb_pais.ValueMember = "id_pais";
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia.DisplayMember = "nombre_estado_provincia";
            this.cmb_estado_provincia.Text = "";
            this.cmb_estado_provincia.ValueMember = "id_estado_provincia";
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente.Enabled = false;
            this.txt_cuit_cliente.Size = new System.Drawing.Size(318, 25);
            // 
            // txt_limite_credito
            // 
            this.txt_limite_credito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(204, 475);
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(315, 31);
            this.lbl_titulo.Text = "Modificaciones de Cliente";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_minimizar.Enabled = true;
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // Frm_Cliente_Modificacion
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Modificaciones de Cliente";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(516, 516);
            this.Name = "Frm_Cliente_Modificacion";
            this.Load += new System.EventHandler(this.Frm_Cliente_Modificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
