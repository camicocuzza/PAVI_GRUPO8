
namespace CLASE05.Formularios.Clientes
{
    partial class Frm_Cliente_Baja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente_Baja));
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
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(197, 31);
            this.lbl_titulo.Text = "Bajas de Cliente";
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
            // Frm_Cliente_Baja1
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Bajas de Cliente";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(516, 516);
            this.Name = "Frm_Cliente_Baja1";
            this.Load += new System.EventHandler(this.Frm_Cliente_Baja1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
