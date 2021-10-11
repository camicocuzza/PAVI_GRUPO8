
namespace CLASE05.Formularios._FrmBASE
{
    partial class FrmBase_Prueba_ABM_Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase_Prueba_ABM_Entrada));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_legajo_empleado = new System.Windows.Forms.RadioButton();
            this.rb_nombre_contacto = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_cuit_cliente = new System.Windows.Forms.RadioButton();
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.rb_razon_social = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.grid_clientes = new CLASE05.Clases.Grid01();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Location = new System.Drawing.Point(-152, 524);
            this.btn_alta.Visible = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Location = new System.Drawing.Point(-91, 524);
            this.btn_modificar.Visible = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar.BackgroundImage")));
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Location = new System.Drawing.Point(-44, 563);
            this.btn_borrar.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.Text = "Clientes";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Location = new System.Drawing.Point(-214, 523);
            this.btn_consultar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_legajo_empleado);
            this.groupBox1.Controls.Add(this.rb_nombre_contacto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb_cuit_cliente);
            this.groupBox1.Controls.Add(this.btn_blan_patron);
            this.groupBox1.Controls.Add(this.rb_razon_social);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Location = new System.Drawing.Point(53, 70);
            this.groupBox1.Size = new System.Drawing.Size(699, 159);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_razon_social, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_blan_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_cuit_cliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_nombre_contacto, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_legajo_empleado, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_todos, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.Location = new System.Drawing.Point(603, 122);
            this.btn_buscar.Size = new System.Drawing.Size(90, 30);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(816, 1);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(746, 1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(781, 1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(756, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(51, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(756, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(756, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 25);
            this.button4.TabIndex = 9;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos.Location = new System.Drawing.Point(460, 128);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(64, 21);
            this.rb_todos.TabIndex = 38;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // rb_legajo_empleado
            // 
            this.rb_legajo_empleado.AutoSize = true;
            this.rb_legajo_empleado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_legajo_empleado.Location = new System.Drawing.Point(323, 128);
            this.rb_legajo_empleado.Name = "rb_legajo_empleado";
            this.rb_legajo_empleado.Size = new System.Drawing.Size(131, 21);
            this.rb_legajo_empleado.TabIndex = 37;
            this.rb_legajo_empleado.TabStop = true;
            this.rb_legajo_empleado.Text = "Legajo empleado";
            this.rb_legajo_empleado.UseVisualStyleBackColor = true;
            // 
            // rb_nombre_contacto
            // 
            this.rb_nombre_contacto.AutoSize = true;
            this.rb_nombre_contacto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_nombre_contacto.Location = new System.Drawing.Point(182, 128);
            this.rb_nombre_contacto.Name = "rb_nombre_contacto";
            this.rb_nombre_contacto.Size = new System.Drawing.Size(135, 21);
            this.rb_nombre_contacto.TabIndex = 36;
            this.rb_nombre_contacto.TabStop = true;
            this.rb_nombre_contacto.Text = "Nombre contacto";
            this.rb_nombre_contacto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Buscar por:";
            // 
            // rb_cuit_cliente
            // 
            this.rb_cuit_cliente.AutoSize = true;
            this.rb_cuit_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_cuit_cliente.Location = new System.Drawing.Point(10, 128);
            this.rb_cuit_cliente.Name = "rb_cuit_cliente";
            this.rb_cuit_cliente.Size = new System.Drawing.Size(57, 21);
            this.rb_cuit_cliente.TabIndex = 33;
            this.rb_cuit_cliente.TabStop = true;
            this.rb_cuit_cliente.Text = "CUIT";
            this.rb_cuit_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_blan_patron
            // 
            this.btn_blan_patron.BackColor = System.Drawing.Color.Transparent;
            this.btn_blan_patron.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__7_;
            this.btn_blan_patron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_blan_patron.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatAppearance.BorderSize = 0;
            this.btn_blan_patron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blan_patron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.Location = new System.Drawing.Point(431, 41);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_patron.TabIndex = 34;
            this.btn_blan_patron.TabStop = false;
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            // 
            // rb_razon_social
            // 
            this.rb_razon_social.AutoSize = true;
            this.rb_razon_social.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_razon_social.Location = new System.Drawing.Point(73, 128);
            this.rb_razon_social.Name = "rb_razon_social";
            this.rb_razon_social.Size = new System.Drawing.Size(103, 21);
            this.rb_razon_social.TabIndex = 31;
            this.rb_razon_social.TabStop = true;
            this.rb_razon_social.Text = "Razón social";
            this.rb_razon_social.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(153, 48);
            this.txt_patron.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(253, 25);
            this.txt_patron.TabIndex = 30;
            // 
            // grid_clientes
            // 
            this.grid_clientes._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_clientes._tamannoLetraHeader = 9;
            this.grid_clientes.AllowUserToAddRows = false;
            this.grid_clientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_clientes.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clientes.Location = new System.Drawing.Point(53, 235);
            this.grid_clientes.Name = "grid_clientes";
            this.grid_clientes.ReadOnly = true;
            this.grid_clientes.Size = new System.Drawing.Size(699, 190);
            this.grid_clientes.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 474);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBase_Prueba_ABM_Entrada
            // 
            this._PosiciónVisible = true;
            this._titulo = "Clientes";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(851, 475);
            this.Controls.Add(this.grid_clientes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmBase_Prueba_ABM_Entrada";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.grid_clientes, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_consultar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_legajo_empleado;
        private System.Windows.Forms.RadioButton rb_nombre_contacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_cuit_cliente;
        private System.Windows.Forms.Button btn_blan_patron;
        private System.Windows.Forms.RadioButton rb_razon_social;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private Clases.Grid01 grid_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
