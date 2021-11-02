
namespace CLASE05.Formularios.Estadísticas
{
    partial class Frm_Estadisticas_Compras
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
            this.tab_comprasArticulos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rv_comprasArticulos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_fechaHasta_articulos = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaDesde_articulos = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cargarComprasArticulos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_comprasProveedores = new System.Windows.Forms.TabPage();
            this.rv_comprasProveedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_fechaHasta_proveedor = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaDesde_proveedor = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cargarComprasProveedores = new System.Windows.Forms.Button();
            this.tab_comprasMes = new System.Windows.Forms.TabPage();
            this.rv_comprasMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_año = new CLASE05.Clases.LabelText02();
            this.tab_comprasArticulos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab_comprasProveedores.SuspendLayout();
            this.tab_comprasMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(654, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(584, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(619, 2);
            // 
            // tab_comprasArticulos
            // 
            this.tab_comprasArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_comprasArticulos.Controls.Add(this.tabPage1);
            this.tab_comprasArticulos.Controls.Add(this.tab_comprasProveedores);
            this.tab_comprasArticulos.Controls.Add(this.tab_comprasMes);
            this.tab_comprasArticulos.Location = new System.Drawing.Point(12, 12);
            this.tab_comprasArticulos.Name = "tab_comprasArticulos";
            this.tab_comprasArticulos.SelectedIndex = 0;
            this.tab_comprasArticulos.Size = new System.Drawing.Size(667, 721);
            this.tab_comprasArticulos.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.rv_comprasArticulos);
            this.tabPage1.Controls.Add(this.txt_fechaHasta_articulos);
            this.tabPage1.Controls.Add(this.txt_fechaDesde_articulos);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_cargarComprasArticulos);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compras por Artículos";
            // 
            // rv_comprasArticulos
            // 
            this.rv_comprasArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_comprasArticulos.Location = new System.Drawing.Point(6, 129);
            this.rv_comprasArticulos.Name = "rv_comprasArticulos";
            this.rv_comprasArticulos.ServerReport.BearerToken = null;
            this.rv_comprasArticulos.Size = new System.Drawing.Size(646, 560);
            this.rv_comprasArticulos.TabIndex = 57;
            // 
            // txt_fechaHasta_articulos
            // 
            this.txt_fechaHasta_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaHasta_articulos.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaHasta_articulos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaHasta_articulos.ForeColor = System.Drawing.Color.White;
            this.txt_fechaHasta_articulos.Location = new System.Drawing.Point(383, 67);
            this.txt_fechaHasta_articulos.Mask = "00/00/0000";
            this.txt_fechaHasta_articulos.Name = "txt_fechaHasta_articulos";
            this.txt_fechaHasta_articulos.Size = new System.Drawing.Size(108, 25);
            this.txt_fechaHasta_articulos.TabIndex = 56;
            // 
            // txt_fechaDesde_articulos
            // 
            this.txt_fechaDesde_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaDesde_articulos.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaDesde_articulos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaDesde_articulos.ForeColor = System.Drawing.Color.White;
            this.txt_fechaDesde_articulos.Location = new System.Drawing.Point(138, 67);
            this.txt_fechaDesde_articulos.Mask = "00/00/0000";
            this.txt_fechaDesde_articulos.Name = "txt_fechaDesde_articulos";
            this.txt_fechaDesde_articulos.Size = new System.Drawing.Size(108, 25);
            this.txt_fechaDesde_articulos.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(271, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fecha Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Fecha Desde";
            // 
            // btn_cargarComprasArticulos
            // 
            this.btn_cargarComprasArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_cargarComprasArticulos.FlatAppearance.BorderSize = 0;
            this.btn_cargarComprasArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarComprasArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cargarComprasArticulos.ForeColor = System.Drawing.Color.White;
            this.btn_cargarComprasArticulos.Location = new System.Drawing.Point(521, 86);
            this.btn_cargarComprasArticulos.Name = "btn_cargarComprasArticulos";
            this.btn_cargarComprasArticulos.Size = new System.Drawing.Size(131, 30);
            this.btn_cargarComprasArticulos.TabIndex = 52;
            this.btn_cargarComprasArticulos.Text = "Generar Informe";
            this.btn_cargarComprasArticulos.UseVisualStyleBackColor = false;
            this.btn_cargarComprasArticulos.Click += new System.EventHandler(this.btn_cargarComprasArticulos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estadísticas compras por artículo";
            // 
            // tab_comprasProveedores
            // 
            this.tab_comprasProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tab_comprasProveedores.Controls.Add(this.rv_comprasProveedor);
            this.tab_comprasProveedores.Controls.Add(this.txt_fechaHasta_proveedor);
            this.tab_comprasProveedores.Controls.Add(this.txt_fechaDesde_proveedor);
            this.tab_comprasProveedores.Controls.Add(this.label2);
            this.tab_comprasProveedores.Controls.Add(this.label6);
            this.tab_comprasProveedores.Controls.Add(this.label1);
            this.tab_comprasProveedores.Controls.Add(this.btn_cargarComprasProveedores);
            this.tab_comprasProveedores.Location = new System.Drawing.Point(4, 22);
            this.tab_comprasProveedores.Name = "tab_comprasProveedores";
            this.tab_comprasProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tab_comprasProveedores.Size = new System.Drawing.Size(659, 695);
            this.tab_comprasProveedores.TabIndex = 1;
            this.tab_comprasProveedores.Text = "Compras por Proveedores";
            // 
            // rv_comprasProveedor
            // 
            this.rv_comprasProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_comprasProveedor.Location = new System.Drawing.Point(6, 129);
            this.rv_comprasProveedor.Name = "rv_comprasProveedor";
            this.rv_comprasProveedor.ServerReport.BearerToken = null;
            this.rv_comprasProveedor.Size = new System.Drawing.Size(646, 559);
            this.rv_comprasProveedor.TabIndex = 62;
            // 
            // txt_fechaHasta_proveedor
            // 
            this.txt_fechaHasta_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaHasta_proveedor.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaHasta_proveedor.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaHasta_proveedor.ForeColor = System.Drawing.Color.White;
            this.txt_fechaHasta_proveedor.Location = new System.Drawing.Point(383, 67);
            this.txt_fechaHasta_proveedor.Mask = "00/00/0000";
            this.txt_fechaHasta_proveedor.Name = "txt_fechaHasta_proveedor";
            this.txt_fechaHasta_proveedor.Size = new System.Drawing.Size(108, 25);
            this.txt_fechaHasta_proveedor.TabIndex = 61;
            // 
            // txt_fechaDesde_proveedor
            // 
            this.txt_fechaDesde_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaDesde_proveedor.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaDesde_proveedor.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaDesde_proveedor.ForeColor = System.Drawing.Color.White;
            this.txt_fechaDesde_proveedor.Location = new System.Drawing.Point(138, 67);
            this.txt_fechaDesde_proveedor.Mask = "00/00/0000";
            this.txt_fechaDesde_proveedor.Name = "txt_fechaDesde_proveedor";
            this.txt_fechaDesde_proveedor.Size = new System.Drawing.Size(108, 25);
            this.txt_fechaDesde_proveedor.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Fecha Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "Fecha Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "Estadísticas ventas por proveedor";
            // 
            // btn_cargarComprasProveedores
            // 
            this.btn_cargarComprasProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_cargarComprasProveedores.FlatAppearance.BorderSize = 0;
            this.btn_cargarComprasProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarComprasProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cargarComprasProveedores.ForeColor = System.Drawing.Color.White;
            this.btn_cargarComprasProveedores.Location = new System.Drawing.Point(521, 86);
            this.btn_cargarComprasProveedores.Name = "btn_cargarComprasProveedores";
            this.btn_cargarComprasProveedores.Size = new System.Drawing.Size(131, 30);
            this.btn_cargarComprasProveedores.TabIndex = 56;
            this.btn_cargarComprasProveedores.Text = "Generar Informe";
            this.btn_cargarComprasProveedores.UseVisualStyleBackColor = false;
            this.btn_cargarComprasProveedores.Click += new System.EventHandler(this.btn_cargarComprasProveedores_Click);
            // 
            // tab_comprasMes
            // 
            this.tab_comprasMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tab_comprasMes.Controls.Add(this.txt_año);
            this.tab_comprasMes.Controls.Add(this.rv_comprasMes);
            this.tab_comprasMes.Controls.Add(this.label9);
            this.tab_comprasMes.Controls.Add(this.button1);
            this.tab_comprasMes.Location = new System.Drawing.Point(4, 22);
            this.tab_comprasMes.Name = "tab_comprasMes";
            this.tab_comprasMes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_comprasMes.Size = new System.Drawing.Size(659, 695);
            this.tab_comprasMes.TabIndex = 2;
            this.tab_comprasMes.Text = "Compras por mes";
            // 
            // rv_comprasMes
            // 
            this.rv_comprasMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_comprasMes.Location = new System.Drawing.Point(6, 129);
            this.rv_comprasMes.Name = "rv_comprasMes";
            this.rv_comprasMes.ServerReport.BearerToken = null;
            this.rv_comprasMes.Size = new System.Drawing.Size(646, 559);
            this.rv_comprasMes.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(327, 31);
            this.label9.TabIndex = 63;
            this.label9.Text = "Estadísticas ventas por mes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(521, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 30);
            this.button1.TabIndex = 62;
            this.button1.Text = "Generar Informe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_año
            // 
            this.txt_año._Ancho = 4;
            this.txt_año._Decimales = 0;
            this.txt_año._Etiqueta = "Año";
            this.txt_año._Mask = "9999";
            this.txt_año._MensajeError = null;
            this.txt_año._Nombre_campo = null;
            this.txt_año._Nombre_tabla = null;
            this.txt_año._ReadOnly = false;
            this.txt_año._StartEnCero = true;
            this.txt_año._Text = "";
            this.txt_año._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_año._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_año._Validable = true;
            this.txt_año.BackColor = System.Drawing.Color.Transparent;
            this.txt_año.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_año.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_año.Location = new System.Drawing.Point(5, 66);
            this.txt_año.Margin = new System.Windows.Forms.Padding(4);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(228, 30);
            this.txt_año.TabIndex = 69;
            // 
            // Frm_Estadisticas_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 745);
            this.Controls.Add(this.tab_comprasArticulos);
            this.Name = "Frm_Estadisticas_Compras";
            this.Load += new System.EventHandler(this.Frm_Estadisticas_Compras_Load);
            this.Controls.SetChildIndex(this.tab_comprasArticulos, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.tab_comprasArticulos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab_comprasProveedores.ResumeLayout(false);
            this.tab_comprasProveedores.PerformLayout();
            this.tab_comprasMes.ResumeLayout(false);
            this.tab_comprasMes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_comprasArticulos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_comprasProveedores;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox txt_fechaHasta_articulos;
        public System.Windows.Forms.MaskedTextBox txt_fechaDesde_articulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cargarComprasArticulos;
        public System.Windows.Forms.MaskedTextBox txt_fechaHasta_proveedor;
        public System.Windows.Forms.MaskedTextBox txt_fechaDesde_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cargarComprasProveedores;
        private Microsoft.Reporting.WinForms.ReportViewer rv_comprasArticulos;
        private Microsoft.Reporting.WinForms.ReportViewer rv_comprasProveedor;
        private System.Windows.Forms.TabPage tab_comprasMes;
        private Microsoft.Reporting.WinForms.ReportViewer rv_comprasMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private Clases.LabelText02 txt_año;
    }
}
