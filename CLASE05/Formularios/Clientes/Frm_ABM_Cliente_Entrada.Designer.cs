
namespace CLASE05.Formularios.Clientes
{
    partial class Frm_ABM_Cliente_Entrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_cuit_cliente = new System.Windows.Forms.RadioButton();
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.rb_razon_social = new System.Windows.Forms.RadioButton();
            this.txt_cuit_cliente = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.rb_nombre_contacto = new System.Windows.Forms.RadioButton();
            this.grid_clientes = new CLASE05.Clases.Grid01();
            this.rb_legajo_empleado = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Location = new System.Drawing.Point(599, 390);
            this.btn_borrar.Size = new System.Drawing.Size(56, 47);
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.Text = "ABM Cliente";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
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
            this.groupBox1.Controls.Add(this.txt_cuit_cliente);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Size = new System.Drawing.Size(645, 116);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_cuit_cliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_razon_social, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_blan_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_cuit_cliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_nombre_contacto, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_legajo_empleado, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_todos, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(554, 79);
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Columna de búsqueda";
            // 
            // rb_cuit_cliente
            // 
            this.rb_cuit_cliente.AutoSize = true;
            this.rb_cuit_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_cuit_cliente.Location = new System.Drawing.Point(10, 87);
            this.rb_cuit_cliente.Name = "rb_cuit_cliente";
            this.rb_cuit_cliente.Size = new System.Drawing.Size(98, 21);
            this.rb_cuit_cliente.TabIndex = 23;
            this.rb_cuit_cliente.TabStop = true;
            this.rb_cuit_cliente.Text = "cuit_cliente";
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
            this.btn_blan_patron.Location = new System.Drawing.Point(314, 34);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_patron.TabIndex = 25;
            this.btn_blan_patron.TabStop = false;
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            this.btn_blan_patron.Click += new System.EventHandler(this.btn_blan_patron_Click);
            // 
            // rb_razon_social
            // 
            this.rb_razon_social.AutoSize = true;
            this.rb_razon_social.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_razon_social.Location = new System.Drawing.Point(381, 37);
            this.rb_razon_social.Name = "rb_razon_social";
            this.rb_razon_social.Size = new System.Drawing.Size(102, 21);
            this.rb_razon_social.TabIndex = 21;
            this.rb_razon_social.TabStop = true;
            this.rb_razon_social.Text = "razon_social";
            this.rb_razon_social.UseVisualStyleBackColor = true;
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_cuit_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit_cliente.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_cuit_cliente.Location = new System.Drawing.Point(125, 83);
            this.txt_cuit_cliente.Mask = "99-99999999-9";
            this.txt_cuit_cliente.Name = "txt_cuit_cliente";
            this.txt_cuit_cliente.Size = new System.Drawing.Size(142, 25);
            this.txt_cuit_cliente.TabIndex = 24;
            this.txt_cuit_cliente.Click += new System.EventHandler(this.txt_cuit_cliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Patrón Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(125, 44);
            this.txt_patron.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(183, 25);
            this.txt_patron.TabIndex = 20;
            this.txt_patron.Click += new System.EventHandler(this.txt_patron_Click);
            // 
            // rb_nombre_contacto
            // 
            this.rb_nombre_contacto.AutoSize = true;
            this.rb_nombre_contacto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_nombre_contacto.Location = new System.Drawing.Point(493, 37);
            this.rb_nombre_contacto.Name = "rb_nombre_contacto";
            this.rb_nombre_contacto.Size = new System.Drawing.Size(135, 21);
            this.rb_nombre_contacto.TabIndex = 27;
            this.rb_nombre_contacto.TabStop = true;
            this.rb_nombre_contacto.Text = "nombre_contacto";
            this.rb_nombre_contacto.UseVisualStyleBackColor = true;
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
            this.grid_clientes.Location = new System.Drawing.Point(12, 203);
            this.grid_clientes.Name = "grid_clientes";
            this.grid_clientes.ReadOnly = true;
            this.grid_clientes.Size = new System.Drawing.Size(645, 178);
            this.grid_clientes.TabIndex = 8;
            // 
            // rb_legajo_empleado
            // 
            this.rb_legajo_empleado.AutoSize = true;
            this.rb_legajo_empleado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_legajo_empleado.Location = new System.Drawing.Point(380, 64);
            this.rb_legajo_empleado.Name = "rb_legajo_empleado";
            this.rb_legajo_empleado.Size = new System.Drawing.Size(131, 21);
            this.rb_legajo_empleado.TabIndex = 28;
            this.rb_legajo_empleado.TabStop = true;
            this.rb_legajo_empleado.Text = "legajo_empleado";
            this.rb_legajo_empleado.UseVisualStyleBackColor = true;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos.Location = new System.Drawing.Point(379, 89);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(64, 21);
            this.rb_todos.TabIndex = 29;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // Frm_ABM_Cliente_Entrada
            // 
            this._PosiciónVisible = true;
            this._titulo = "ABM Cliente";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.grid_clientes);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_Cliente_Entrada";
            this.Load += new System.EventHandler(this.Frm_ABM_Cliente_Entrada_Load);
            this.Controls.SetChildIndex(this.grid_clientes, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_consultar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_cuit_cliente;
        private System.Windows.Forms.Button btn_blan_patron;
        private System.Windows.Forms.RadioButton rb_razon_social;
        private System.Windows.Forms.MaskedTextBox txt_cuit_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.RadioButton rb_nombre_contacto;
        private Clases.Grid01 grid_clientes;
        private System.Windows.Forms.RadioButton rb_legajo_empleado;
        private System.Windows.Forms.RadioButton rb_todos;
    }
}
