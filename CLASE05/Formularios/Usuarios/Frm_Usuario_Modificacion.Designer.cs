
namespace CLASE05.Formularios.Usuarios
{
    partial class Frm_Usuario_Modificacion
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
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Location = new System.Drawing.Point(27, 51);
            this.lbl_titulo.Size = new System.Drawing.Size(321, 31);
            this.lbl_titulo.Text = "Modificaciones de Usuario";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(397, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(327, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(362, 2);
            // 
            // Frm_Usuario_Modificacion
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Modificaciones de Usuario";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(432, 384);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Usuario_Modificacion";
            this.Load += new System.EventHandler(this.Frm_Usuario_Modificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
