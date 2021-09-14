
namespace CLASE05.Formularios.Clientes
{
    partial class Frm_Cliente_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente_Consulta));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_pais
            // 
            this.cmb_pais.DisplayMember = "nombre_pais";
            this.cmb_pais.Enabled = false;
            this.cmb_pais.ValueMember = "id_pais";
            this.cmb_pais.SelectedIndexChanged += new System.EventHandler(this.cmb_pais_SelectedIndexChanged);
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Enabled = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Enabled = false;
            // 
            // txt_legajo_empleado
            // 
            this.txt_legajo_empleado.Enabled = false;
            // 
            // txt_nombre_contacto
            // 
            this.txt_nombre_contacto.Enabled = false;
            // 
            // txt_limite_credito
            // 
            
            this.txt_limite_credito.Enabled = false;
            this.txt_limite_credito.Size = new System.Drawing.Size(268, 30);
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Enabled = false;
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia.Enabled = false;
            this.cmb_estado_provincia.Text = "";
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente.Enabled = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(205, 31);
            this.lbl_titulo.Text = "Datos de Cliente";
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
            // Frm_Cliente_Consulta
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Datos de Cliente";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(449, 546);
            this.Name = "Frm_Cliente_Consulta";
            this.Load += new System.EventHandler(this.Frm_Cliente_Consulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
