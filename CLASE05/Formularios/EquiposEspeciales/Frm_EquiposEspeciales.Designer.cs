
namespace CLASE05.Formularios.EquiposEspeciales
{
    partial class Frm_EquiposEspeciales
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.ofdSeleccionar = new System.Windows.Forms.OpenFileDialog();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_equipos = new CLASE05.Clases.ComboBox01();
            this.cmb_clientes = new CLASE05.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(383, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(313, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(348, 2);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_titulo.Location = new System.Drawing.Point(35, 52);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 69;
            this.lbl_titulo.Text = "Titulo";
            // 
            // ofdSeleccionar
            // 
            this.ofdSeleccionar.FileName = "openFileDialog1";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(159, 388);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 70;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(56, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Equipo ensamblado";
            // 
            // cmb_equipos
            // 
            this.cmb_equipos._ComboSinSeleccion = true;
            this.cmb_equipos._MensajeError = "Seleccionar Equipo ensamblado";
            this.cmb_equipos._Nombre_campo = null;
            this.cmb_equipos._Nombre_tabla = "";
            this.cmb_equipos._tabla_cargar_combo = "producto_ensamblado";
            this.cmb_equipos._tabla_cargar_descriptor = "cod_prod_ensamblado";
            this.cmb_equipos._tabla_cargar_pk = "cod_prod_ensamblado";
            this.cmb_equipos._Validable = true;
            this.cmb_equipos.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmb_equipos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_equipos.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_equipos.FormattingEnabled = true;
            this.cmb_equipos.Location = new System.Drawing.Point(191, 120);
            this.cmb_equipos.Name = "cmb_equipos";
            this.cmb_equipos.Size = new System.Drawing.Size(107, 25);
            this.cmb_equipos.TabIndex = 76;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes._ComboSinSeleccion = true;
            this.cmb_clientes._MensajeError = "Seleccionar cliente";
            this.cmb_clientes._Nombre_campo = null;
            this.cmb_clientes._Nombre_tabla = "";
            this.cmb_clientes._tabla_cargar_combo = "cliente";
            this.cmb_clientes._tabla_cargar_descriptor = "razon_social";
            this.cmb_clientes._tabla_cargar_pk = "cuit_cliente";
            this.cmb_clientes._Validable = true;
            this.cmb_clientes.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmb_clientes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_clientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(191, 151);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(107, 25);
            this.cmb_clientes.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(133, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cliente";
            // 
            // Frm_EquiposEspeciales
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(420, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_equipos);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_EquiposEspeciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_EquiposEspeciales_Load);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.cmb_equipos, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmb_clientes, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionar;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label label3;
        public Clases.ComboBox01 cmb_equipos;
        public Clases.ComboBox01 cmb_clientes;
        public System.Windows.Forms.Label label1;
    }
}
