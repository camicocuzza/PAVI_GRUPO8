namespace CLASE05.Formularios.InicioSistema
{
    partial class Frm_Login
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.flowLayoutPanel_contraseña = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_usuario = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(532, 1);
            this.btn_cerrar.Size = new System.Drawing.Size(24, 25);
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.Location = new System.Drawing.Point(433, 2);
            this.btn_minimizar.Visible = false;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.Location = new System.Drawing.Point(474, 2);
            this.btn_maximizar.Visible = false;
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.Location = new System.Drawing.Point(12, 4);
            // 
            // gb_login
            // 
            this.gb_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gb_login.Controls.Add(this.lbl_titulo);
            this.gb_login.Controls.Add(this.label5);
            this.gb_login.Controls.Add(this.btn_Ingresar);
            this.gb_login.Controls.Add(this.flowLayoutPanel_contraseña);
            this.gb_login.Controls.Add(this.flowLayoutPanel_usuario);
            this.gb_login.Controls.Add(this.txt_clave);
            this.gb_login.Controls.Add(this.txt_usuario);
            this.gb_login.Controls.Add(this.lbl_Contraseña);
            this.gb_login.Controls.Add(this.lbl_Usuario);
            this.gb_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_login.Location = new System.Drawing.Point(1, 26);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(555, 210);
            this.gb_login.TabIndex = 15;
            this.gb_login.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Silver;
            this.lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_titulo.Location = new System.Drawing.Point(236, 14);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(99, 22);
            this.lbl_titulo.TabIndex = 13;
            this.lbl_titulo.Text = "User Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(110, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "______________________________________________";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Ingresar.Location = new System.Drawing.Point(181, 152);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(236, 37);
            this.btn_Ingresar.TabIndex = 7;
            this.btn_Ingresar.Text = "Login";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // flowLayoutPanel_contraseña
            // 
            this.flowLayoutPanel_contraseña.BackgroundImage = global::CLASE05.Properties.Resources.images;
            this.flowLayoutPanel_contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_contraseña.Location = new System.Drawing.Point(423, 107);
            this.flowLayoutPanel_contraseña.Name = "flowLayoutPanel_contraseña";
            this.flowLayoutPanel_contraseña.Size = new System.Drawing.Size(26, 28);
            this.flowLayoutPanel_contraseña.TabIndex = 5;
            // 
            // flowLayoutPanel_usuario
            // 
            this.flowLayoutPanel_usuario.BackgroundImage = global::CLASE05.Properties.Resources.images__1_;
            this.flowLayoutPanel_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_usuario.Location = new System.Drawing.Point(423, 58);
            this.flowLayoutPanel_usuario.Name = "flowLayoutPanel_usuario";
            this.flowLayoutPanel_usuario.Size = new System.Drawing.Size(26, 27);
            this.flowLayoutPanel_usuario.TabIndex = 4;
            // 
            // txt_clave
            // 
            this.txt_clave.AcceptsTab = true;
            this.txt_clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clave.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_clave.Location = new System.Drawing.Point(181, 108);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(236, 27);
            this.txt_clave.TabIndex = 2;
            this.txt_clave.UseSystemPasswordChar = true;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_KeyPress);
            // 
            // txt_usuario
            // 
            this.txt_usuario.AcceptsTab = true;
            this.txt_usuario.AccessibleDescription = "";
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F);
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_usuario.Location = new System.Drawing.Point(181, 58);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(236, 27);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Contraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Contraseña.Location = new System.Drawing.Point(91, 109);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(84, 21);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Password";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Usuario.Location = new System.Drawing.Point(91, 59);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(88, 21);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Username";
            // 
            // Frm_Login
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(557, 237);
            this.Controls.Add(this.gb_login);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.gb_login, 0);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_contraseña;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_usuario;
        public System.Windows.Forms.TextBox txt_clave;
        public System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Usuario;
    }
}
