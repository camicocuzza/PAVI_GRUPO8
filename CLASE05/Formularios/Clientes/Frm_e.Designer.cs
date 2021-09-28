﻿
namespace CLASE05.Formularios.Clientes
{
    partial class Frm_e
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
            this.cmb_pais = new CLASE05.Clases.ComboBox01();
            this.txt_razon_social = new CLASE05.Clases.LabelText02();
            this.txt_nombre_contacto = new CLASE05.Clases.LabelText02();
            this.txt_legajo_empleado = new CLASE05.Clases.LabelText02();
            this.txt_direccion = new CLASE05.Clases.LabelText02();
            this.txt_ciudad = new CLASE05.Clases.LabelText02();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_estado_provincia = new System.Windows.Forms.Label();
            this.cmb_estado_provincia = new CLASE05.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cuit_cliente = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_limite_credito = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
           
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Location = new System.Drawing.Point(31, 44);
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
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
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
            this.cmb_pais._Validable = false;
            this.cmb_pais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_pais.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_pais.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(144, 331);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(190, 25);
            this.cmb_pais.TabIndex = 23;
            this.cmb_pais.SelectedIndexChanged += new System.EventHandler(this.cmb_pais_SelectedIndexChanged);
            // 
            // txt_razon_social
            // 
            this.txt_razon_social._Ancho = 50;
            this.txt_razon_social._Decimales = 2;
            this.txt_razon_social._Etiqueta = "Razón social";
            this.txt_razon_social._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_razon_social._MensajeError = null;
            this.txt_razon_social._Nombre_campo = null;
            this.txt_razon_social._Nombre_tabla = null;
            this.txt_razon_social._ReadOnly = false;
            this.txt_razon_social._Text = "";
            this.txt_razon_social._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_razon_social._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_razon_social._Validable = false;
            this.txt_razon_social.BackColor = System.Drawing.Color.Transparent;
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_razon_social.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_razon_social.Location = new System.Drawing.Point(-8, 132);
            this.txt_razon_social.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(473, 30);
            this.txt_razon_social.TabIndex = 25;
            // 
            // txt_nombre_contacto
            // 
            this.txt_nombre_contacto._Ancho = 50;
            this.txt_nombre_contacto._Decimales = 2;
            this.txt_nombre_contacto._Etiqueta = "Nombre contacto";
            this.txt_nombre_contacto._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nombre_contacto._MensajeError = null;
            this.txt_nombre_contacto._Nombre_campo = null;
            this.txt_nombre_contacto._Nombre_tabla = null;
            this.txt_nombre_contacto._ReadOnly = false;
            this.txt_nombre_contacto._Text = "";
            this.txt_nombre_contacto._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombre_contacto._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_nombre_contacto._Validable = false;
            this.txt_nombre_contacto.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre_contacto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_nombre_contacto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombre_contacto.Location = new System.Drawing.Point(-7, 207);
            this.txt_nombre_contacto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_contacto.Name = "txt_nombre_contacto";
            this.txt_nombre_contacto.Size = new System.Drawing.Size(473, 30);
            this.txt_nombre_contacto.TabIndex = 27;
            // 
            // txt_legajo_empleado
            // 
            this.txt_legajo_empleado._Ancho = 10;
            this.txt_legajo_empleado._Decimales = 2;
            this.txt_legajo_empleado._Etiqueta = "Legajo empleado";
            this.txt_legajo_empleado._Mask = "99999999";
            this.txt_legajo_empleado._MensajeError = null;
            this.txt_legajo_empleado._Nombre_campo = null;
            this.txt_legajo_empleado._Nombre_tabla = null;
            this.txt_legajo_empleado._ReadOnly = false;
            this.txt_legajo_empleado._Text = "";
            this.txt_legajo_empleado._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_legajo_empleado._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_legajo_empleado._Validable = false;
            this.txt_legajo_empleado.BackColor = System.Drawing.Color.Transparent;
            this.txt_legajo_empleado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_legajo_empleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_legajo_empleado.Location = new System.Drawing.Point(-7, 247);
            this.txt_legajo_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_legajo_empleado.Name = "txt_legajo_empleado";
            this.txt_legajo_empleado.Size = new System.Drawing.Size(341, 30);
            this.txt_legajo_empleado.TabIndex = 28;
            // 
            // txt_direccion
            // 
            this.txt_direccion._Ancho = 50;
            this.txt_direccion._Decimales = 2;
            this.txt_direccion._Etiqueta = "Dirección";
            this.txt_direccion._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_direccion._MensajeError = null;
            this.txt_direccion._Nombre_campo = null;
            this.txt_direccion._Nombre_tabla = null;
            this.txt_direccion._ReadOnly = false;
            this.txt_direccion._Text = "";
            this.txt_direccion._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_direccion._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_direccion._Validable = false;
            this.txt_direccion.BackColor = System.Drawing.Color.Transparent;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_direccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_direccion.Location = new System.Drawing.Point(-7, 288);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(473, 30);
            this.txt_direccion.TabIndex = 29;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad._Ancho = 10;
            this.txt_ciudad._Decimales = 2;
            this.txt_ciudad._Etiqueta = "Ciudad";
            this.txt_ciudad._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_ciudad._MensajeError = null;
            this.txt_ciudad._Nombre_campo = null;
            this.txt_ciudad._Nombre_tabla = null;
            this.txt_ciudad._ReadOnly = false;
            this.txt_ciudad._Text = "";
            this.txt_ciudad._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_ciudad._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_ciudad._Validable = false;
            this.txt_ciudad.BackColor = System.Drawing.Color.Transparent;
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ciudad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_ciudad.Location = new System.Drawing.Point(-7, 407);
            this.txt_ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(472, 30);
            this.txt_ciudad.TabIndex = 30;
            // 
            // lbl_pais
            // 
            this.lbl_pais.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_pais.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_pais.Location = new System.Drawing.Point(-9, 329);
            this.lbl_pais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(144, 20);
            this.lbl_pais.TabIndex = 31;
            this.lbl_pais.Text = "País";
            this.lbl_pais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_estado_provincia
            // 
            this.lbl_estado_provincia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado_provincia.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_estado_provincia.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_estado_provincia.Location = new System.Drawing.Point(-9, 370);
            this.lbl_estado_provincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado_provincia.Name = "lbl_estado_provincia";
            this.lbl_estado_provincia.Size = new System.Drawing.Size(144, 20);
            this.lbl_estado_provincia.TabIndex = 33;
            this.lbl_estado_provincia.Text = "Estado/Provincia";
            this.lbl_estado_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmb_estado_provincia._Validable = false;
            this.cmb_estado_provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_estado_provincia.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_estado_provincia.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_estado_provincia.FormattingEnabled = true;
            this.cmb_estado_provincia.Location = new System.Drawing.Point(144, 371);
            this.cmb_estado_provincia.Name = "cmb_estado_provincia";
            this.cmb_estado_provincia.Size = new System.Drawing.Size(190, 25);
            this.cmb_estado_provincia.TabIndex = 32;
            this.cmb_estado_provincia.Tag = "";
            this.cmb_estado_provincia.Text = "Seleccionar país...";
            this.cmb_estado_provincia.Click += new System.EventHandler(this.cmb_estado_provincia_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(-9, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cuit Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_cuit_cliente.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_cuit_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_cuit_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuit_cliente.Location = new System.Drawing.Point(142, 95);
            this.txt_cuit_cliente.Mask = "99-99999999-9";
            this.txt_cuit_cliente.Name = "txt_cuit_cliente";
            this.txt_cuit_cliente.Size = new System.Drawing.Size(192, 25);
            this.txt_cuit_cliente.TabIndex = 35;
            this.txt_cuit_cliente.Click += new System.EventHandler(this.txt_cuit_cliente_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(-9, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Límite crédito ($)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_limite_credito
            // 
            this.txt_limite_credito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_limite_credito.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_limite_credito.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_limite_credito.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_limite_credito.Location = new System.Drawing.Point(144, 175);
            this.txt_limite_credito.Mask = "9999999999";
            this.txt_limite_credito.Name = "txt_limite_credito";
            this.txt_limite_credito.Size = new System.Drawing.Size(190, 25);
            this.txt_limite_credito.TabIndex = 38;
            // 
            // Frm_e
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(516, 516);
            this.Controls.Add(this.txt_limite_credito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cuit_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_pais);
            this.Controls.Add(this.lbl_estado_provincia);
            this.Controls.Add(this.cmb_estado_provincia);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.txt_legajo_empleado);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.txt_razon_social);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre_contacto);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_e";
            this.Load += new System.EventHandler(this.Frm_Cliente_Load);
            
            this.Controls.SetChildIndex(this.txt_nombre_contacto, 0);
            this.Controls.SetChildIndex(this.txt_direccion, 0);
            this.Controls.SetChildIndex(this.txt_razon_social, 0);
            this.Controls.SetChildIndex(this.txt_ciudad, 0);
            this.Controls.SetChildIndex(this.txt_legajo_empleado, 0);
            this.Controls.SetChildIndex(this.lbl_pais, 0);
            this.Controls.SetChildIndex(this.cmb_estado_provincia, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.lbl_estado_provincia, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.cmb_pais, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.txt_cuit_cliente, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_limite_credito, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_estado_provincia;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label label1;
        public Clases.ComboBox01 cmb_pais;
        public Clases.LabelText02 txt_ciudad;
        public Clases.LabelText02 txt_direccion;
        public Clases.LabelText02 txt_legajo_empleado;
        public Clases.LabelText02 txt_nombre_contacto;
        public Clases.LabelText02 txt_razon_social;
        public Clases.ComboBox01 cmb_estado_provincia;
        public System.Windows.Forms.MaskedTextBox txt_cuit_cliente;
        public System.Windows.Forms.MaskedTextBox txt_limite_credito;
        private System.Windows.Forms.Label label2;
    }
}