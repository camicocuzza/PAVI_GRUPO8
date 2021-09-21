
namespace CLASE05.Formularios.EquiposEnsamblados
{
    partial class Frm_EquiposEnsamblados_Baja
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
            // txt_cod_p_ensamblado
            // 
            this.txt_cod_p_ensamblado.Enabled = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Text = "Borrar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            // 
            // txt_stock
            // 
            this.txt_stock.Enabled = false;
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
            // Frm_EquiposEnsamblados_Baja
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Baja de Equipo Ensamblado";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(414, 360);
            this.Name = "Frm_EquiposEnsamblados_Baja";
            this.Load += new System.EventHandler(this.Frm_EquiposEnsamblados_Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
