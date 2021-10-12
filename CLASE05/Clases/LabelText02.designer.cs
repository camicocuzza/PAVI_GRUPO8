namespace CLASE05.Clases
{
    partial class LabelText02
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.TxtDato = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblEtiqueta.Location = new System.Drawing.Point(0, 4);
            this.lblEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(144, 20);
            this.lblEtiqueta.TabIndex = 0;
            this.lblEtiqueta.Text = "label1";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDato
            // 
            this.TxtDato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TxtDato.Culture = new System.Globalization.CultureInfo("en-US");
            this.TxtDato.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.TxtDato.ForeColor = System.Drawing.Color.White;
            this.TxtDato.Location = new System.Drawing.Point(151, 3);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(73, 25);
            this.TxtDato.TabIndex = 0;
            this.TxtDato.Click += new System.EventHandler(this.TxtDato_Click);
            this.TxtDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDato_KeyPress);
            // 
            // LabelText02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TxtDato);
            this.Controls.Add(this.lblEtiqueta);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LabelText02";
            this.Size = new System.Drawing.Size(228, 30);
            this.EnabledChanged += new System.EventHandler(this.LabelText02_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.MaskedTextBox TxtDato;
    }
}
