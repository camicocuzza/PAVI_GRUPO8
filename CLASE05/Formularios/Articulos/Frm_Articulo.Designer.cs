
namespace CLASE05.Formularios.Articulos
{
    partial class Frm_Articulo
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_num_serie = new CLASE05.Clases.LabelText02();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_paises = new CLASE05.Clases.ComboBox01();
            this.cmb_rubros = new CLASE05.Clases.ComboBox01();
            this.txt_nombre = new CLASE05.Clases.LabelText02();
            this.txt_tiempo_envio = new CLASE05.Clases.LabelText02();
            this.txt_cod_articulo = new CLASE05.Clases.LabelText02();
            this.txt_plazo_pago = new CLASE05.Clases.LabelText02();
            this.txt_precio = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.cmb_lote = new CLASE05.Clases.ComboBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_proveedor = new CLASE05.Clases.ComboBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(547, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(477, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(512, 2);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_titulo.Location = new System.Drawing.Point(55, 59);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 17;
            this.lbl_titulo.Text = "Titulo";
            // 
            // txt_num_serie
            // 
            this.txt_num_serie._Ancho = 10;
            this.txt_num_serie._Decimales = 0;
            this.txt_num_serie._Etiqueta = "Número de serie";
            this.txt_num_serie._Mask = "CCCCCCCCCC";
            this.txt_num_serie._MensajeError = "El número de serie está vacío";
            this.txt_num_serie._Nombre_campo = "num_serie";
            this.txt_num_serie._Nombre_tabla = null;
            this.txt_num_serie._ReadOnly = false;
            this.txt_num_serie._Text = "";
            this.txt_num_serie._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_num_serie._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_num_serie._Validable = true;
            this.txt_num_serie.BackColor = System.Drawing.Color.Transparent;
            this.txt_num_serie.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_num_serie.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_num_serie.Location = new System.Drawing.Point(18, 184);
            this.txt_num_serie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_serie.Name = "txt_num_serie";
            this.txt_num_serie.Size = new System.Drawing.Size(260, 30);
            this.txt_num_serie.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(356, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(119, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Rubro";
            // 
            // cmb_paises
            // 
            this.cmb_paises._ComboSinSeleccion = true;
            this.cmb_paises._MensajeError = "Seleccionar país";
            this.cmb_paises._Nombre_campo = null;
            this.cmb_paises._Nombre_tabla = "";
            this.cmb_paises._tabla_cargar_combo = "pais";
            this.cmb_paises._tabla_cargar_descriptor = "nombre_pais";
            this.cmb_paises._tabla_cargar_pk = "id_pais";
            this.cmb_paises._tabla_join = null;
            this.cmb_paises._tabla_join_pk = null;
            this.cmb_paises._Validable = true;
            this.cmb_paises.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmb_paises.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_paises.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_paises.FormattingEnabled = true;
            this.cmb_paises.Location = new System.Drawing.Point(395, 260);
            this.cmb_paises.Name = "cmb_paises";
            this.cmb_paises.Size = new System.Drawing.Size(107, 25);
            this.cmb_paises.TabIndex = 52;
            // 
            // cmb_rubros
            // 
            this.cmb_rubros._ComboSinSeleccion = true;
            this.cmb_rubros._MensajeError = "Seleccionar rubro";
            this.cmb_rubros._Nombre_campo = null;
            this.cmb_rubros._Nombre_tabla = "";
            this.cmb_rubros._tabla_cargar_combo = "rubro";
            this.cmb_rubros._tabla_cargar_descriptor = "nombre";
            this.cmb_rubros._tabla_cargar_pk = "id_rubro";
            this.cmb_rubros._tabla_join = null;
            this.cmb_rubros._tabla_join_pk = null;
            this.cmb_rubros._Validable = true;
            this.cmb_rubros.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmb_rubros.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_rubros.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_rubros.FormattingEnabled = true;
            this.cmb_rubros.Location = new System.Drawing.Point(171, 260);
            this.cmb_rubros.Name = "cmb_rubros";
            this.cmb_rubros.Size = new System.Drawing.Size(107, 25);
            this.cmb_rubros.TabIndex = 50;
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 50;
            this.txt_nombre._Decimales = 2;
            this.txt_nombre._Etiqueta = "Nombre";
            this.txt_nombre._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nombre._MensajeError = "El nombre está vacío";
            this.txt_nombre._Nombre_campo = null;
            this.txt_nombre._Nombre_tabla = null;
            this.txt_nombre._ReadOnly = false;
            this.txt_nombre._Text = "";
            this.txt_nombre._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombre._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_nombre._Validable = true;
            this.txt_nombre.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombre.Location = new System.Drawing.Point(18, 108);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(484, 30);
            this.txt_nombre.TabIndex = 47;
            // 
            // txt_tiempo_envio
            // 
            this.txt_tiempo_envio._Ancho = 10;
            this.txt_tiempo_envio._Decimales = 2;
            this.txt_tiempo_envio._Etiqueta = "Tiempo de envío";
            this.txt_tiempo_envio._Mask = "CCCCCCCCCC";
            this.txt_tiempo_envio._MensajeError = "El tiempo de envío está vacío";
            this.txt_tiempo_envio._Nombre_campo = "tiempo_envio";
            this.txt_tiempo_envio._Nombre_tabla = null;
            this.txt_tiempo_envio._ReadOnly = false;
            this.txt_tiempo_envio._Text = "";
            this.txt_tiempo_envio._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_tiempo_envio._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_tiempo_envio._Validable = true;
            this.txt_tiempo_envio.BackColor = System.Drawing.Color.Transparent;
            this.txt_tiempo_envio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_tiempo_envio.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_tiempo_envio.Location = new System.Drawing.Point(18, 222);
            this.txt_tiempo_envio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tiempo_envio.Name = "txt_tiempo_envio";
            this.txt_tiempo_envio.Size = new System.Drawing.Size(260, 30);
            this.txt_tiempo_envio.TabIndex = 46;
            // 
            // txt_cod_articulo
            // 
            this.txt_cod_articulo._Ancho = 10;
            this.txt_cod_articulo._Decimales = 0;
            this.txt_cod_articulo._Etiqueta = "Código Artículo";
            this.txt_cod_articulo._Mask = "CCCCCCCCCC";
            this.txt_cod_articulo._MensajeError = "El código está vacío";
            this.txt_cod_articulo._Nombre_campo = "cod_articulo";
            this.txt_cod_articulo._Nombre_tabla = null;
            this.txt_cod_articulo._ReadOnly = false;
            this.txt_cod_articulo._Text = "";
            this.txt_cod_articulo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cod_articulo._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_cod_articulo._Validable = true;
            this.txt_cod_articulo.BackColor = System.Drawing.Color.Transparent;
            this.txt_cod_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_cod_articulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cod_articulo.Location = new System.Drawing.Point(18, 146);
            this.txt_cod_articulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cod_articulo.Name = "txt_cod_articulo";
            this.txt_cod_articulo.Size = new System.Drawing.Size(260, 30);
            this.txt_cod_articulo.TabIndex = 43;
            // 
            // txt_plazo_pago
            // 
            this.txt_plazo_pago._Ancho = 10;
            this.txt_plazo_pago._Decimales = 2;
            this.txt_plazo_pago._Etiqueta = "Plazo de pago";
            this.txt_plazo_pago._Mask = "00/00/0000";
            this.txt_plazo_pago._MensajeError = "El plazo de pago está vacío";
            this.txt_plazo_pago._Nombre_campo = "plazo_pago";
            this.txt_plazo_pago._Nombre_tabla = null;
            this.txt_plazo_pago._ReadOnly = false;
            this.txt_plazo_pago._Text = "  /  /";
            this.txt_plazo_pago._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_plazo_pago._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_plazo_pago._Validable = true;
            this.txt_plazo_pago.BackColor = System.Drawing.Color.Transparent;
            this.txt_plazo_pago.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_plazo_pago.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_plazo_pago.Location = new System.Drawing.Point(245, 222);
            this.txt_plazo_pago.Margin = new System.Windows.Forms.Padding(4);
            this.txt_plazo_pago.Name = "txt_plazo_pago";
            this.txt_plazo_pago.Size = new System.Drawing.Size(257, 30);
            this.txt_plazo_pago.TabIndex = 49;
            // 
            // txt_precio
            // 
            this.txt_precio._Ancho = 10;
            this.txt_precio._Decimales = 2;
            this.txt_precio._Etiqueta = "Precio";
            this.txt_precio._Mask = "9999999.99";
            this.txt_precio._MensajeError = "El precio está vacío";
            this.txt_precio._Nombre_campo = "precio";
            this.txt_precio._Nombre_tabla = null;
            this.txt_precio._ReadOnly = false;
            this.txt_precio._Text = "       .";
            this.txt_precio._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_precio._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_precio._Validable = true;
            this.txt_precio.BackColor = System.Drawing.Color.Transparent;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_precio.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precio.Location = new System.Drawing.Point(245, 146);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(257, 30);
            this.txt_precio.TabIndex = 51;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(245, 355);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 42;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // cmb_lote
            // 
            this.cmb_lote._ComboSinSeleccion = true;
            this.cmb_lote._MensajeError = "Seleccionar país";
            this.cmb_lote._Nombre_campo = null;
            this.cmb_lote._Nombre_tabla = "";
            this.cmb_lote._tabla_cargar_combo = "lote";
            this.cmb_lote._tabla_cargar_descriptor = "num_lote";
            this.cmb_lote._tabla_cargar_pk = "num_lote";
            this.cmb_lote._tabla_join = null;
            this.cmb_lote._tabla_join_pk = null;
            this.cmb_lote._Validable = true;
            this.cmb_lote.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmb_lote.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_lote.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_lote.FormattingEnabled = true;
            this.cmb_lote.Location = new System.Drawing.Point(395, 184);
            this.cmb_lote.Name = "cmb_lote";
            this.cmb_lote.Size = new System.Drawing.Size(107, 25);
            this.cmb_lote.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(285, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Número de lote";
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor._ComboSinSeleccion = true;
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
            this.cmb_proveedor.Location = new System.Drawing.Point(171, 291);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(107, 25);
            this.cmb_proveedor.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(94, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Proveedor";
            // 
            // Frm_Articulo
            // 
            this._FormularioMovil = true;
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(584, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_lote);
            this.Controls.Add(this.txt_num_serie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_paises);
            this.Controls.Add(this.cmb_rubros);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_tiempo_envio);
            this.Controls.Add(this.txt_cod_articulo);
            this.Controls.Add(this.txt_plazo_pago);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Articulo_Load);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.txt_precio, 0);
            this.Controls.SetChildIndex(this.txt_plazo_pago, 0);
            this.Controls.SetChildIndex(this.txt_cod_articulo, 0);
            this.Controls.SetChildIndex(this.txt_tiempo_envio, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.cmb_rubros, 0);
            this.Controls.SetChildIndex(this.cmb_paises, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_num_serie, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.cmb_lote, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmb_proveedor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        public Clases.LabelText02 txt_num_serie;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Clases.ComboBox01 cmb_paises;
        public Clases.ComboBox01 cmb_rubros;
        protected Clases.LabelText02 txt_nombre;
        public Clases.LabelText02 txt_tiempo_envio;
        public Clases.LabelText02 txt_cod_articulo;
        public Clases.LabelText02 txt_plazo_pago;
        public Clases.LabelText02 txt_precio;
        public System.Windows.Forms.Button btn_aceptar;
        public Clases.ComboBox01 cmb_lote;
        public System.Windows.Forms.Label label3;
        public Clases.ComboBox01 cmb_proveedor;
        private System.Windows.Forms.Label label4;
    }
}
