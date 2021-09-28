
namespace CLASE05.Formularios.Lotes
{
    partial class Frm_Lote
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_n_lote = new CLASE05.Clases.LabelText02();
            this.txt_n_remito = new CLASE05.Clases.LabelText02();
            this.txt_fecha_compra = new CLASE05.Clases.LabelText02();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(401, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(331, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(366, 2);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptar.Location = new System.Drawing.Point(165, 269);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(104, 30);
            this.btn_aceptar.TabIndex = 54;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // txt_n_lote
            // 
            this.txt_n_lote._Ancho = 6;
            this.txt_n_lote._Decimales = 0;
            this.txt_n_lote._Etiqueta = "Número de lote";
            this.txt_n_lote._Mask = "999999";
            this.txt_n_lote._MensajeError = "El número de lote esta vacío";
            this.txt_n_lote._Nombre_campo = null;
            this.txt_n_lote._Nombre_tabla = null;
            this.txt_n_lote._ReadOnly = false;
            this.txt_n_lote._StartEnCero = false;
            this.txt_n_lote._Text = "";
            this.txt_n_lote._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_lote._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_n_lote._Validable = true;
            this.txt_n_lote.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_lote.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_n_lote.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_lote.Location = new System.Drawing.Point(10, 120);
            this.txt_n_lote.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_lote.Name = "txt_n_lote";
            this.txt_n_lote.Size = new System.Drawing.Size(271, 30);
            this.txt_n_lote.TabIndex = 55;
            // 
            // txt_n_remito
            // 
            this.txt_n_remito._Ancho = 8;
            this.txt_n_remito._Decimales = 0;
            this.txt_n_remito._Etiqueta = "Número remito";
            this.txt_n_remito._Mask = "99999999";
            this.txt_n_remito._MensajeError = "El número de remito esta vacío";
            this.txt_n_remito._Nombre_campo = null;
            this.txt_n_remito._Nombre_tabla = null;
            this.txt_n_remito._ReadOnly = false;
            this.txt_n_remito._StartEnCero = false;
            this.txt_n_remito._Text = "";
            this.txt_n_remito._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_remito._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_n_remito._Validable = true;
            this.txt_n_remito.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_remito.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_n_remito.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_remito.Location = new System.Drawing.Point(10, 158);
            this.txt_n_remito.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_remito.Name = "txt_n_remito";
            this.txt_n_remito.Size = new System.Drawing.Size(271, 30);
            this.txt_n_remito.TabIndex = 56;
            // 
            // txt_fecha_compra
            // 
            this.txt_fecha_compra._Ancho = 10;
            this.txt_fecha_compra._Decimales = 2;
            this.txt_fecha_compra._Etiqueta = "Fecha de compra";
            this.txt_fecha_compra._Mask = "00/00/0000";
            this.txt_fecha_compra._MensajeError = "La fecha de compra esta vacía";
            this.txt_fecha_compra._Nombre_campo = null;
            this.txt_fecha_compra._Nombre_tabla = null;
            this.txt_fecha_compra._ReadOnly = false;
            this.txt_fecha_compra._StartEnCero = true;
            this.txt_fecha_compra._Text = "  /  /";
            this.txt_fecha_compra._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_compra._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_fecha_compra._Validable = true;
            this.txt_fecha_compra.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha_compra.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_fecha_compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha_compra.Location = new System.Drawing.Point(10, 196);
            this.txt_fecha_compra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_compra.Name = "txt_fecha_compra";
            this.txt_fecha_compra.Size = new System.Drawing.Size(219, 30);
            this.txt_fecha_compra.TabIndex = 57;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_titulo.Location = new System.Drawing.Point(35, 61);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 58;
            this.lbl_titulo.Text = "Titulo";
            // 
            // Frm_Lote
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(438, 341);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_fecha_compra);
            this.Controls.Add(this.txt_n_remito);
            this.Controls.Add(this.txt_n_lote);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "Frm_Lote";
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.txt_n_lote, 0);
            this.Controls.SetChildIndex(this.txt_n_remito, 0);
            this.Controls.SetChildIndex(this.txt_fecha_compra, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_titulo;
        protected Clases.LabelText02 txt_n_lote;
        protected Clases.LabelText02 txt_n_remito;
        protected Clases.LabelText02 txt_fecha_compra;
    }
}
