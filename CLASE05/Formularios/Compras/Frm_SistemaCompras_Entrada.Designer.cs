
namespace CLASE05.Formularios.Compras
{
    partial class Frm_SistemaCompras_Entrada
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
            this.rb_proveedor = new System.Windows.Forms.RadioButton();
            this.rb_num_compra = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.txt_fecha = new CLASE05.Clases.LabelText02();
            this.cmb_proveedores = new CLASE05.Clases.ComboBox01();
            this.grid_compras = new CLASE05.Clases.Grid01();
            this.txt_numero = new CLASE05.Clases.LabelText02();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Location = new System.Drawing.Point(548, 390);
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Visible = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Location = new System.Drawing.Point(599, 387);
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.Text = "Sistema Compras";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Location = new System.Drawing.Point(495, 390);
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_fecha);
            this.groupBox1.Controls.Add(this.rb_proveedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb_num_compra);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.cmb_proveedores);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.SetChildIndex(this.txt_numero, 0);
            this.groupBox1.Controls.SetChildIndex(this.cmb_proveedores, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_fecha, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_num_compra, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_proveedor, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_fecha, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_todos, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderSize = 0;
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
            // rb_proveedor
            // 
            this.rb_proveedor.AutoSize = true;
            this.rb_proveedor.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_proveedor.Location = new System.Drawing.Point(102, 57);
            this.rb_proveedor.Name = "rb_proveedor";
            this.rb_proveedor.Size = new System.Drawing.Size(89, 21);
            this.rb_proveedor.TabIndex = 43;
            this.rb_proveedor.TabStop = true;
            this.rb_proveedor.Text = "Proveedor";
            this.rb_proveedor.UseVisualStyleBackColor = true;
            this.rb_proveedor.CheckedChanged += new System.EventHandler(this.rb_proveedor_CheckedChanged);
            // 
            // rb_num_compra
            // 
            this.rb_num_compra.AutoSize = true;
            this.rb_num_compra.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_num_compra.Location = new System.Drawing.Point(19, 57);
            this.rb_num_compra.Name = "rb_num_compra";
            this.rb_num_compra.Size = new System.Drawing.Size(77, 21);
            this.rb_num_compra.TabIndex = 41;
            this.rb_num_compra.TabStop = true;
            this.rb_num_compra.Text = "Número";
            this.rb_num_compra.UseVisualStyleBackColor = true;
            this.rb_num_compra.CheckedChanged += new System.EventHandler(this.rb_num_compra_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Buscar por:";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos.Location = new System.Drawing.Point(265, 57);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(64, 21);
            this.rb_todos.TabIndex = 45;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_fecha.Location = new System.Drawing.Point(197, 57);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(62, 21);
            this.rb_fecha.TabIndex = 44;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "Fecha";
            this.rb_fecha.UseVisualStyleBackColor = true;
            this.rb_fecha.CheckedChanged += new System.EventHandler(this.rb_fecha_CheckedChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha._Ancho = 10;
            this.txt_fecha._Decimales = 2;
            this.txt_fecha._Etiqueta = "Fecha";
            this.txt_fecha._Mask = "00/00/0000";
            this.txt_fecha._MensajeError = null;
            this.txt_fecha._Nombre_campo = null;
            this.txt_fecha._Nombre_tabla = null;
            this.txt_fecha._ReadOnly = false;
            this.txt_fecha._StartEnCero = true;
            this.txt_fecha._Text = "  /  /";
            this.txt_fecha._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_fecha._Validable = true;
            this.txt_fecha.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_fecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha.Location = new System.Drawing.Point(264, 53);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(226, 30);
            this.txt_fecha.TabIndex = 46;
            this.txt_fecha.Visible = false;
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores._ComboSinSeleccion = false;
            this.cmb_proveedores._MensajeError = null;
            this.cmb_proveedores._Nombre_campo = null;
            this.cmb_proveedores._Nombre_tabla = "";
            this.cmb_proveedores._tabla_cargar_combo = "proveedor";
            this.cmb_proveedores._tabla_cargar_descriptor = "razon_social";
            this.cmb_proveedores._tabla_cargar_pk = "cuit_proveedor";
            this.cmb_proveedores._tabla_join = null;
            this.cmb_proveedores._tabla_join_pk = null;
            this.cmb_proveedores._Validable = true;
            this.cmb_proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_proveedores.ForeColor = System.Drawing.Color.White;
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.Location = new System.Drawing.Point(365, 53);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Size = new System.Drawing.Size(142, 30);
            this.cmb_proveedores.TabIndex = 47;
            this.cmb_proveedores.Visible = false;
            // 
            // grid_compras
            // 
            this.grid_compras._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_compras._tamannoLetraHeader = 9;
            this.grid_compras.AllowUserToAddRows = false;
            this.grid_compras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_compras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_compras.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_compras.Location = new System.Drawing.Point(12, 226);
            this.grid_compras.Name = "grid_compras";
            this.grid_compras.ReadOnly = true;
            this.grid_compras.Size = new System.Drawing.Size(645, 158);
            this.grid_compras.TabIndex = 41;
            // 
            // txt_numero
            // 
            this.txt_numero._Ancho = 10;
            this.txt_numero._Decimales = 0;
            this.txt_numero._Etiqueta = "Número";
            this.txt_numero._Mask = "9999999999";
            this.txt_numero._MensajeError = null;
            this.txt_numero._Nombre_campo = null;
            this.txt_numero._Nombre_tabla = null;
            this.txt_numero._ReadOnly = false;
            this.txt_numero._StartEnCero = false;
            this.txt_numero._Text = "";
            this.txt_numero._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_numero._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_numero._Validable = true;
            this.txt_numero.BackColor = System.Drawing.Color.Transparent;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_numero.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_numero.Location = new System.Drawing.Point(264, 53);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(228, 30);
            this.txt_numero.TabIndex = 48;
            this.txt_numero.Visible = false;
            // 
            // Frm_SistemaCompras_Entrada
            // 
            this._PosiciónVisible = true;
            this._titulo = "Sistema Compras";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.grid_compras);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_SistemaCompras_Entrada";
            this.Load += new System.EventHandler(this.Frm_SistemaCompras_Entrada_Load);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_consultar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.grid_compras, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_fecha;
        private System.Windows.Forms.RadioButton rb_proveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_num_compra;
        private Clases.LabelText02 txt_fecha;
        private Clases.ComboBox01 cmb_proveedores;
        private Clases.Grid01 grid_compras;
        private Clases.LabelText02 txt_numero;
    }
}
