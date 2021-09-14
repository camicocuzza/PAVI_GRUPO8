
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
            // txt_ciudad
            // 
            this.txt_ciudad._MensajeError = "Ciudad está vacía";
            // 
            // txt_direccion
            // 
            this.txt_direccion._MensajeError = "Dirección está vacía";
            // 
            // txt_legajo_empleado
            // 
            this.txt_legajo_empleado._MensajeError = "Legajo del empleado está vacío";
            // 
            // txt_nombre_contacto
            // 
            this.txt_nombre_contacto._MensajeError = "El nombre del contacto está vacío";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social._MensajeError = "Razón social está vacía";
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia.DisplayMember = "nombre_estado_provincia";
            this.cmb_estado_provincia.Text = "";
            this.cmb_estado_provincia.ValueMember = "id_estado_provincia";
            // 
            // txt_limite_credito
            // 
            this.txt_limite_credito.Tag = "Límite de crédito está vacío";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(301, 31);
            this.lbl_titulo.Text = "Modificación de Clientes";
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
            // Frm_Cliente_Modificacion
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Modificación de Clientes";
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
