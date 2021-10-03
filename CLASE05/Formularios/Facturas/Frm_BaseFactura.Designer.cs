﻿
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
            this.grid011 = new CLASE05.Clases.Grid01();
            this.grid012 = new CLASE05.Clases.Grid01();
            this.txt_total_venta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox011 = new CLASE05.Clases.ComboBox01();
            this.btn_agregar_articulo = new System.Windows.Forms.Button();
            this.btn_agregar_ensamblado = new System.Windows.Forms.Button();
            this.comboBox012 = new CLASE05.Clases.ComboBox01();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.btn_quitar_ensamblado = new System.Windows.Forms.Button();
            this.btn_quitar_articulo = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid011)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid012)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(1049, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(979, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(1014, 2);
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
            this.txt_limite.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_limite.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_limite.Location = new System.Drawing.Point(-96, 321);
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
            this.txt_cuit_cliente.Location = new System.Drawing.Point(54, 208);
            this.txt_cuit_cliente.Mask = "99-99999999-9";
            this.txt_cuit_cliente.Name = "txt_cuit_cliente";
            this.txt_cuit_cliente.Size = new System.Drawing.Size(220, 25);
            this.txt_cuit_cliente.TabIndex = 67;
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
            this.cmb_pais.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_pais.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(54, 378);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(321, 25);
            this.cmb_pais.TabIndex = 57;
            // 
            // lbl_estado_provincia
            // 
            this.lbl_estado_provincia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado_provincia.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_estado_provincia.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_estado_provincia.Location = new System.Drawing.Point(52, 415);
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
            this.cmb_estado_provincia.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_estado_provincia.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_estado_provincia.FormattingEnabled = true;
            this.cmb_estado_provincia.Location = new System.Drawing.Point(55, 435);
            this.cmb_estado_provincia.Name = "cmb_estado_provincia";
            this.cmb_estado_provincia.Size = new System.Drawing.Size(322, 25);
            this.cmb_estado_provincia.TabIndex = 64;
            this.cmb_estado_provincia.Tag = "";
            this.cmb_estado_provincia.Text = "Seleccionar país...";
            // 
            // lbl_pais
            // 
            this.lbl_pais.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_pais.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_pais.Location = new System.Drawing.Point(51, 359);
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
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ciudad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_ciudad.Location = new System.Drawing.Point(-97, 487);
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
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_razon_social.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_razon_social.Location = new System.Drawing.Point(-97, 266);
            this.txt_razon_social.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(473, 30);
            this.txt_razon_social.TabIndex = 58;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Enabled = false;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_buscar.FlatAppearance.BorderSize = 2;
            this.btn_buscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(280, 207);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(97, 25);
            this.btn_buscar.TabIndex = 69;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(26, 153);
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
            this.label9.Location = new System.Drawing.Point(52, 187);
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
            this.label3.Location = new System.Drawing.Point(52, 250);
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
            this.label10.Location = new System.Drawing.Point(52, 305);
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
            this.label7.Location = new System.Drawing.Point(52, 471);
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
            this.label11.Location = new System.Drawing.Point(924, 569);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 76;
            this.label11.Text = "Total de la venta";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grid011
            // 
            this.grid011._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid011._tamannoLetraHeader = 9;
            this.grid011.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid011.Location = new System.Drawing.Point(587, 115);
            this.grid011.Name = "grid011";
            this.grid011.Size = new System.Drawing.Size(463, 165);
            this.grid011.TabIndex = 79;
            // 
            // grid012
            // 
            this.grid012._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid012._tamannoLetraHeader = 9;
            this.grid012.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid012.Location = new System.Drawing.Point(586, 386);
            this.grid012.Name = "grid012";
            this.grid012.Size = new System.Drawing.Size(463, 167);
            this.grid012.TabIndex = 80;
            // 
            // txt_total_venta
            // 
            this.txt_total_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_total_venta.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_total_venta.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_total_venta.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_total_venta.Location = new System.Drawing.Point(927, 592);
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
            this.label1.Location = new System.Drawing.Point(583, 44);
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
            this.label4.Location = new System.Drawing.Point(583, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 83;
            this.label4.Text = "Equipos Ensamblados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.maskedTextBox1.Culture = new System.Globalization.CultureInfo("en-US");
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox1.Location = new System.Drawing.Point(483, 136);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(97, 25);
            this.maskedTextBox1.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(480, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 84;
            this.label5.Text = "Precio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.maskedTextBox2.Culture = new System.Globalization.CultureInfo("en-US");
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.maskedTextBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox2.Location = new System.Drawing.Point(483, 187);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(97, 25);
            this.maskedTextBox2.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(480, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Cantidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox011
            // 
            this.comboBox011._ComboSinSeleccion = true;
            this.comboBox011._MensajeError = "No se ha seleccionado país";
            this.comboBox011._Nombre_campo = "";
            this.comboBox011._Nombre_tabla = "";
            this.comboBox011._tabla_cargar_combo = "pais";
            this.comboBox011._tabla_cargar_descriptor = "nombre_pais";
            this.comboBox011._tabla_cargar_pk = "id_pais";
            this.comboBox011._tabla_join = null;
            this.comboBox011._tabla_join_pk = null;
            this.comboBox011._Validable = true;
            this.comboBox011.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBox011.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox011.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBox011.FormattingEnabled = true;
            this.comboBox011.Location = new System.Drawing.Point(587, 67);
            this.comboBox011.Name = "comboBox011";
            this.comboBox011.Size = new System.Drawing.Size(286, 25);
            this.comboBox011.TabIndex = 88;
            // 
            // btn_agregar_articulo
            // 
            this.btn_agregar_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_articulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_articulo.Enabled = false;
            this.btn_agregar_articulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_articulo.FlatAppearance.BorderSize = 2;
            this.btn_agregar_articulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_agregar_articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_articulo.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_articulo.Location = new System.Drawing.Point(483, 218);
            this.btn_agregar_articulo.Name = "btn_agregar_articulo";
            this.btn_agregar_articulo.Size = new System.Drawing.Size(97, 28);
            this.btn_agregar_articulo.TabIndex = 89;
            this.btn_agregar_articulo.TabStop = false;
            this.btn_agregar_articulo.Text = "Agregar";
            this.btn_agregar_articulo.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_ensamblado
            // 
            this.btn_agregar_ensamblado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_ensamblado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_ensamblado.Enabled = false;
            this.btn_agregar_ensamblado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_agregar_ensamblado.FlatAppearance.BorderSize = 2;
            this.btn_agregar_ensamblado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_agregar_ensamblado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_ensamblado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_ensamblado.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_ensamblado.Location = new System.Drawing.Point(483, 491);
            this.btn_agregar_ensamblado.Name = "btn_agregar_ensamblado";
            this.btn_agregar_ensamblado.Size = new System.Drawing.Size(97, 28);
            this.btn_agregar_ensamblado.TabIndex = 90;
            this.btn_agregar_ensamblado.TabStop = false;
            this.btn_agregar_ensamblado.Text = "Agregar";
            this.btn_agregar_ensamblado.UseVisualStyleBackColor = false;
            // 
            // comboBox012
            // 
            this.comboBox012._ComboSinSeleccion = true;
            this.comboBox012._MensajeError = "No se ha seleccionado país";
            this.comboBox012._Nombre_campo = "";
            this.comboBox012._Nombre_tabla = "";
            this.comboBox012._tabla_cargar_combo = "pais";
            this.comboBox012._tabla_cargar_descriptor = "nombre_pais";
            this.comboBox012._tabla_cargar_pk = "id_pais";
            this.comboBox012._tabla_join = null;
            this.comboBox012._tabla_join_pk = null;
            this.comboBox012._Validable = true;
            this.comboBox012.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBox012.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox012.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBox012.FormattingEnabled = true;
            this.comboBox012.Location = new System.Drawing.Point(586, 339);
            this.comboBox012.Name = "comboBox012";
            this.comboBox012.Size = new System.Drawing.Size(287, 25);
            this.comboBox012.TabIndex = 96;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.maskedTextBox3.Culture = new System.Globalization.CultureInfo("en-US");
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.maskedTextBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox3.Location = new System.Drawing.Point(483, 460);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(97, 25);
            this.maskedTextBox3.TabIndex = 95;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(480, 437);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 94;
            this.label13.Text = "Cantidad";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.maskedTextBox4.Culture = new System.Globalization.CultureInfo("en-US");
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.maskedTextBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox4.Location = new System.Drawing.Point(483, 409);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(97, 25);
            this.maskedTextBox4.TabIndex = 93;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(480, 386);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 92;
            this.label14.Text = "Precio";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.maskedTextBox5.Culture = new System.Globalization.CultureInfo("en-US");
            this.maskedTextBox5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.maskedTextBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox5.Location = new System.Drawing.Point(54, 110);
            this.maskedTextBox5.Mask = "99/99/9999";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(128, 25);
            this.maskedTextBox5.TabIndex = 97;
            // 
            // btn_quitar_ensamblado
            // 
            this.btn_quitar_ensamblado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_ensamblado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar_ensamblado.Enabled = false;
            this.btn_quitar_ensamblado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_ensamblado.FlatAppearance.BorderSize = 2;
            this.btn_quitar_ensamblado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_quitar_ensamblado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar_ensamblado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_ensamblado.ForeColor = System.Drawing.Color.White;
            this.btn_quitar_ensamblado.Location = new System.Drawing.Point(483, 525);
            this.btn_quitar_ensamblado.Name = "btn_quitar_ensamblado";
            this.btn_quitar_ensamblado.Size = new System.Drawing.Size(97, 28);
            this.btn_quitar_ensamblado.TabIndex = 98;
            this.btn_quitar_ensamblado.TabStop = false;
            this.btn_quitar_ensamblado.Text = "Quitar";
            this.btn_quitar_ensamblado.UseVisualStyleBackColor = false;
            // 
            // btn_quitar_articulo
            // 
            this.btn_quitar_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_articulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar_articulo.Enabled = false;
            this.btn_quitar_articulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_quitar_articulo.FlatAppearance.BorderSize = 2;
            this.btn_quitar_articulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_quitar_articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_articulo.ForeColor = System.Drawing.Color.White;
            this.btn_quitar_articulo.Location = new System.Drawing.Point(483, 252);
            this.btn_quitar_articulo.Name = "btn_quitar_articulo";
            this.btn_quitar_articulo.Size = new System.Drawing.Size(97, 28);
            this.btn_quitar_articulo.TabIndex = 99;
            this.btn_quitar_articulo.TabStop = false;
            this.btn_quitar_articulo.Text = "Quitar";
            this.btn_quitar_articulo.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(26, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 102;
            this.label16.Text = "Fecha Actual";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGenerarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarFactura.Enabled = false;
            this.btnGenerarFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGenerarFactura.FlatAppearance.BorderSize = 2;
            this.btnGenerarFactura.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.ForeColor = System.Drawing.Color.White;
            this.btnGenerarFactura.Location = new System.Drawing.Point(457, 623);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(123, 29);
            this.btnGenerarFactura.TabIndex = 107;
            this.btnGenerarFactura.TabStop = false;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(618, 623);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 105;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Grabar Venta";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGenerarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnGenerarVenta.FlatAppearance.BorderSize = 2;
            this.btnGenerarVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGenerarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarVenta.ForeColor = System.Drawing.Color.White;
            this.btnGenerarVenta.Location = new System.Drawing.Point(309, 623);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(123, 29);
            this.btnGenerarVenta.TabIndex = 103;
            this.btnGenerarVenta.TabStop = false;
            this.btnGenerarVenta.Text = "Nueva Venta";
            this.btnGenerarVenta.UseVisualStyleBackColor = false;
            // 
            // btn_alta
            // 
            this.btn_alta.BackColor = System.Drawing.Color.Transparent;
            this.btn_alta.BackgroundImage = global::CLASE05.Properties.Resources.btn_añadir__8_;
            this.btn_alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alta.Location = new System.Drawing.Point(53, 597);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(50, 50);
            this.btn_alta.TabIndex = 110;
            this.btn_alta.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CLASE05.Properties.Resources.btn_guardar__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(109, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 112;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_BaseFactura
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1086, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_quitar_articulo);
            this.Controls.Add(this.btn_quitar_ensamblado);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.comboBox012);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_agregar_ensamblado);
            this.Controls.Add(this.btn_agregar_articulo);
            this.Controls.Add(this.comboBox011);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total_venta);
            this.Controls.Add(this.grid012);
            this.Controls.Add(this.grid011);
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
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.grid011, 0);
            this.Controls.SetChildIndex(this.grid012, 0);
            this.Controls.SetChildIndex(this.txt_total_venta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.maskedTextBox2, 0);
            this.Controls.SetChildIndex(this.comboBox011, 0);
            this.Controls.SetChildIndex(this.btn_agregar_articulo, 0);
            this.Controls.SetChildIndex(this.btn_agregar_ensamblado, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.maskedTextBox4, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.maskedTextBox3, 0);
            this.Controls.SetChildIndex(this.comboBox012, 0);
            this.Controls.SetChildIndex(this.maskedTextBox5, 0);
            this.Controls.SetChildIndex(this.btn_quitar_ensamblado, 0);
            this.Controls.SetChildIndex(this.btn_quitar_articulo, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btnGenerarVenta, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnGenerarFactura, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid011)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid012)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label2;
        public Clases.LabelText02 txt_limite;
        public System.Windows.Forms.MaskedTextBox txt_cuit_cliente;
        public Clases.ComboBox01 cmb_pais;
        private System.Windows.Forms.Label lbl_estado_provincia;
        public Clases.ComboBox01 cmb_estado_provincia;
        private System.Windows.Forms.Label lbl_pais;
        public Clases.LabelText02 txt_ciudad;
        public Clases.LabelText02 txt_razon_social;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private Clases.Grid01 grid011;
        private Clases.Grid01 grid012;
        public System.Windows.Forms.MaskedTextBox txt_total_venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label6;
        public Clases.ComboBox01 comboBox011;
        private System.Windows.Forms.Button btn_agregar_articulo;
        private System.Windows.Forms.Button btn_agregar_ensamblado;
        public Clases.ComboBox01 comboBox012;
        public System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Button btn_quitar_ensamblado;
        private System.Windows.Forms.Button btn_quitar_articulo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGenerarVenta;
        public System.Windows.Forms.Button btn_alta;
        public System.Windows.Forms.Button button1;
    }
}