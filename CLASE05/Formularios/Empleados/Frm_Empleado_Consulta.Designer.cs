
namespace CLASE05.Formularios.Empleados
{
    partial class Frm_Empleado_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Consulta));
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            // 
            // cmb_tipo_documento
            // 
            this.cmb_tipo_documento.DisplayMember = "nombre";
            this.cmb_tipo_documento.Enabled = false;
            this.cmb_tipo_documento.ValueMember = "id_tipo_documento";
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia.DisplayMember = "nombre_estado_provincia";
            this.cmb_estado_provincia.Enabled = false;
            this.cmb_estado_provincia.ValueMember = "id_estado_provincia";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Enabled = false;
            // 
            // txt_legajo
            // 
            this.txt_legajo.Enabled = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Enabled = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Enabled = false;
            // 
            // txt_n_documento
            // 
            this.txt_n_documento.Enabled = false;
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Enabled = false;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
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
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // Frm_Empleado_Consulta
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Datos del empleado";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 446);
            this.Name = "Frm_Empleado_Consulta";
            this.Load += new System.EventHandler(this.Frm_Empleado_Consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
