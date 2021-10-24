
namespace CLASE05.Formularios.Usuarios
{
    partial class Frm_Usuario
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_password = new CLASE05.Clases.LabelText02();
            this.txt_n_usuario = new CLASE05.Clases.LabelText02();
            this.txt_id_usuario = new CLASE05.Clases.LabelText02();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(405, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Enabled = false;
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(335, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Enabled = false;
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(370, 2);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(164, 329);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(44, 48);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 25;
            this.lbl_titulo.Text = "Titulo";
            // 
            // txt_password
            // 
            this.txt_password._Ancho = 20;
            this.txt_password._Decimales = 2;
            this.txt_password._Etiqueta = "Password";
            this.txt_password._Mask = "CCCCCCCCCCCCCCCCCCCC";
            this.txt_password._MensajeError = "Ingresar password";
            this.txt_password._Nombre_campo = null;
            this.txt_password._Nombre_tabla = null;
            this.txt_password._ReadOnly = false;
            this.txt_password._StartEnCero = false;
            this.txt_password._Text = "";
            this.txt_password._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_password._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_password._Validable = true;
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_password.Location = new System.Drawing.Point(4, 232);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(327, 53);
            this.txt_password.TabIndex = 15;
            // 
            // txt_n_usuario
            // 
            this.txt_n_usuario._Ancho = 20;
            this.txt_n_usuario._Decimales = 2;
            this.txt_n_usuario._Etiqueta = "Nombre Usuario";
            this.txt_n_usuario._Mask = "CCCCCCCCCCCCCCCCCCCC";
            this.txt_n_usuario._MensajeError = "Ingresar nombre de usuario";
            this.txt_n_usuario._Nombre_campo = "n_usuario";
            this.txt_n_usuario._Nombre_tabla = null;
            this.txt_n_usuario._ReadOnly = false;
            this.txt_n_usuario._StartEnCero = false;
            this.txt_n_usuario._Text = "";
            this.txt_n_usuario._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_usuario._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_n_usuario._Validable = true;
            this.txt_n_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_usuario.Location = new System.Drawing.Point(4, 180);
            this.txt_n_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_usuario.Name = "txt_n_usuario";
            this.txt_n_usuario.Size = new System.Drawing.Size(327, 53);
            this.txt_n_usuario.TabIndex = 14;
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario._Ancho = 5;
            this.txt_id_usuario._Decimales = 0;
            this.txt_id_usuario._Etiqueta = "Id Usuario";
            this.txt_id_usuario._Mask = "99999";
            this.txt_id_usuario._MensajeError = null;
            this.txt_id_usuario._Nombre_campo = "id_usuario";
            this.txt_id_usuario._Nombre_tabla = null;
            this.txt_id_usuario._ReadOnly = false;
            this.txt_id_usuario._StartEnCero = false;
            this.txt_id_usuario._Text = "";
            this.txt_id_usuario._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_usuario._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_id_usuario._Validable = false;
            this.txt_id_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_usuario.Enabled = false;
            this.txt_id_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_usuario.Location = new System.Drawing.Point(4, 129);
            this.txt_id_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(216, 28);
            this.txt_id_usuario.TabIndex = 13;
            // 
            // Frm_Usuario
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(442, 384);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_id_usuario);
            this.Controls.Add(this.txt_n_usuario);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_titulo);
            this.Location = new System.Drawing.Point(766, 183);
            this.Name = "Frm_Usuario";
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.txt_n_usuario, 0);
            this.Controls.SetChildIndex(this.txt_id_usuario, 0);
            this.Controls.SetChildIndex(this.txt_password, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label lbl_titulo;
        public Clases.LabelText02 txt_password;
        public Clases.LabelText02 txt_n_usuario;
        public Clases.LabelText02 txt_id_usuario;
    }
}
