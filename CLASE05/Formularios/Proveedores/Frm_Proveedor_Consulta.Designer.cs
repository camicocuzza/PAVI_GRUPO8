
namespace CLASE05.Formularios.Proveedores
{
    partial class Frm_Proveedor_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedor_Consulta));
            this.SuspendLayout();
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Enabled = false;
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.DisplayMember = "legajo_empleado";
            this.cmb_empleado.Enabled = false;
            this.cmb_empleado.ValueMember = "legajo_empleado";
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
            // txt_direccion
            // 
            this.txt_direccion.Enabled = false;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.Enabled = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_cuit_p
            // 
            this.txt_cuit_p.Enabled = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(512, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(442, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(477, 2);
            // 
            // Frm_Proveedor_Consulta
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Datos del proveedor";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(547, 434);
            this.Name = "Frm_Proveedor_Consulta";
            this.Load += new System.EventHandler(this.Frm_Proveedor_Consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
