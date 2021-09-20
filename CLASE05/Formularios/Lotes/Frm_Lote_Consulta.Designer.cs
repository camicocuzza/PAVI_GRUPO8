
namespace CLASE05.Formularios.Lotes
{
    partial class Frm_Lote_Consulta
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
            // txt_n_lote
            // 
            this.txt_n_lote.Enabled = false;
            // 
            // txt_n_remito
            // 
            this.txt_n_remito.Enabled = false;
            // 
            // txt_fecha_compra
            // 
            this.txt_fecha_compra.Enabled = false;
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
            // Frm_Lote_Consulta
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Datos del lote";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(438, 341);
            this.Name = "Frm_Lote_Consulta";
            this.Load += new System.EventHandler(this.Frm_Lote_Consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
