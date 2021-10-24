
namespace CLASE05.Formularios.Reportes
{
    partial class Frm_BaseReportes
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rpt_ventas = new System.Windows.Forms.Button();
            this.btn_rpt_compras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // gb_login
            // 
            this.gb_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gb_login.Controls.Add(this.label1);
            this.gb_login.Controls.Add(this.btn_rpt_compras);
            this.gb_login.Controls.Add(this.lbl_titulo);
            this.gb_login.Controls.Add(this.label5);
            this.gb_login.Controls.Add(this.btn_rpt_ventas);
            this.gb_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_login.Location = new System.Drawing.Point(12, 36);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(555, 269);
            this.gb_login.TabIndex = 16;
            this.gb_login.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_titulo.Location = new System.Drawing.Point(225, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(85, 22);
            this.lbl_titulo.TabIndex = 13;
            this.lbl_titulo.Text = "Reportes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(110, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "______________________________________________";
            // 
            // btn_rpt_ventas
            // 
            this.btn_rpt_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_rpt_ventas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_rpt_ventas.FlatAppearance.BorderSize = 0;
            this.btn_rpt_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rpt_ventas.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_rpt_ventas.ForeColor = System.Drawing.Color.White;
            this.btn_rpt_ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_rpt_ventas.Location = new System.Drawing.Point(150, 179);
            this.btn_rpt_ventas.Name = "btn_rpt_ventas";
            this.btn_rpt_ventas.Size = new System.Drawing.Size(236, 37);
            this.btn_rpt_ventas.TabIndex = 2;
            this.btn_rpt_ventas.Text = "Reporte Ventas";
            this.btn_rpt_ventas.UseVisualStyleBackColor = false;
            this.btn_rpt_ventas.Click += new System.EventHandler(this.btn_rpt_ventas_Click);
            // 
            // btn_rpt_compras
            // 
            this.btn_rpt_compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_rpt_compras.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_rpt_compras.FlatAppearance.BorderSize = 0;
            this.btn_rpt_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rpt_compras.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_rpt_compras.ForeColor = System.Drawing.Color.White;
            this.btn_rpt_compras.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_rpt_compras.Location = new System.Drawing.Point(150, 118);
            this.btn_rpt_compras.Name = "btn_rpt_compras";
            this.btn_rpt_compras.Size = new System.Drawing.Size(236, 37);
            this.btn_rpt_compras.TabIndex = 1;
            this.btn_rpt_compras.Text = "Reporte Compras";
            this.btn_rpt_compras.UseVisualStyleBackColor = false;
            this.btn_rpt_compras.Click += new System.EventHandler(this.btn_rpt_compras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Seleccione tipo de reporte:";
            // 
            // Frm_BaseReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(573, 317);
            this.Controls.Add(this.gb_login);
            this.Name = "Frm_BaseReportes";
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.gb_login, 0);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rpt_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rpt_compras;
    }
}
