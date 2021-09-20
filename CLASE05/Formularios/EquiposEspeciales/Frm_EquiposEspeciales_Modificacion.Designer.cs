
namespace CLASE05.Formularios.EquiposEspeciales
{
    partial class Frm_EquiposEspeciales_Modificacion
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
            this.btn_aceptar.Location = new System.Drawing.Point(181, 385);
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // cmb_equipos
            // 
            this.cmb_equipos._ComboSinSeleccion = false;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes._ComboSinSeleccion = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(429, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(359, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(394, 2);
            // 
            // Frm_EquiposEspeciales_Modificacion
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Modificación de Equipo Especial";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(466, 444);
            this.Name = "Frm_EquiposEspeciales_Modificacion";
            this.Load += new System.EventHandler(this.Frm_EquiposEspeciales_Modificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
