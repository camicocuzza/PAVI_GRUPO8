
namespace CLASE05.Formularios.EquiposEnsamblados
{
    partial class Frm_EquiposEnsamblados_Modificacion
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
            this.cmb_articulo = new CLASE05.Clases.ComboBox01();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad = new CLASE05.Clases.LabelText02();
            this.grid_articulos = new CLASE05.Clases.Grid01();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_eliminar_a = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cod_p_ensamblado
            // 
            this.txt_cod_p_ensamblado.Enabled = false;
            this.txt_cod_p_ensamblado.Location = new System.Drawing.Point(5, 112);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(271, 500);
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(5, 150);
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 50;
            this.txt_nombre._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nombre._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_nombre.Location = new System.Drawing.Point(212, 151);
            this.txt_nombre.Size = new System.Drawing.Size(358, 30);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(605, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(535, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(570, 2);
            // 
            // cmb_articulo
            // 
            this.cmb_articulo._ComboSinSeleccion = false;
            this.cmb_articulo._MensajeError = "Seleccionar país";
            this.cmb_articulo._Nombre_campo = null;
            this.cmb_articulo._Nombre_tabla = "";
            this.cmb_articulo._tabla_cargar_combo = "articulo";
            this.cmb_articulo._tabla_cargar_descriptor = "nombre";
            this.cmb_articulo._tabla_cargar_pk = "cod_articulo";
            this.cmb_articulo._tabla_join = null;
            this.cmb_articulo._tabla_join_pk = null;
            this.cmb_articulo._Validable = false;
            this.cmb_articulo.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmb_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_articulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_articulo.FormattingEnabled = true;
            this.cmb_articulo.Location = new System.Drawing.Point(158, 228);
            this.cmb_articulo.Name = "cmb_articulo";
            this.cmb_articulo.Size = new System.Drawing.Size(107, 25);
            this.cmb_articulo.TabIndex = 79;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_agregar.Location = new System.Drawing.Point(499, 226);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(71, 30);
            this.btn_agregar.TabIndex = 78;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(94, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 77;
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
            this.txt_cantidad.Location = new System.Drawing.Point(212, 226);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(261, 30);
            this.txt_cantidad.TabIndex = 80;
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
            this.grid_articulos.Location = new System.Drawing.Point(70, 282);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.ReadOnly = true;
            this.grid_articulos.Size = new System.Drawing.Size(511, 158);
            this.grid_articulos.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(94, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "Agregar Artículo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(484, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 83;
            this.button1.Text = "Ver detalle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eliminar_a
            // 
            this.btn_eliminar_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_eliminar_a.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_a.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminar_a.Location = new System.Drawing.Point(392, 446);
            this.btn_eliminar_a.Name = "btn_eliminar_a";
            this.btn_eliminar_a.Size = new System.Drawing.Size(86, 30);
            this.btn_eliminar_a.TabIndex = 84;
            this.btn_eliminar_a.Text = "Eliminar";
            this.btn_eliminar_a.UseVisualStyleBackColor = false;
            this.btn_eliminar_a.Click += new System.EventHandler(this.btn_eliminar_a_Click);
            // 
            // Frm_EquiposEnsamblados_Modificacion
            //
            this._Titulo = "Modificación de Equipo Ensamblado";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(642, 555);
            this.Controls.Add(this.btn_eliminar_a);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_articulos);
            this.Controls.Add(this.cmb_articulo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cantidad);
            this.Name = "Frm_EquiposEnsamblados_Modificacion";
            this.Load += new System.EventHandler(this.Frm_EquiposEnsamblados_Modificacion_Load);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.txt_cod_p_ensamblado, 0);
            this.Controls.SetChildIndex(this.txt_precio, 0);
            this.Controls.SetChildIndex(this.txt_cantidad, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.cmb_articulo, 0);
            this.Controls.SetChildIndex(this.grid_articulos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btn_eliminar_a, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Clases.ComboBox01 cmb_articulo;
        public System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        public Clases.LabelText02 txt_cantidad;
        private Clases.Grid01 grid_articulos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_eliminar_a;
    }
}
