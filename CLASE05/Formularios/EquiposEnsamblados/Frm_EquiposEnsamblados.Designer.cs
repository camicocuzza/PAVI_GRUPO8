
namespace CLASE05.Formularios.EquiposEnsamblados
{
    partial class Frm_EquiposEnsamblados
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
            this.txt_cod_p_ensamblado = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_precio = new CLASE05.Clases.LabelText02();
            this.txt_nombre = new CLASE05.Clases.LabelText02();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(377, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(307, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(342, 2);
            // 
            // txt_cod_p_ensamblado
            // 
            this.txt_cod_p_ensamblado._Ancho = 15;
            this.txt_cod_p_ensamblado._Decimales = 0;
            this.txt_cod_p_ensamblado._Etiqueta = "Código Equipo Ensamblado";
            this.txt_cod_p_ensamblado._Mask = "CCCCCCCCCCCCCCC";
            this.txt_cod_p_ensamblado._MensajeError = "El nombre está vacío";
            this.txt_cod_p_ensamblado._Nombre_campo = null;
            this.txt_cod_p_ensamblado._Nombre_tabla = null;
            this.txt_cod_p_ensamblado._ReadOnly = false;
            this.txt_cod_p_ensamblado._StartEnCero = false;
            this.txt_cod_p_ensamblado._Text = "";
            this.txt_cod_p_ensamblado._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cod_p_ensamblado._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_cod_p_ensamblado._Validable = true;
            this.txt_cod_p_ensamblado.BackColor = System.Drawing.Color.Transparent;
            this.txt_cod_p_ensamblado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_cod_p_ensamblado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cod_p_ensamblado.Location = new System.Drawing.Point(41, 112);
            this.txt_cod_p_ensamblado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cod_p_ensamblado.Name = "txt_cod_p_ensamblado";
            this.txt_cod_p_ensamblado.Size = new System.Drawing.Size(260, 30);
            this.txt_cod_p_ensamblado.TabIndex = 61;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(143, 286);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 56;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_titulo.Location = new System.Drawing.Point(35, 52);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 55;
            this.lbl_titulo.Text = "Titulo";
            // 
            // txt_precio
            // 
            this.txt_precio._Ancho = 10;
            this.txt_precio._Decimales = 2;
            this.txt_precio._Etiqueta = "Precio";
            this.txt_precio._Mask = "9999999.99";
            this.txt_precio._MensajeError = "El precio está vacío";
            this.txt_precio._Nombre_campo = "precio";
            this.txt_precio._Nombre_tabla = null;
            this.txt_precio._ReadOnly = false;
            this.txt_precio._StartEnCero = true;
            this.txt_precio._Text = "       .";
            this.txt_precio._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_precio._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_precio._Validable = true;
            this.txt_precio.BackColor = System.Drawing.Color.Transparent;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_precio.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precio.Location = new System.Drawing.Point(41, 150);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(257, 30);
            this.txt_precio.TabIndex = 68;
            this.txt_precio.Click += new System.EventHandler(this.txt_precio_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 50;
            this.txt_nombre._Decimales = 0;
            this.txt_nombre._Etiqueta = "Nombre";
            this.txt_nombre._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nombre._MensajeError = "El stock está vacío";
            this.txt_nombre._Nombre_campo = "stock";
            this.txt_nombre._Nombre_tabla = null;
            this.txt_nombre._ReadOnly = false;
            this.txt_nombre._StartEnCero = false;
            this.txt_nombre._Text = "";
            this.txt_nombre._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombre._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_nombre._Validable = true;
            this.txt_nombre.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombre.Location = new System.Drawing.Point(38, 188);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(260, 30);
            this.txt_nombre.TabIndex = 69;
            // 
            // Frm_EquiposEnsamblados
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(414, 360);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cod_p_ensamblado);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_EquiposEnsamblados";
            this.Load += new System.EventHandler(this.Frm_EquiposEnsamblados_Load);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.txt_cod_p_ensamblado, 0);
            this.Controls.SetChildIndex(this.txt_precio, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected Clases.LabelText02 txt_cod_p_ensamblado;
        public System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_titulo;
        public Clases.LabelText02 txt_precio;
        public Clases.LabelText02 txt_nombre;
    }
}
