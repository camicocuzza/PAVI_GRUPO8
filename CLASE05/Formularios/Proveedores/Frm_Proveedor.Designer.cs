
namespace CLASE05.Formularios.Proveedores
{
    partial class Frm_Proveedor
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
            this.txt_razon_social = new CLASE05.Clases.LabelText02();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_empleado = new CLASE05.Clases.ComboBox01();
            this.cmb_estado_provincia = new CLASE05.Clases.ComboBox01();
            this.txt_ciudad = new CLASE05.Clases.LabelText02();
            this.txt_direccion = new CLASE05.Clases.LabelText02();
            this.txt_fecha_inicio = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_cuit_p = new CLASE05.Clases.LabelText02();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(549, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(479, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(514, 2);
            // 
            // txt_razon_social
            // 
            this.txt_razon_social._Ancho = 50;
            this.txt_razon_social._Decimales = 0;
            this.txt_razon_social._Etiqueta = "Razón social";
            this.txt_razon_social._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_razon_social._MensajeError = "La razón social está vacía";
            this.txt_razon_social._Nombre_campo = "";
            this.txt_razon_social._Nombre_tabla = null;
            this.txt_razon_social._ReadOnly = false;
            this.txt_razon_social._StartEnCero = false;
            this.txt_razon_social._Text = "";
            this.txt_razon_social._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_razon_social._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_razon_social._Validable = true;
            this.txt_razon_social.BackColor = System.Drawing.Color.Transparent;
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_razon_social.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_razon_social.Location = new System.Drawing.Point(7, 164);
            this.txt_razon_social.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(512, 30);
            this.txt_razon_social.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(294, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Legajo empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(41, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Estado/Provincia";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado._ComboSinSeleccion = true;
            this.cmb_empleado._MensajeError = "Seleccionar empleado";
            this.cmb_empleado._Nombre_campo = null;
            this.cmb_empleado._Nombre_tabla = "";
            this.cmb_empleado._tabla_cargar_combo = "empleado";
            this.cmb_empleado._tabla_cargar_descriptor = "legajo_empleado";
            this.cmb_empleado._tabla_cargar_pk = "legajo_empleado";
            this.cmb_empleado._tabla_join = null;
            this.cmb_empleado._tabla_join_pk = null;
            this.cmb_empleado._Validable = true;
            this.cmb_empleado.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmb_empleado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_empleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(412, 285);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(107, 25);
            this.cmb_empleado.TabIndex = 80;
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
            this.cmb_estado_provincia.Location = new System.Drawing.Point(160, 201);
            this.cmb_estado_provincia.Name = "cmb_estado_provincia";
            this.cmb_estado_provincia.Size = new System.Drawing.Size(107, 25);
            this.cmb_estado_provincia.TabIndex = 78;
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
            this.txt_ciudad.Location = new System.Drawing.Point(259, 204);
            this.txt_ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(260, 30);
            this.txt_ciudad.TabIndex = 76;
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
            this.txt_direccion.Location = new System.Drawing.Point(7, 242);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(512, 30);
            this.txt_direccion.TabIndex = 73;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio._Ancho = 10;
            this.txt_fecha_inicio._Decimales = 2;
            this.txt_fecha_inicio._Etiqueta = "Fecha inicio operación";
            this.txt_fecha_inicio._Mask = "00/00/0000";
            this.txt_fecha_inicio._MensajeError = "La fecha de inicio está vacía";
            this.txt_fecha_inicio._Nombre_campo = "";
            this.txt_fecha_inicio._Nombre_tabla = null;
            this.txt_fecha_inicio._ReadOnly = false;
            this.txt_fecha_inicio._StartEnCero = true;
            this.txt_fecha_inicio._Text = "  /  /";
            this.txt_fecha_inicio._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_inicio._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_fecha_inicio._Validable = true;
            this.txt_fecha_inicio.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha_inicio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_fecha_inicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha_inicio.Location = new System.Drawing.Point(7, 280);
            this.txt_fecha_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Size = new System.Drawing.Size(257, 30);
            this.txt_fecha_inicio.TabIndex = 77;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(219, 358);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 70;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(52, 70);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 69;
            this.lbl_titulo.Text = "Titulo";
            // 
            // txt_cuit_p
            // 
            this.txt_cuit_p._Ancho = 13;
            this.txt_cuit_p._Decimales = 2;
            this.txt_cuit_p._Etiqueta = "CUIT Proveedor";
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
            this.txt_cuit_p.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_cuit_p.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuit_p.Location = new System.Drawing.Point(7, 126);
            this.txt_cuit_p.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit_p.Name = "txt_cuit_p";
            this.txt_cuit_p.Size = new System.Drawing.Size(260, 30);
            this.txt_cuit_p.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(88, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "operación";
            // 
            // Frm_Proveedor
            // 
            this._FormularioMovil = true;
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(586, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cuit_p);
            this.Controls.Add(this.txt_razon_social);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_empleado);
            this.Controls.Add(this.cmb_estado_provincia);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_fecha_inicio);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Proveedor";
            this.Load += new System.EventHandler(this.Frm_Proveedor_Load);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.txt_fecha_inicio, 0);
            this.Controls.SetChildIndex(this.txt_direccion, 0);
            this.Controls.SetChildIndex(this.txt_ciudad, 0);
            this.Controls.SetChildIndex(this.cmb_estado_provincia, 0);
            this.Controls.SetChildIndex(this.cmb_empleado, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_razon_social, 0);
            this.Controls.SetChildIndex(this.txt_cuit_p, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Clases.LabelText02 txt_razon_social;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Clases.ComboBox01 cmb_empleado;
        public Clases.ComboBox01 cmb_estado_provincia;
        public Clases.LabelText02 txt_ciudad;
        public Clases.LabelText02 txt_direccion;
        public Clases.LabelText02 txt_fecha_inicio;
        public System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_titulo;
        public Clases.LabelText02 txt_cuit_p;
        private System.Windows.Forms.Label label3;
    }
}
