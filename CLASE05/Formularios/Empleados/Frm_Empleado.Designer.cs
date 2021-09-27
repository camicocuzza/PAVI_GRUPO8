
namespace CLASE05.Formularios.Empleados
{
    partial class Frm_Empleado
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
            this.txt_nombre = new CLASE05.Clases.LabelText02();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipo_documento = new CLASE05.Clases.ComboBox01();
            this.cmb_estado_provincia = new CLASE05.Clases.ComboBox01();
            this.txt_ciudad = new CLASE05.Clases.LabelText02();
            this.txt_legajo = new CLASE05.Clases.LabelText02();
            this.txt_telefono = new CLASE05.Clases.LabelText02();
            this.txt_direccion = new CLASE05.Clases.LabelText02();
            this.txt_n_documento = new CLASE05.Clases.LabelText02();
            this.txt_fecha_ingreso = new CLASE05.Clases.LabelText02();
            this.txt_apellido = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(509, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(439, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(474, 2);
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 20;
            this.txt_nombre._Decimales = 0;
            this.txt_nombre._Etiqueta = "Nombre";
            this.txt_nombre._Mask = "CCCCCCCCCCCCCCCCCCCC";
            this.txt_nombre._MensajeError = "El nombre de serie está vacío";
            this.txt_nombre._Nombre_campo = "";
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
            this.txt_nombre.Location = new System.Drawing.Point(-17, 203);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(286, 30);
            this.txt_nombre.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(20, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tipo documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(17, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Estado/Provincia";
            // 
            // cmb_tipo_documento
            // 
            this.cmb_tipo_documento._ComboSinSeleccion = true;
            this.cmb_tipo_documento._MensajeError = "Seleccionar tipo documento";
            this.cmb_tipo_documento._Nombre_campo = null;
            this.cmb_tipo_documento._Nombre_tabla = "";
            this.cmb_tipo_documento._tabla_cargar_combo = "tipo_documento";
            this.cmb_tipo_documento._tabla_cargar_descriptor = "nombre";
            this.cmb_tipo_documento._tabla_cargar_pk = "id_tipo_documento";
            this.cmb_tipo_documento._tabla_join = null;
            this.cmb_tipo_documento._tabla_join_pk = null;
            this.cmb_tipo_documento._Validable = true;
            this.cmb_tipo_documento.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmb_tipo_documento.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_tipo_documento.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_tipo_documento.FormattingEnabled = true;
            this.cmb_tipo_documento.Location = new System.Drawing.Point(136, 170);
            this.cmb_tipo_documento.Name = "cmb_tipo_documento";
            this.cmb_tipo_documento.Size = new System.Drawing.Size(107, 25);
            this.cmb_tipo_documento.TabIndex = 66;
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia._ComboSinSeleccion = true;
            this.cmb_estado_provincia._MensajeError = "Seleccionar estado/provincia";
            this.cmb_estado_provincia._Nombre_campo = null;
            this.cmb_estado_provincia._Nombre_tabla = "";
            this.cmb_estado_provincia._tabla_cargar_combo = "estado_provincia";
            this.cmb_estado_provincia._tabla_cargar_descriptor = "nombre_estado_provincia";
            this.cmb_estado_provincia._tabla_cargar_pk = "id_estado_provincia";
            this.cmb_estado_provincia._tabla_join = null;
            this.cmb_estado_provincia._tabla_join_pk = null;
            this.cmb_estado_provincia._Validable = true;
            this.cmb_estado_provincia.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmb_estado_provincia.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_estado_provincia.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_estado_provincia.FormattingEnabled = true;
            this.cmb_estado_provincia.Location = new System.Drawing.Point(136, 240);
            this.cmb_estado_provincia.Name = "cmb_estado_provincia";
            this.cmb_estado_provincia.Size = new System.Drawing.Size(107, 25);
            this.cmb_estado_provincia.TabIndex = 64;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad._Ancho = 20;
            this.txt_ciudad._Decimales = 2;
            this.txt_ciudad._Etiqueta = "Ciudad";
            this.txt_ciudad._Mask = "CCCCCCCCCCCCCCCCCCCC";
            this.txt_ciudad._MensajeError = "La ciudad está vacía";
            this.txt_ciudad._Nombre_campo = "";
            this.txt_ciudad._Nombre_tabla = null;
            this.txt_ciudad._ReadOnly = false;
            this.txt_ciudad._StartEnCero = false;
            this.txt_ciudad._Text = "";
            this.txt_ciudad._TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_ciudad._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_ciudad._Validable = true;
            this.txt_ciudad.BackColor = System.Drawing.Color.Transparent;
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ciudad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_ciudad.Location = new System.Drawing.Point(235, 240);
            this.txt_ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(260, 30);
            this.txt_ciudad.TabIndex = 62;
            // 
            // txt_legajo
            // 
            this.txt_legajo._Ancho = 6;
            this.txt_legajo._Decimales = 0;
            this.txt_legajo._Etiqueta = "Legajo";
            this.txt_legajo._Mask = "CCCCCC";
            this.txt_legajo._MensajeError = "El legajo está vacío";
            this.txt_legajo._Nombre_campo = null;
            this.txt_legajo._Nombre_tabla = null;
            this.txt_legajo._ReadOnly = false;
            this.txt_legajo._StartEnCero = false;
            this.txt_legajo._Text = "";
            this.txt_legajo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_legajo._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_legajo._Validable = false;
            this.txt_legajo.BackColor = System.Drawing.Color.Transparent;
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_legajo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_legajo.Location = new System.Drawing.Point(-17, 133);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(260, 30);
            this.txt_legajo.TabIndex = 61;
            // 
            // txt_telefono
            // 
            this.txt_telefono._Ancho = 10;
            this.txt_telefono._Decimales = 0;
            this.txt_telefono._Etiqueta = "Teléfono";
            this.txt_telefono._Mask = "CCCCCCCCCC";
            this.txt_telefono._MensajeError = "El teléfono está vacío";
            this.txt_telefono._Nombre_campo = "";
            this.txt_telefono._Nombre_tabla = null;
            this.txt_telefono._ReadOnly = false;
            this.txt_telefono._StartEnCero = false;
            this.txt_telefono._Text = "";
            this.txt_telefono._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_telefono._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_telefono._Validable = true;
            this.txt_telefono.BackColor = System.Drawing.Color.Transparent;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_telefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_telefono.Location = new System.Drawing.Point(235, 310);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(260, 30);
            this.txt_telefono.TabIndex = 60;
            // 
            // txt_direccion
            // 
            this.txt_direccion._Ancho = 50;
            this.txt_direccion._Decimales = 0;
            this.txt_direccion._Etiqueta = "Dirección";
            this.txt_direccion._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_direccion._MensajeError = "La dirección está vacía";
            this.txt_direccion._Nombre_campo = "num_lote";
            this.txt_direccion._Nombre_tabla = null;
            this.txt_direccion._ReadOnly = false;
            this.txt_direccion._StartEnCero = false;
            this.txt_direccion._Text = "";
            this.txt_direccion._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_direccion._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_direccion._Validable = true;
            this.txt_direccion.BackColor = System.Drawing.Color.Transparent;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_direccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_direccion.Location = new System.Drawing.Point(-17, 272);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(512, 30);
            this.txt_direccion.TabIndex = 59;
            // 
            // txt_n_documento
            // 
            this.txt_n_documento._Ancho = 8;
            this.txt_n_documento._Decimales = 0;
            this.txt_n_documento._Etiqueta = "Número documento";
            this.txt_n_documento._Mask = "CCCCCCCC";
            this.txt_n_documento._MensajeError = "El documento está vacío";
            this.txt_n_documento._Nombre_campo = "";
            this.txt_n_documento._Nombre_tabla = null;
            this.txt_n_documento._ReadOnly = false;
            this.txt_n_documento._StartEnCero = false;
            this.txt_n_documento._Text = "";
            this.txt_n_documento._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_documento._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_n_documento._Validable = true;
            this.txt_n_documento.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_documento.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_n_documento.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_documento.Location = new System.Drawing.Point(246, 165);
            this.txt_n_documento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_documento.Name = "txt_n_documento";
            this.txt_n_documento.Size = new System.Drawing.Size(260, 30);
            this.txt_n_documento.TabIndex = 57;
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso._Ancho = 10;
            this.txt_fecha_ingreso._Decimales = 2;
            this.txt_fecha_ingreso._Etiqueta = "Fecha ingreso";
            this.txt_fecha_ingreso._Mask = "00/00/0000";
            this.txt_fecha_ingreso._MensajeError = "La fecha de ingreso está vacía";
            this.txt_fecha_ingreso._Nombre_campo = "";
            this.txt_fecha_ingreso._Nombre_tabla = null;
            this.txt_fecha_ingreso._ReadOnly = false;
            this.txt_fecha_ingreso._StartEnCero = true;
            this.txt_fecha_ingreso._Text = "  /  /";
            this.txt_fecha_ingreso._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_ingreso._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_fecha_ingreso._Validable = true;
            this.txt_fecha_ingreso.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha_ingreso.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_fecha_ingreso.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(-17, 310);
            this.txt_fecha_ingreso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(257, 30);
            this.txt_fecha_ingreso.TabIndex = 63;
            // 
            // txt_apellido
            // 
            this.txt_apellido._Ancho = 20;
            this.txt_apellido._Decimales = 0;
            this.txt_apellido._Etiqueta = "Apellido";
            this.txt_apellido._Mask = "CCCCCCCCCCCCCCCCCCCC";
            this.txt_apellido._MensajeError = "El apellido está vacío";
            this.txt_apellido._Nombre_campo = "";
            this.txt_apellido._Nombre_tabla = null;
            this.txt_apellido._ReadOnly = false;
            this.txt_apellido._StartEnCero = false;
            this.txt_apellido._Text = "";
            this.txt_apellido._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_apellido._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_apellido._Validable = true;
            this.txt_apellido.BackColor = System.Drawing.Color.Transparent;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_apellido.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_apellido.Location = new System.Drawing.Point(213, 203);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(282, 30);
            this.txt_apellido.TabIndex = 65;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(222, 386);
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
            this.lbl_titulo.Location = new System.Drawing.Point(50, 71);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 55;
            this.lbl_titulo.Text = "Titulo";
            // 
            // Frm_Empleado
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 446);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tipo_documento);
            this.Controls.Add(this.cmb_estado_provincia);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_n_documento);
            this.Controls.Add(this.txt_fecha_ingreso);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Empleado";
            this.Load += new System.EventHandler(this.Frm_Empleado_Load);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.txt_fecha_ingreso, 0);
            this.Controls.SetChildIndex(this.txt_n_documento, 0);
            this.Controls.SetChildIndex(this.txt_direccion, 0);
            this.Controls.SetChildIndex(this.txt_telefono, 0);
            this.Controls.SetChildIndex(this.txt_legajo, 0);
            this.Controls.SetChildIndex(this.txt_ciudad, 0);
            this.Controls.SetChildIndex(this.cmb_estado_provincia, 0);
            this.Controls.SetChildIndex(this.cmb_tipo_documento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Clases.LabelText02 txt_nombre;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Clases.ComboBox01 cmb_tipo_documento;
        public Clases.ComboBox01 cmb_estado_provincia;
        public Clases.LabelText02 txt_ciudad;
        protected Clases.LabelText02 txt_legajo;
        public Clases.LabelText02 txt_telefono;
        public Clases.LabelText02 txt_direccion;
        public Clases.LabelText02 txt_n_documento;
        public Clases.LabelText02 txt_fecha_ingreso;
        public Clases.LabelText02 txt_apellido;
        public System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_titulo;
    }
}
