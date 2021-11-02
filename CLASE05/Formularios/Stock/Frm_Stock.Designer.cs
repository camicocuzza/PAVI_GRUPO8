
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grid_stock_articulos = new CLASE05.Clases.Grid01();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_todos_articulo = new System.Windows.Forms.RadioButton();
            this.rb_fecha_articulo = new System.Windows.Forms.RadioButton();
            this.rb_n_articulo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_cod_articulo = new System.Windows.Forms.RadioButton();
            this.btn_blan_art = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patron_art = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar_articulos = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grid_stock_ensamblados = new CLASE05.Clases.Grid01();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_todos_ensamblado = new System.Windows.Forms.RadioButton();
            this.rb_fecha_ensamblado = new System.Windows.Forms.RadioButton();
            this.rb_n_ensamblado = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_codigo_ensamblado = new System.Windows.Forms.RadioButton();
            this.btn_blan_ens = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_patron_ens = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar_ens = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_actual_art = new System.Windows.Forms.RadioButton();
            this.rb_actual_ens = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock_articulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock_ensamblados)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // grid_stock_articulos
            // 
            this.grid_stock_articulos._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_stock_articulos._tamannoLetraHeader = 9;
            this.grid_stock_articulos.AllowUserToAddRows = false;
            this.grid_stock_articulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_stock_articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox1.Controls.Add(this.rb_actual_art);
            this.groupBox1.Controls.Add(this.rb_todos_articulo);
            this.groupBox1.Controls.Add(this.rb_fecha_articulo);
            this.groupBox1.Controls.Add(this.rb_n_articulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb_cod_articulo);
            this.groupBox1.Controls.Add(this.btn_blan_art);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patron_art);
            this.groupBox1.Controls.Add(this.btn_buscar_articulos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restricciones de Búsqueda";
            // 
            // rb_todos_articulo
            // 
            this.rb_todos_articulo.AutoSize = true;
            this.rb_todos_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos_articulo.Location = new System.Drawing.Point(373, 89);
            this.rb_todos_articulo.Name = "rb_todos_articulo";
            this.rb_todos_articulo.Size = new System.Drawing.Size(64, 21);
            this.rb_todos_articulo.TabIndex = 40;
            this.rb_todos_articulo.TabStop = true;
            this.rb_todos_articulo.Text = "Todos";
            this.rb_todos_articulo.UseVisualStyleBackColor = true;
            // 
            // rb_fecha_articulo
            // 
            this.rb_fecha_articulo.AutoSize = true;
            this.rb_fecha_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_fecha_articulo.Location = new System.Drawing.Point(206, 89);
            this.rb_fecha_articulo.Name = "rb_fecha_articulo";
            this.rb_fecha_articulo.Size = new System.Drawing.Size(62, 21);
            this.rb_fecha_articulo.TabIndex = 39;
            this.rb_fecha_articulo.TabStop = true;
            this.rb_fecha_articulo.Text = "Fecha";
            this.rb_fecha_articulo.UseVisualStyleBackColor = true;
            // 
            // rb_n_articulo
            // 
            this.rb_n_articulo.AutoSize = true;
            this.rb_n_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_n_articulo.Location = new System.Drawing.Point(110, 89);
            this.rb_n_articulo.Name = "rb_n_articulo";
            this.rb_n_articulo.Size = new System.Drawing.Size(80, 21);
            this.rb_n_articulo.TabIndex = 38;
            this.rb_n_articulo.TabStop = true;
            this.rb_n_articulo.Text = "Nombre ";
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
            this.rb_cod_articulo.Size = new System.Drawing.Size(74, 21);
            this.rb_cod_articulo.TabIndex = 36;
            this.rb_cod_articulo.TabStop = true;
            this.rb_cod_articulo.Text = "Código ";
            this.rb_cod_articulo.UseVisualStyleBackColor = true;
            // 
            // btn_blan_art
            // 
            this.btn_blan_art.BackColor = System.Drawing.Color.Transparent;
            this.btn_blan_art.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__7_;
            this.btn_blan_art.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_blan_art.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_art.FlatAppearance.BorderSize = 0;
            this.btn_blan_art.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_art.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_art.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blan_art.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_art.Location = new System.Drawing.Point(443, 34);
            this.btn_blan_art.Name = "btn_blan_art";
            this.btn_blan_art.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_art.TabIndex = 35;
            this.btn_blan_art.TabStop = false;
            this.btn_blan_art.UseVisualStyleBackColor = false;
            this.btn_blan_art.Click += new System.EventHandler(this.btn_blan_art_Click);
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
            // txt_patron_art
            // 
            this.txt_patron_art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron_art.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron_art.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron_art.Location = new System.Drawing.Point(152, 41);
            this.txt_patron_art.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_patron_art.Name = "txt_patron_art";
            this.txt_patron_art.Size = new System.Drawing.Size(285, 25);
            this.txt_patron_art.TabIndex = 33;
            // 
            // btn_buscar_articulos
            // 
            this.btn_buscar_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar_articulos.FlatAppearance.BorderSize = 0;
            this.btn_buscar_articulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_buscar_articulos.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_articulos.Location = new System.Drawing.Point(552, 100);
            this.btn_buscar_articulos.Name = "btn_buscar_articulos";
            this.btn_buscar_articulos.Size = new System.Drawing.Size(85, 30);
            this.btn_buscar_articulos.TabIndex = 0;
            this.btn_buscar_articulos.Text = "Buscar";
            this.btn_buscar_articulos.UseVisualStyleBackColor = false;
            this.btn_buscar_articulos.Click += new System.EventHandler(this.btn_buscar_articulos_Click);
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
            // grid_stock_ensamblados
            // 
            this.grid_stock_ensamblados._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_stock_ensamblados._tamannoLetraHeader = 9;
            this.grid_stock_ensamblados.AllowUserToAddRows = false;
            this.grid_stock_ensamblados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_stock_ensamblados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox2.Controls.Add(this.rb_actual_ens);
            this.groupBox2.Controls.Add(this.rb_todos_ensamblado);
            this.groupBox2.Controls.Add(this.rb_fecha_ensamblado);
            this.groupBox2.Controls.Add(this.rb_n_ensamblado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rb_codigo_ensamblado);
            this.groupBox2.Controls.Add(this.btn_blan_ens);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_patron_ens);
            this.groupBox2.Controls.Add(this.btn_buscar_ens);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 136);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restricciones de Búsqueda";
            // 
            // rb_todos_ensamblado
            // 
            this.rb_todos_ensamblado.AutoSize = true;
            this.rb_todos_ensamblado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos_ensamblado.Location = new System.Drawing.Point(373, 89);
            this.rb_todos_ensamblado.Name = "rb_todos_ensamblado";
            this.rb_todos_ensamblado.Size = new System.Drawing.Size(64, 21);
            this.rb_todos_ensamblado.TabIndex = 40;
            this.rb_todos_ensamblado.TabStop = true;
            this.rb_todos_ensamblado.Text = "Todos";
            this.rb_todos_ensamblado.UseVisualStyleBackColor = true;
            // 
            // rb_fecha_ensamblado
            // 
            this.rb_fecha_ensamblado.AutoSize = true;
            this.rb_fecha_ensamblado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_fecha_ensamblado.Location = new System.Drawing.Point(206, 89);
            this.rb_fecha_ensamblado.Name = "rb_fecha_ensamblado";
            this.rb_fecha_ensamblado.Size = new System.Drawing.Size(62, 21);
            this.rb_fecha_ensamblado.TabIndex = 39;
            this.rb_fecha_ensamblado.TabStop = true;
            this.rb_fecha_ensamblado.Text = "Fecha";
            this.rb_fecha_ensamblado.UseVisualStyleBackColor = true;
            // 
            // rb_n_ensamblado
            // 
            this.rb_n_ensamblado.AutoSize = true;
            this.rb_n_ensamblado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_n_ensamblado.Location = new System.Drawing.Point(110, 89);
            this.rb_n_ensamblado.Name = "rb_n_ensamblado";
            this.rb_n_ensamblado.Size = new System.Drawing.Size(80, 21);
            this.rb_n_ensamblado.TabIndex = 38;
            this.rb_n_ensamblado.TabStop = true;
            this.rb_n_ensamblado.Text = "Nombre ";
            this.rb_n_ensamblado.UseVisualStyleBackColor = true;
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
            // rb_codigo_ensamblado
            // 
            this.rb_codigo_ensamblado.AutoSize = true;
            this.rb_codigo_ensamblado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_codigo_ensamblado.Location = new System.Drawing.Point(19, 89);
            this.rb_codigo_ensamblado.Name = "rb_codigo_ensamblado";
            this.rb_codigo_ensamblado.Size = new System.Drawing.Size(71, 21);
            this.rb_codigo_ensamblado.TabIndex = 36;
            this.rb_codigo_ensamblado.TabStop = true;
            this.rb_codigo_ensamblado.Text = "Código";
            this.rb_codigo_ensamblado.UseVisualStyleBackColor = true;
            // 
            // btn_blan_ens
            // 
            this.btn_blan_ens.BackColor = System.Drawing.Color.Transparent;
            this.btn_blan_ens.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__7_;
            this.btn_blan_ens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_blan_ens.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_ens.FlatAppearance.BorderSize = 0;
            this.btn_blan_ens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_ens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_ens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blan_ens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_ens.Location = new System.Drawing.Point(443, 34);
            this.btn_blan_ens.Name = "btn_blan_ens";
            this.btn_blan_ens.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_ens.TabIndex = 35;
            this.btn_blan_ens.TabStop = false;
            this.btn_blan_ens.UseVisualStyleBackColor = false;
            this.btn_blan_ens.Click += new System.EventHandler(this.btn_blan_ens_Click);
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
            // txt_patron_ens
            // 
            this.txt_patron_ens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron_ens.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron_ens.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron_ens.Location = new System.Drawing.Point(152, 41);
            this.txt_patron_ens.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_patron_ens.Name = "txt_patron_ens";
            this.txt_patron_ens.Size = new System.Drawing.Size(285, 25);
            this.txt_patron_ens.TabIndex = 33;
            // 
            // btn_buscar_ens
            // 
            this.btn_buscar_ens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar_ens.FlatAppearance.BorderSize = 0;
            this.btn_buscar_ens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_ens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_buscar_ens.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_ens.Location = new System.Drawing.Point(552, 100);
            this.btn_buscar_ens.Name = "btn_buscar_ens";
            this.btn_buscar_ens.Size = new System.Drawing.Size(85, 30);
            this.btn_buscar_ens.TabIndex = 0;
            this.btn_buscar_ens.Text = "Buscar";
            this.btn_buscar_ens.UseVisualStyleBackColor = false;
            this.btn_buscar_ens.Click += new System.EventHandler(this.btn_buscar_ens_Click);
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
            // rb_actual_art
            // 
            this.rb_actual_art.AutoSize = true;
            this.rb_actual_art.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_actual_art.Location = new System.Drawing.Point(286, 89);
            this.rb_actual_art.Name = "rb_actual_art";
            this.rb_actual_art.Size = new System.Drawing.Size(66, 21);
            this.rb_actual_art.TabIndex = 41;
            this.rb_actual_art.TabStop = true;
            this.rb_actual_art.Text = "Actual";
            this.rb_actual_art.UseVisualStyleBackColor = true;
            // 
            // rb_actual_ens
            // 
            this.rb_actual_ens.AutoSize = true;
            this.rb_actual_ens.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_actual_ens.Location = new System.Drawing.Point(286, 89);
            this.rb_actual_ens.Name = "rb_actual_ens";
            this.rb_actual_ens.Size = new System.Drawing.Size(66, 21);
            this.rb_actual_ens.TabIndex = 42;
            this.rb_actual_ens.TabStop = true;
            this.rb_actual_ens.Text = "Actual";
            this.rb_actual_ens.UseVisualStyleBackColor = true;
            // 
            // Frm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(669, 637);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Stock";
            this.Load += new System.EventHandler(this.Frm_Stock_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock_articulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock_ensamblados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_todos_articulo;
        private System.Windows.Forms.RadioButton rb_fecha_articulo;
        private System.Windows.Forms.RadioButton rb_n_articulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_cod_articulo;
        private System.Windows.Forms.Button btn_blan_art;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron_art;
        public System.Windows.Forms.Button btn_buscar_articulos;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_todos_ensamblado;
        private System.Windows.Forms.RadioButton rb_fecha_ensamblado;
        private System.Windows.Forms.RadioButton rb_n_ensamblado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_codigo_ensamblado;
        private System.Windows.Forms.Button btn_blan_ens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_patron_ens;
        public System.Windows.Forms.Button btn_buscar_ens;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private Clases.Grid01 grid_stock_ensamblados;
        private Clases.Grid01 grid_stock_articulos;
        private System.Windows.Forms.RadioButton rb_actual_art;
        private System.Windows.Forms.RadioButton rb_actual_ens;
    }
}
