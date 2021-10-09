
namespace CLASE05.Formularios.Facturas
{
    partial class Frm_BaseFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_limite = new CLASE05.Clases.LabelText02();
            this.txt_cuit_cliente = new System.Windows.Forms.MaskedTextBox();
            this.cmb_pais = new CLASE05.Clases.ComboBox01();
            this.lbl_estado_provincia = new System.Windows.Forms.Label();
            this.cmb_estado_provincia = new CLASE05.Clases.ComboBox01();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_ciudad = new CLASE05.Clases.LabelText02();
            this.txt_razon_social = new CLASE05.Clases.LabelText02();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grid_articulos = new CLASE05.Clases.Grid01();
            this.grid_ensamblados = new CLASE05.Clases.Grid01();
            this.txt_total_venta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidad_articulo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_articulos = new CLASE05.Clases.ComboBox01();
            this.btn_agregar_articulo = new System.Windows.Forms.Button();
            this.btn_agregar_ensamblado = new System.Windows.Forms.Button();
            this.cmb_ensamblados = new CLASE05.Clases.ComboBox01();
            this.txt_cantidad_ensamblado = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_fechaActual = new System.Windows.Forms.MaskedTextBox();
            this.btn_quitar_ensamblado = new System.Windows.Forms.Button();
            this.btn_quitar_articulo = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMostrarFactura = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.txt_precio_ensamblado = new System.Windows.Forms.MaskedTextBox();
            this.txt_precio_articulo = new System.Windows.Forms.MaskedTextBox();
            this.txt_legajo_empleado = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_tipo_factura = new CLASE05.Clases.ComboBox01();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_stock_articulo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_stock_ensamblado = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ensamblados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(1026, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(956, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(991, 2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Titulo";
            this.label2.Visible = false;
            // 
            // txt_limite
            // 
            this.txt_limite._Ancho = 10;
            this.txt_limite._Decimales = 2;
            this.txt_limite._Etiqueta = "";
            this.txt_limite._Mask = "9999999.99";
            this.txt_limite._MensajeError = null;
            this.txt_limite._Nombre_campo = null;
            this.txt_limite._Nombre_tabla = null;
            this.txt_limite._ReadOnly = false;
            this.txt_limite._StartEnCero = true;
            this.txt_limite._Text = "       .";
            this.txt_limite._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_limite._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_limite._Validable = true;
            this.txt_limite.BackColor = System.Drawing.Color.Transparent;
            this.txt_limite.Enabled = false;
            this.txt_limite.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_limite.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_limite.Location = new System.Drawing.Point(-96, 294);
            this.txt_limite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_limite.Name = "txt_limite";
            this.txt_limite.Size = new System.Drawing.Size(472, 30);
            this.txt_limite.TabIndex = 68;
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_cuit_cliente.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_cuit_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_cuit_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuit_cliente.Location = new System.Drawing.Point(54, 197);
            this.txt_cuit_cliente.Mask = "99-99999999-9";
            this.txt_cuit_cliente.Name = "txt_cuit_cliente";
            this.txt_cuit_cliente.Size = new System.Drawing.Size(220, 25);
            this.txt_cuit_cliente.TabIndex = 67;
            this.txt_cuit_cliente.Click += new System.EventHandler(this.txt_cuit_cliente_Click);
            // 
            // cmb_pais
            // 
            this.cmb_pais._ComboSinSeleccion = true;
            this.cmb_pais._MensajeError = "No se ha seleccionado país";
            this.cmb_pais._Nombre_campo = "";
            this.cmb_pais._Nombre_tabla = "";
            this.cmb_pais._tabla_cargar_combo = "pais";
            this.cmb_pais._tabla_cargar_descriptor = "nombre_pais";
            this.cmb_pais._tabla_cargar_pk = "id_pais";
            this.cmb_pais._tabla_join = null;
            this.cmb_pais._tabla_join_pk = null;
            this.cmb_pais._Validable = true;
            this.cmb_pais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_pais.Enabled = false;
            this.cmb_pais.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_pais.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(54, 345);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(321, 25);
            this.cmb_pais.TabIndex = 57;
            // 
            // lbl_estado_provincia
            // 
            this.lbl_estado_provincia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado_provincia.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_estado_provincia.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_estado_provincia.Location = new System.Drawing.Point(52, 377);
            this.lbl_estado_provincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado_provincia.Name = "lbl_estado_provincia";
            this.lbl_estado_provincia.Size = new System.Drawing.Size(144, 20);
            this.lbl_estado_provincia.TabIndex = 65;
            this.lbl_estado_provincia.Text = "Estado/Provincia";
            this.lbl_estado_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_estado_provincia
            // 
            this.cmb_estado_provincia._ComboSinSeleccion = true;
            this.cmb_estado_provincia._MensajeError = "No se ha seleccionado estado/provincia";
            this.cmb_estado_provincia._Nombre_campo = null;
            this.cmb_estado_provincia._Nombre_tabla = null;
            this.cmb_estado_provincia._tabla_cargar_combo = "estado_provincia";
            this.cmb_estado_provincia._tabla_cargar_descriptor = "nombre_estado_provincia";
            this.cmb_estado_provincia._tabla_cargar_pk = "id_estado_provincia";
            this.cmb_estado_provincia._tabla_join = "pais";
            this.cmb_estado_provincia._tabla_join_pk = "id_pais";
            this.cmb_estado_provincia._Validable = true;
            this.cmb_estado_provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_estado_provincia.Enabled = false;
            this.cmb_estado_provincia.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_estado_provincia.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_estado_provincia.FormattingEnabled = true;
            this.cmb_estado_provincia.Location = new System.Drawing.Point(55, 397);
            this.cmb_estado_provincia.Name = "cmb_estado_provincia";
            this.cmb_estado_provincia.Size = new System.Drawing.Size(322, 25);
            this.cmb_estado_provincia.TabIndex = 64;
            this.cmb_estado_provincia.Tag = "";
            // 
            // lbl_pais
            // 
            this.lbl_pais.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_pais.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_pais.Location = new System.Drawing.Point(51, 326);
            this.lbl_pais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(61, 20);
            this.lbl_pais.TabIndex = 63;
            this.lbl_pais.Text = "País";
            this.lbl_pais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad._Ancho = 10;
            this.txt_ciudad._Decimales = 2;
            this.txt_ciudad._Etiqueta = "";
            this.txt_ciudad._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_ciudad._MensajeError = "Ciudad está vacía";
            this.txt_ciudad._Nombre_campo = null;
            this.txt_ciudad._Nombre_tabla = null;
            this.txt_ciudad._ReadOnly = false;
            this.txt_ciudad._StartEnCero = false;
            this.txt_ciudad._Text = "";
            this.txt_ciudad._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_ciudad._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_ciudad._Validable = true;
            this.txt_ciudad.BackColor = System.Drawing.Color.Transparent;
            this.txt_ciudad.Enabled = false;
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ciudad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_ciudad.Location = new System.Drawing.Point(-97, 445);
            this.txt_ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(474, 30);
            this.txt_ciudad.TabIndex = 62;
            // 
            // txt_razon_social
            // 
            this.txt_razon_social._Ancho = 50;
            this.txt_razon_social._Decimales = 2;
            this.txt_razon_social._Etiqueta = "";
            this.txt_razon_social._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_razon_social._MensajeError = "Razón social está vacía";
            this.txt_razon_social._Nombre_campo = null;
            this.txt_razon_social._Nombre_tabla = null;
            this.txt_razon_social._ReadOnly = false;
            this.txt_razon_social._StartEnCero = false;
            this.txt_razon_social._Text = "";
            this.txt_razon_social._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_razon_social._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_razon_social._Validable = true;
            this.txt_razon_social.BackColor = System.Drawing.Color.Transparent;
            this.txt_razon_social.Enabled = false;
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_razon_social.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_razon_social.Location = new System.Drawing.Point(-97, 244);
            this.txt_razon_social.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(473, 30);
            this.txt_razon_social.TabIndex = 58;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar.FlatAppearance.BorderSize = 2;
            this.btn_buscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(280, 196);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(97, 25);
            this.btn_buscar.TabIndex = 69;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(26, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Datos del Cliente";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(52, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 71;
            this.label9.Text = "CUIT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(52, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Razón social";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(52, 278);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 73;
            this.label10.Text = "Límite Crédito";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(52, 429);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Ciudad";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(897, 544);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 76;
            this.label11.Text = "Total ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grid_articulos
            // 
            this.grid_articulos._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid_articulos._tamannoLetraHeader = 9;
            this.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulos.Location = new System.Drawing.Point(559, 102);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.Size = new System.Drawing.Size(463, 165);
            this.grid_articulos.TabIndex = 79;
            // 
            // grid_ensamblados
            // 
            this.grid_ensamblados._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid_ensamblados._tamannoLetraHeader = 9;
            this.grid_ensamblados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ensamblados.Location = new System.Drawing.Point(558, 342);
            this.grid_ensamblados.Name = "grid_ensamblados";
            this.grid_ensamblados.Size = new System.Drawing.Size(463, 167);
            this.grid_ensamblados.TabIndex = 80;
            // 
            // txt_total_venta
            // 
            this.txt_total_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_total_venta.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_total_venta.Enabled = false;
            this.txt_total_venta.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_total_venta.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_total_venta.Location = new System.Drawing.Point(900, 567);
            this.txt_total_venta.Name = "txt_total_venta";
            this.txt_total_venta.Size = new System.Drawing.Size(122, 25);
            this.txt_total_venta.TabIndex = 81;
            this.txt_total_venta.Text = "$0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(555, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Artículos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(555, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 83;
            this.label4.Text = "Equipos Ensamblados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(452, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 84;
            this.label5.Text = "Precio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cantidad_articulo
            // 
            this.txt_cantidad_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_cantidad_articulo.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_cantidad_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_cantidad_articulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cantidad_articulo.Location = new System.Drawing.Point(455, 174);
            this.txt_cantidad_articulo.Mask = "9999999";
            this.txt_cantidad_articulo.Name = "txt_cantidad_articulo";
            this.txt_cantidad_articulo.Size = new System.Drawing.Size(97, 25);
            this.txt_cantidad_articulo.TabIndex = 87;
            this.txt_cantidad_articulo.Click += new System.EventHandler(this.txt_cantidad_articulo_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(452, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Cantidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_articulos
            // 
            this.cmb_articulos._ComboSinSeleccion = true;
            this.cmb_articulos._MensajeError = "No se ha seleccionado país";
            this.cmb_articulos._Nombre_campo = "";
            this.cmb_articulos._Nombre_tabla = "";
            this.cmb_articulos._tabla_cargar_combo = "articulo";
            this.cmb_articulos._tabla_cargar_descriptor = "nombre";
            this.cmb_articulos._tabla_cargar_pk = "cod_articulo";
            this.cmb_articulos._tabla_join = null;
            this.cmb_articulos._tabla_join_pk = null;
            this.cmb_articulos._Validable = true;
            this.cmb_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_articulos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_articulos.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_articulos.FormattingEnabled = true;
            this.cmb_articulos.Location = new System.Drawing.Point(559, 67);
            this.cmb_articulos.Name = "cmb_articulos";
            this.cmb_articulos.Size = new System.Drawing.Size(286, 25);
            this.cmb_articulos.TabIndex = 88;
            this.cmb_articulos.SelectionChangeCommitted += new System.EventHandler(this.cmb_articulos_SelectionChangeCommitted);
            // 
            // btn_agregar_articulo
            // 
            this.btn_agregar_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_articulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_articulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_articulo.FlatAppearance.BorderSize = 2;
            this.btn_agregar_articulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_agregar_articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_articulo.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_articulo.Location = new System.Drawing.Point(455, 205);
            this.btn_agregar_articulo.Name = "btn_agregar_articulo";
            this.btn_agregar_articulo.Size = new System.Drawing.Size(97, 28);
            this.btn_agregar_articulo.TabIndex = 89;
            this.btn_agregar_articulo.TabStop = false;
            this.btn_agregar_articulo.Text = "Agregar";
            this.btn_agregar_articulo.UseVisualStyleBackColor = false;
            this.btn_agregar_articulo.Click += new System.EventHandler(this.btn_agregar_articulo_Click);
            // 
            // btn_agregar_ensamblado
            // 
            this.btn_agregar_ensamblado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_ensamblado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_ensamblado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_ensamblado.FlatAppearance.BorderSize = 2;
            this.btn_agregar_ensamblado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_agregar_ensamblado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_ensamblado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_ensamblado.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_ensamblado.Location = new System.Drawing.Point(455, 447);
            this.btn_agregar_ensamblado.Name = "btn_agregar_ensamblado";
            this.btn_agregar_ensamblado.Size = new System.Drawing.Size(97, 28);
            this.btn_agregar_ensamblado.TabIndex = 90;
            this.btn_agregar_ensamblado.TabStop = false;
            this.btn_agregar_ensamblado.Text = "Agregar";
            this.btn_agregar_ensamblado.UseVisualStyleBackColor = false;
            this.btn_agregar_ensamblado.Click += new System.EventHandler(this.btn_agregar_ensamblado_Click);
            // 
            // cmb_ensamblados
            // 
            this.cmb_ensamblados._ComboSinSeleccion = true;
            this.cmb_ensamblados._MensajeError = "No se ha seleccionado país";
            this.cmb_ensamblados._Nombre_campo = "";
            this.cmb_ensamblados._Nombre_tabla = "";
            this.cmb_ensamblados._tabla_cargar_combo = "producto_ensamblado";
            this.cmb_ensamblados._tabla_cargar_descriptor = "nombre";
            this.cmb_ensamblados._tabla_cargar_pk = "cod_prod_ensamblado";
            this.cmb_ensamblados._tabla_join = null;
            this.cmb_ensamblados._tabla_join_pk = null;
            this.cmb_ensamblados._Validable = true;
            this.cmb_ensamblados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_ensamblados.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_ensamblados.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_ensamblados.FormattingEnabled = true;
            this.cmb_ensamblados.Location = new System.Drawing.Point(558, 306);
            this.cmb_ensamblados.Name = "cmb_ensamblados";
            this.cmb_ensamblados.Size = new System.Drawing.Size(287, 25);
            this.cmb_ensamblados.TabIndex = 96;
            this.cmb_ensamblados.SelectionChangeCommitted += new System.EventHandler(this.cmb_ensamblados_SelectionChangeCommitted);
            // 
            // txt_cantidad_ensamblado
            // 
            this.txt_cantidad_ensamblado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_cantidad_ensamblado.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_cantidad_ensamblado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_cantidad_ensamblado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cantidad_ensamblado.Location = new System.Drawing.Point(455, 416);
            this.txt_cantidad_ensamblado.Mask = "9999999";
            this.txt_cantidad_ensamblado.Name = "txt_cantidad_ensamblado";
            this.txt_cantidad_ensamblado.Size = new System.Drawing.Size(97, 25);
            this.txt_cantidad_ensamblado.TabIndex = 95;
            this.txt_cantidad_ensamblado.Click += new System.EventHandler(this.txt_cantidad_ensamblado_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(452, 393);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 94;
            this.label13.Text = "Cantidad";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(452, 342);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 92;
            this.label14.Text = "Precio";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_fechaActual
            // 
            this.txt_fechaActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaActual.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaActual.Enabled = false;
            this.txt_fechaActual.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaActual.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fechaActual.Location = new System.Drawing.Point(54, 102);
            this.txt_fechaActual.Name = "txt_fechaActual";
            this.txt_fechaActual.Size = new System.Drawing.Size(159, 25);
            this.txt_fechaActual.TabIndex = 97;
            // 
            // btn_quitar_ensamblado
            // 
            this.btn_quitar_ensamblado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_ensamblado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar_ensamblado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_ensamblado.FlatAppearance.BorderSize = 2;
            this.btn_quitar_ensamblado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_quitar_ensamblado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar_ensamblado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_ensamblado.ForeColor = System.Drawing.Color.White;
            this.btn_quitar_ensamblado.Location = new System.Drawing.Point(455, 481);
            this.btn_quitar_ensamblado.Name = "btn_quitar_ensamblado";
            this.btn_quitar_ensamblado.Size = new System.Drawing.Size(97, 28);
            this.btn_quitar_ensamblado.TabIndex = 98;
            this.btn_quitar_ensamblado.TabStop = false;
            this.btn_quitar_ensamblado.Text = "Quitar";
            this.btn_quitar_ensamblado.UseVisualStyleBackColor = false;
            this.btn_quitar_ensamblado.Click += new System.EventHandler(this.btn_quitar_ensamblado_Click);
            // 
            // btn_quitar_articulo
            // 
            this.btn_quitar_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_articulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar_articulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_articulo.FlatAppearance.BorderSize = 2;
            this.btn_quitar_articulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_quitar_articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_articulo.ForeColor = System.Drawing.Color.White;
            this.btn_quitar_articulo.Location = new System.Drawing.Point(455, 239);
            this.btn_quitar_articulo.Name = "btn_quitar_articulo";
            this.btn_quitar_articulo.Size = new System.Drawing.Size(97, 28);
            this.btn_quitar_articulo.TabIndex = 99;
            this.btn_quitar_articulo.TabStop = false;
            this.btn_quitar_articulo.Text = "Quitar";
            this.btn_quitar_articulo.UseVisualStyleBackColor = false;
            this.btn_quitar_articulo.Click += new System.EventHandler(this.btn_quitar_articulo_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(47, 79);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 102;
            this.label16.Text = "Fecha Actual";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMostrarFactura
            // 
            this.btnMostrarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnMostrarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnMostrarFactura.FlatAppearance.BorderSize = 2;
            this.btnMostrarFactura.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnMostrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarFactura.ForeColor = System.Drawing.Color.White;
            this.btnMostrarFactura.Location = new System.Drawing.Point(203, 563);
            this.btnMostrarFactura.Name = "btnMostrarFactura";
            this.btnMostrarFactura.Size = new System.Drawing.Size(123, 29);
            this.btnMostrarFactura.TabIndex = 107;
            this.btnMostrarFactura.TabStop = false;
            this.btnMostrarFactura.Text = "Ver Factura";
            this.btnMostrarFactura.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(748, 563);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 105;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Grabar Venta";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnNuevaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnNuevaVenta.FlatAppearance.BorderSize = 2;
            this.btnNuevaVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVenta.Location = new System.Drawing.Point(52, 563);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(123, 29);
            this.btnNuevaVenta.TabIndex = 103;
            this.btnNuevaVenta.TabStop = false;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // txt_precio_ensamblado
            // 
            this.txt_precio_ensamblado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_precio_ensamblado.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_precio_ensamblado.Enabled = false;
            this.txt_precio_ensamblado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_precio_ensamblado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precio_ensamblado.Location = new System.Drawing.Point(455, 365);
            this.txt_precio_ensamblado.Name = "txt_precio_ensamblado";
            this.txt_precio_ensamblado.Size = new System.Drawing.Size(97, 25);
            this.txt_precio_ensamblado.TabIndex = 93;
            // 
            // txt_precio_articulo
            // 
            this.txt_precio_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_precio_articulo.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_precio_articulo.Enabled = false;
            this.txt_precio_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_precio_articulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precio_articulo.Location = new System.Drawing.Point(455, 123);
            this.txt_precio_articulo.Name = "txt_precio_articulo";
            this.txt_precio_articulo.Size = new System.Drawing.Size(97, 25);
            this.txt_precio_articulo.TabIndex = 85;
            // 
            // txt_legajo_empleado
            // 
            this.txt_legajo_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_legajo_empleado.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_legajo_empleado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_legajo_empleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_legajo_empleado.Location = new System.Drawing.Point(54, 501);
            this.txt_legajo_empleado.Mask = "999999";
            this.txt_legajo_empleado.Name = "txt_legajo_empleado";
            this.txt_legajo_empleado.Size = new System.Drawing.Size(321, 25);
            this.txt_legajo_empleado.TabIndex = 113;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(52, 480);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 114;
            this.label12.Text = "Legajo empleado";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura._ComboSinSeleccion = true;
            this.cmb_tipo_factura._MensajeError = "No se ha seleccionado estado/provincia";
            this.cmb_tipo_factura._Nombre_campo = null;
            this.cmb_tipo_factura._Nombre_tabla = null;
            this.cmb_tipo_factura._tabla_cargar_combo = "tipo_factura";
            this.cmb_tipo_factura._tabla_cargar_descriptor = "nombre";
            this.cmb_tipo_factura._tabla_cargar_pk = "id_tipo_factura";
            this.cmb_tipo_factura._tabla_join = "";
            this.cmb_tipo_factura._tabla_join_pk = "";
            this.cmb_tipo_factura._Validable = true;
            this.cmb_tipo_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_tipo_factura.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_tipo_factura.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_tipo_factura.FormattingEnabled = true;
            this.cmb_tipo_factura.Location = new System.Drawing.Point(219, 102);
            this.cmb_tipo_factura.Name = "cmb_tipo_factura";
            this.cmb_tipo_factura.Size = new System.Drawing.Size(158, 25);
            this.cmb_tipo_factura.TabIndex = 115;
            this.cmb_tipo_factura.Tag = "";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(215, 79);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 20);
            this.label17.TabIndex = 117;
            this.label17.Text = "Tipo factura";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_stock_articulo
            // 
            this.txt_stock_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_stock_articulo.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_stock_articulo.Enabled = false;
            this.txt_stock_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_stock_articulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_stock_articulo.Location = new System.Drawing.Point(878, 67);
            this.txt_stock_articulo.Mask = "9999999";
            this.txt_stock_articulo.Name = "txt_stock_articulo";
            this.txt_stock_articulo.Size = new System.Drawing.Size(97, 25);
            this.txt_stock_articulo.TabIndex = 119;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(875, 45);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 118;
            this.label15.Text = "Stock actual";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_stock_ensamblado
            // 
            this.txt_stock_ensamblado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_stock_ensamblado.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_stock_ensamblado.Enabled = false;
            this.txt_stock_ensamblado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_stock_ensamblado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_stock_ensamblado.Location = new System.Drawing.Point(878, 306);
            this.txt_stock_ensamblado.Mask = "9999999";
            this.txt_stock_ensamblado.Name = "txt_stock_ensamblado";
            this.txt_stock_ensamblado.Size = new System.Drawing.Size(97, 25);
            this.txt_stock_ensamblado.TabIndex = 124;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(875, 284);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 20);
            this.label18.TabIndex = 123;
            this.label18.Text = "Stock actual";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_BaseFactura
            // 
            this._FormularioMovil = true;
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1063, 613);
            this.Controls.Add(this.txt_stock_ensamblado);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_stock_articulo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmb_tipo_factura);
            this.Controls.Add(this.txt_legajo_empleado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnMostrarFactura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_quitar_articulo);
            this.Controls.Add(this.btn_quitar_ensamblado);
            this.Controls.Add(this.txt_fechaActual);
            this.Controls.Add(this.cmb_ensamblados);
            this.Controls.Add(this.txt_cantidad_ensamblado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_precio_ensamblado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_agregar_ensamblado);
            this.Controls.Add(this.btn_agregar_articulo);
            this.Controls.Add(this.cmb_articulos);
            this.Controls.Add(this.txt_cantidad_articulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_precio_articulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total_venta);
            this.Controls.Add(this.grid_ensamblados);
            this.Controls.Add(this.grid_articulos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_limite);
            this.Controls.Add(this.txt_cuit_cliente);
            this.Controls.Add(this.cmb_pais);
            this.Controls.Add(this.lbl_estado_provincia);
            this.Controls.Add(this.cmb_estado_provincia);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.txt_razon_social);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "Frm_BaseFactura";
            this.Load += new System.EventHandler(this.Frm_BaseFactura_Load);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_razon_social, 0);
            this.Controls.SetChildIndex(this.txt_ciudad, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lbl_pais, 0);
            this.Controls.SetChildIndex(this.cmb_estado_provincia, 0);
            this.Controls.SetChildIndex(this.lbl_estado_provincia, 0);
            this.Controls.SetChildIndex(this.cmb_pais, 0);
            this.Controls.SetChildIndex(this.txt_cuit_cliente, 0);
            this.Controls.SetChildIndex(this.txt_limite, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.grid_articulos, 0);
            this.Controls.SetChildIndex(this.grid_ensamblados, 0);
            this.Controls.SetChildIndex(this.txt_total_venta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_precio_articulo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_cantidad_articulo, 0);
            this.Controls.SetChildIndex(this.cmb_articulos, 0);
            this.Controls.SetChildIndex(this.btn_agregar_articulo, 0);
            this.Controls.SetChildIndex(this.btn_agregar_ensamblado, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txt_precio_ensamblado, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txt_cantidad_ensamblado, 0);
            this.Controls.SetChildIndex(this.cmb_ensamblados, 0);
            this.Controls.SetChildIndex(this.txt_fechaActual, 0);
            this.Controls.SetChildIndex(this.btn_quitar_ensamblado, 0);
            this.Controls.SetChildIndex(this.btn_quitar_articulo, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btnNuevaVenta, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnMostrarFactura, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txt_legajo_empleado, 0);
            this.Controls.SetChildIndex(this.cmb_tipo_factura, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txt_stock_articulo, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.txt_stock_ensamblado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ensamblados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label2;
        public Clases.LabelText02 txt_limite;
        public System.Windows.Forms.MaskedTextBox txt_cuit_cliente;
        public Clases.ComboBox01 cmb_pais;
        public Clases.ComboBox01 cmb_estado_provincia;
        public Clases.LabelText02 txt_ciudad;
        public Clases.LabelText02 txt_razon_social;
        public System.Windows.Forms.MaskedTextBox txt_total_venta;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox txt_cantidad_articulo;
        public Clases.ComboBox01 cmb_articulos;
        public Clases.ComboBox01 cmb_ensamblados;
        public System.Windows.Forms.MaskedTextBox txt_cantidad_ensamblado;
        public System.Windows.Forms.MaskedTextBox txt_fechaActual;
        public System.Windows.Forms.Label lbl_estado_provincia;
        public System.Windows.Forms.Label lbl_pais;
        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label11;
        public Clases.Grid01 grid_articulos;
        public Clases.Grid01 grid_ensamblados;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_agregar_articulo;
        public System.Windows.Forms.Button btn_agregar_ensamblado;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button btn_quitar_ensamblado;
        public System.Windows.Forms.Button btn_quitar_articulo;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button btnMostrarFactura;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevaVenta;
        public System.Windows.Forms.MaskedTextBox txt_precio_ensamblado;
        public System.Windows.Forms.MaskedTextBox txt_precio_articulo;
        public System.Windows.Forms.MaskedTextBox txt_legajo_empleado;
        public System.Windows.Forms.Label label12;
        public Clases.ComboBox01 cmb_tipo_factura;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.MaskedTextBox txt_stock_articulo;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.MaskedTextBox txt_stock_ensamblado;
        public System.Windows.Forms.Label label18;
    }
}
