
namespace CLASE05.Formularios.Compras
{
    partial class Frm_SistemaCompras
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_eliminar_a = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_articulo = new CLASE05.Clases.ComboBox01();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad = new CLASE05.Clases.LabelText02();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_proveedor = new CLASE05.Clases.ComboBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new CLASE05.Clases.LabelText02();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.grid_articulos = new CLASE05.Clases.Grid01();
            this.txt_fecha_inicio = new CLASE05.Clases.LabelText02();
            this.txt_direccion = new CLASE05.Clases.LabelText02();
            this.txt_cuit_p = new CLASE05.Clases.LabelText02();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(786, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(716, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(751, 2);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_titulo.Location = new System.Drawing.Point(29, 30);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 56;
            this.lbl_titulo.Text = "Titulo";
            // 
            // btn_eliminar_a
            // 
            this.btn_eliminar_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_eliminar_a.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_a.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminar_a.Location = new System.Drawing.Point(610, 341);
            this.btn_eliminar_a.Name = "btn_eliminar_a";
            this.btn_eliminar_a.Size = new System.Drawing.Size(86, 30);
            this.btn_eliminar_a.TabIndex = 92;
            this.btn_eliminar_a.Text = "Eliminar";
            this.btn_eliminar_a.UseVisualStyleBackColor = false;
            this.btn_eliminar_a.Click += new System.EventHandler(this.btn_eliminar_a_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(702, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 91;
            this.button1.Text = "Ver detalle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(309, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "Agregar Artículo";
            // 
            // cmb_articulo
            // 
            this.cmb_articulo._ComboSinSeleccion = true;
            this.cmb_articulo._MensajeError = "Seleccionar articulo";
            this.cmb_articulo._Nombre_campo = null;
            this.cmb_articulo._Nombre_tabla = "";
            this.cmb_articulo._tabla_cargar_combo = "";
            this.cmb_articulo._tabla_cargar_descriptor = "";
            this.cmb_articulo._tabla_cargar_pk = "";
            this.cmb_articulo._tabla_join = null;
            this.cmb_articulo._tabla_join_pk = null;
            this.cmb_articulo._Validable = false;
            this.cmb_articulo.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmb_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_articulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_articulo.FormattingEnabled = true;
            this.cmb_articulo.Location = new System.Drawing.Point(374, 128);
            this.cmb_articulo.Name = "cmb_articulo";
            this.cmb_articulo.Size = new System.Drawing.Size(187, 25);
            this.cmb_articulo.TabIndex = 87;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_agregar.Location = new System.Drawing.Point(715, 126);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(71, 30);
            this.btn_agregar.TabIndex = 86;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(310, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Artículo";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad._Ancho = 3;
            this.txt_cantidad._Decimales = 0;
            this.txt_cantidad._Etiqueta = "Cantidad";
            this.txt_cantidad._Mask = "999";
            this.txt_cantidad._MensajeError = "El stock está vacío";
            this.txt_cantidad._Nombre_campo = "stock";
            this.txt_cantidad._Nombre_tabla = null;
            this.txt_cantidad._ReadOnly = false;
            this.txt_cantidad._StartEnCero = false;
            this.txt_cantidad._Text = "";
            this.txt_cantidad._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cantidad._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_cantidad._Validable = false;
            this.txt_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_cantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cantidad.Location = new System.Drawing.Point(490, 126);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(206, 30);
            this.txt_cantidad.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(59, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 94;
            this.label4.Text = "Proveedor";
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor._ComboSinSeleccion = false;
            this.cmb_proveedor._MensajeError = "Seleccionar rubro";
            this.cmb_proveedor._Nombre_campo = null;
            this.cmb_proveedor._Nombre_tabla = "";
            this.cmb_proveedor._tabla_cargar_combo = "proveedor";
            this.cmb_proveedor._tabla_cargar_descriptor = "razon_social";
            this.cmb_proveedor._tabla_cargar_pk = "cuit_proveedor";
            this.cmb_proveedor._tabla_join = null;
            this.cmb_proveedor._tabla_join_pk = null;
            this.cmb_proveedor._Validable = true;
            this.cmb_proveedor.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmb_proveedor.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(136, 200);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(154, 25);
            this.cmb_proveedor.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 95;
            this.label3.Text = "Seleccionar Proveedor";
            // 
            // txt_fecha
            // 
            this.txt_fecha._Ancho = 10;
            this.txt_fecha._Decimales = 2;
            this.txt_fecha._Etiqueta = "Fecha Actual";
            this.txt_fecha._Mask = "00/00/0000";
            this.txt_fecha._MensajeError = "El plazo de pago está vacío";
            this.txt_fecha._Nombre_campo = "plazo_pago";
            this.txt_fecha._Nombre_tabla = null;
            this.txt_fecha._ReadOnly = false;
            this.txt_fecha._StartEnCero = true;
            this.txt_fecha._Text = "  /  /";
            this.txt_fecha._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_fecha._Validable = true;
            this.txt_fecha.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_fecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha.Location = new System.Drawing.Point(-16, 89);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(257, 30);
            this.txt_fecha.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(505, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 98;
            this.label6.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_total.Location = new System.Drawing.Point(551, 414);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(102, 25);
            this.txt_total.TabIndex = 99;
            // 
            // btn_grabar
            // 
            this.btn_grabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_grabar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grabar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_grabar.Location = new System.Drawing.Point(670, 411);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(118, 30);
            this.btn_grabar.TabIndex = 100;
            this.btn_grabar.Text = "Grabar Compra";
            this.btn_grabar.UseVisualStyleBackColor = false;
            // 
            // grid_articulos
            // 
            this.grid_articulos._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_articulos._tamannoLetraHeader = 9;
            this.grid_articulos.AllowUserToAddRows = false;
            this.grid_articulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_articulos.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulos.Location = new System.Drawing.Point(313, 177);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.ReadOnly = true;
            this.grid_articulos.Size = new System.Drawing.Size(479, 158);
            this.grid_articulos.TabIndex = 102;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio._Ancho = 10;
            this.txt_fecha_inicio._Decimales = 2;
            this.txt_fecha_inicio._Etiqueta = "Fecha inicio";
            this.txt_fecha_inicio._Mask = "00/00/0000";
            this.txt_fecha_inicio._MensajeError = "";
            this.txt_fecha_inicio._Nombre_campo = "";
            this.txt_fecha_inicio._Nombre_tabla = null;
            this.txt_fecha_inicio._ReadOnly = false;
            this.txt_fecha_inicio._StartEnCero = true;
            this.txt_fecha_inicio._Text = "  /  /";
            this.txt_fecha_inicio._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_inicio._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_fecha_inicio._Validable = true;
            this.txt_fecha_inicio.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha_inicio.Enabled = false;
            this.txt_fecha_inicio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_fecha_inicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha_inicio.Location = new System.Drawing.Point(-15, 281);
            this.txt_fecha_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Size = new System.Drawing.Size(257, 30);
            this.txt_fecha_inicio.TabIndex = 104;
            // 
            // txt_direccion
            // 
            this.txt_direccion._Ancho = 20;
            this.txt_direccion._Decimales = 2;
            this.txt_direccion._Etiqueta = "Dirección";
            this.txt_direccion._Mask = "CCCCCCCCCCCCCCCCCCCC";
            this.txt_direccion._MensajeError = "";
            this.txt_direccion._Nombre_campo = "";
            this.txt_direccion._Nombre_tabla = null;
            this.txt_direccion._ReadOnly = false;
            this.txt_direccion._StartEnCero = true;
            this.txt_direccion._Text = "";
            this.txt_direccion._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_direccion._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_direccion._Validable = true;
            this.txt_direccion.BackColor = System.Drawing.Color.Transparent;
            this.txt_direccion.Enabled = false;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_direccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_direccion.Location = new System.Drawing.Point(-15, 319);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(305, 30);
            this.txt_direccion.TabIndex = 105;
            // 
            // txt_cuit_p
            // 
            this.txt_cuit_p._Ancho = 13;
            this.txt_cuit_p._Decimales = 2;
            this.txt_cuit_p._Etiqueta = "CUIT";
            this.txt_cuit_p._Mask = "99-99999999-9";
            this.txt_cuit_p._MensajeError = "El CUIT del proveedor está vacío";
            this.txt_cuit_p._Nombre_campo = "cuit_proveedor";
            this.txt_cuit_p._Nombre_tabla = null;
            this.txt_cuit_p._ReadOnly = false;
            this.txt_cuit_p._StartEnCero = true;
            this.txt_cuit_p._Text = "";
            this.txt_cuit_p._TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_cuit_p._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_cuit_p._Validable = true;
            this.txt_cuit_p.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuit_p.Enabled = false;
            this.txt_cuit_p.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_cuit_p.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuit_p.Location = new System.Drawing.Point(-15, 243);
            this.txt_cuit_p.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit_p.Name = "txt_cuit_p";
            this.txt_cuit_p.Size = new System.Drawing.Size(260, 30);
            this.txt_cuit_p.TabIndex = 106;
            // 
            // Frm_SistemaCompras
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(823, 467);
            this.Controls.Add(this.txt_cuit_p);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_fecha_inicio);
            this.Controls.Add(this.grid_articulos);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.btn_eliminar_a);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_articulo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_SistemaCompras";
            this.Load += new System.EventHandler(this.Frm_SistemaCompras_Load);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.txt_cantidad, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.cmb_articulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btn_eliminar_a, 0);
            this.Controls.SetChildIndex(this.cmb_proveedor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.txt_fecha, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_total, 0);
            this.Controls.SetChildIndex(this.btn_grabar, 0);
            this.Controls.SetChildIndex(this.grid_articulos, 0);
            this.Controls.SetChildIndex(this.txt_fecha_inicio, 0);
            this.Controls.SetChildIndex(this.txt_direccion, 0);
            this.Controls.SetChildIndex(this.txt_cuit_p, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        public System.Windows.Forms.Button btn_eliminar_a;
        public System.Windows.Forms.Button button1;
        public Clases.ComboBox01 cmb_articulo;
        public System.Windows.Forms.Button btn_agregar;
        public Clases.LabelText02 txt_cantidad;
        private System.Windows.Forms.Label label4;
        public Clases.ComboBox01 cmb_proveedor;
        public Clases.LabelText02 txt_fecha;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_total;
        public System.Windows.Forms.Button btn_grabar;
        public Clases.LabelText02 txt_fecha_inicio;
        public Clases.LabelText02 txt_direccion;
        public Clases.LabelText02 txt_cuit_p;
        public Clases.Grid01 grid_articulos;
        public System.Windows.Forms.Label label2;
    }
}
