
namespace CLASE05.Formularios.EquiposEspeciales
{
    partial class Frm_EquiposEspeciales_Baja
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
            this.btn_aceptar.Text = "Borrar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label3
            // 
            this.label3.Enabled = false;
            // 
            // cmb_equipos
            // 
            this.cmb_equipos._ComboSinSeleccion = false;
            this.cmb_equipos.Enabled = false;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes._ComboSinSeleccion = false;
            this.cmb_clientes.Enabled = false;
            // 
            // label1
            // 
            this.label1.Enabled = false;
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
            // Frm_EquiposEspeciales_Baja
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Baja de Equipo Especial";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(420, 444);
            this.Name = "Frm_EquiposEspeciales_Baja";
            this.Load += new System.EventHandler(this.Frm_EquiposEspeciales_Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
