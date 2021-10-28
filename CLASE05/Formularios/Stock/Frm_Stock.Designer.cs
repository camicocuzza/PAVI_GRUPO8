
namespace CLASE05.Formularios.Stock
{
    partial class Frm_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.rb_n_articulo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_cod_articulo = new System.Windows.Forms.RadioButton();
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grid_stock_articulos = new CLASE05.Clases.Grid01();
            this.grid_stock_ensamblados = new CLASE05.Clases.Grid01();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock_ensamblados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(632, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(562, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(597, 2);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 623);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.grid_stock_articulos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artículos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage2.Controls.Add(this.grid_stock_ensamblados);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ensamblados";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_fecha);
            this.groupBox1.Controls.Add(this.rb_n_articulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb_cod_articulo);
            this.groupBox1.Controls.Add(this.btn_blan_patron);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restricciones de Búsqueda";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos.Location = new System.Drawing.Point(353, 89);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(64, 21);
            this.rb_todos.TabIndex = 40;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_fecha.Location = new System.Drawing.Point(285, 89);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(62, 21);
            this.rb_fecha.TabIndex = 39;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "Fecha";
            this.rb_fecha.UseVisualStyleBackColor = true;
            // 
            // rb_n_articulo
            // 
            this.rb_n_articulo.AutoSize = true;
            this.rb_n_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_n_articulo.Location = new System.Drawing.Point(149, 89);
            this.rb_n_articulo.Name = "rb_n_articulo";
            this.rb_n_articulo.Size = new System.Drawing.Size(130, 21);
            this.rb_n_articulo.TabIndex = 38;
            this.rb_n_articulo.TabStop = true;
            this.rb_n_articulo.Text = "Nombre Artículo";
            this.rb_n_articulo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Buscar por:";
            // 
            // rb_cod_articulo
            // 
            this.rb_cod_articulo.AutoSize = true;
            this.rb_cod_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_cod_articulo.Location = new System.Drawing.Point(19, 89);
            this.rb_cod_articulo.Name = "rb_cod_articulo";
            this.rb_cod_articulo.Size = new System.Drawing.Size(124, 21);
            this.rb_cod_articulo.TabIndex = 36;
            this.rb_cod_articulo.TabStop = true;
            this.rb_cod_articulo.Text = "Código Artículo";
            this.rb_cod_articulo.UseVisualStyleBackColor = true;
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
            this.btn_blan_patron.Location = new System.Drawing.Point(287, 34);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_patron.TabIndex = 35;
            this.btn_blan_patron.TabStop = false;
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(152, 41);
            this.txt_patron.Mask = "aaaaaaaaaaaaaaaaaaaa";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 33;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(552, 100);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(85, 30);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Historial Stock Artículos";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Historial Stock Ensamblados";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 136);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restricciones de Búsqueda";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(353, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 21);
            this.radioButton1.TabIndex = 40;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(285, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 21);
            this.radioButton2.TabIndex = 39;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fecha";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton3.Location = new System.Drawing.Point(149, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(130, 21);
            this.radioButton3.TabIndex = 38;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Nombre Artículo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Buscar por:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton4.Location = new System.Drawing.Point(19, 89);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(124, 21);
            this.radioButton4.TabIndex = 36;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Código Artículo";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__7_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.Location = new System.Drawing.Point(287, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 35;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Patrón de Búsqueda";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox1.Location = new System.Drawing.Point(152, 41);
            this.maskedTextBox1.Mask = "aaaaaaaaaaaaaaaaaaaa";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(129, 25);
            this.maskedTextBox1.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(552, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // grid_stock_articulos
            // 
            this.grid_stock_articulos._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_stock_articulos._tamannoLetraHeader = 9;
            this.grid_stock_articulos.AllowUserToAddRows = false;
            this.grid_stock_articulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_stock_articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_stock_articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stock_articulos.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_stock_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_stock_articulos.Location = new System.Drawing.Point(6, 204);
            this.grid_stock_articulos.Name = "grid_stock_articulos";
            this.grid_stock_articulos.ReadOnly = true;
            this.grid_stock_articulos.Size = new System.Drawing.Size(645, 386);
            this.grid_stock_articulos.TabIndex = 9;
            // 
            // grid_stock_ensamblados
            // 
            this.grid_stock_ensamblados._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_stock_ensamblados._tamannoLetraHeader = 9;
            this.grid_stock_ensamblados.AllowUserToAddRows = false;
            this.grid_stock_ensamblados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_stock_ensamblados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_stock_ensamblados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stock_ensamblados.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_stock_ensamblados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_stock_ensamblados.Location = new System.Drawing.Point(6, 204);
            this.grid_stock_ensamblados.Name = "grid_stock_ensamblados";
            this.grid_stock_ensamblados.ReadOnly = true;
            this.grid_stock_ensamblados.Size = new System.Drawing.Size(645, 386);
            this.grid_stock_ensamblados.TabIndex = 10;
            // 
            // Frm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(669, 637);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Stock";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock_ensamblados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_fecha;
        private System.Windows.Forms.RadioButton rb_n_articulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_cod_articulo;
        private System.Windows.Forms.Button btn_blan_patron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private Clases.Grid01 grid_stock_ensamblados;
        private Clases.Grid01 grid_stock_articulos;
    }
}
