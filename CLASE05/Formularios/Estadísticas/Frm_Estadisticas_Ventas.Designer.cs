
namespace CLASE05.Formularios.Estadísticas
{
    partial class Frm_Estadisticas_Ventas
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
            this.tab_ventas = new System.Windows.Forms.TabControl();
            this.pag_ventasFecha = new System.Windows.Forms.TabPage();
            this.txt_fechaHasta_articulos = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaDesde_articulos = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cargarVentasArticulos = new System.Windows.Forms.Button();
            this.rv_ventasArticulos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab_ventasCliente = new System.Windows.Forms.TabPage();
            this.txt_fechaHasta_clientes = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaDesde_clientes = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cargarVentasClientes = new System.Windows.Forms.Button();
            this.rv_ventasClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab_ventas.SuspendLayout();
            this.pag_ventasFecha.SuspendLayout();
            this.tab_ventasCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(638, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(568, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(603, 2);
            // 
            // tab_ventas
            // 
            this.tab_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_ventas.Controls.Add(this.pag_ventasFecha);
            this.tab_ventas.Controls.Add(this.tab_ventasCliente);
            this.tab_ventas.Location = new System.Drawing.Point(2, 12);
            this.tab_ventas.Name = "tab_ventas";
            this.tab_ventas.SelectedIndex = 0;
            this.tab_ventas.Size = new System.Drawing.Size(671, 713);
            this.tab_ventas.TabIndex = 3;
            this.tab_ventas.Tag = "";
            // 
            // pag_ventasFecha
            // 
            this.pag_ventasFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pag_ventasFecha.Controls.Add(this.txt_fechaHasta_articulos);
            this.pag_ventasFecha.Controls.Add(this.txt_fechaDesde_articulos);
            this.pag_ventasFecha.Controls.Add(this.label3);
            this.pag_ventasFecha.Controls.Add(this.label5);
            this.pag_ventasFecha.Controls.Add(this.label4);
            this.pag_ventasFecha.Controls.Add(this.btn_cargarVentasArticulos);
            this.pag_ventasFecha.Controls.Add(this.rv_ventasArticulos);
            this.pag_ventasFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pag_ventasFecha.Location = new System.Drawing.Point(4, 22);
            this.pag_ventasFecha.Name = "pag_ventasFecha";
            this.pag_ventasFecha.Padding = new System.Windows.Forms.Padding(3);
            this.pag_ventasFecha.Size = new System.Drawing.Size(663, 687);
            this.pag_ventasFecha.TabIndex = 0;
            this.pag_ventasFecha.Text = "Ventas artículos";
            // 
            // txt_fechaHasta_articulos
            // 
            this.txt_fechaHasta_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaHasta_articulos.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaHasta_articulos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaHasta_articulos.ForeColor = System.Drawing.Color.White;
            this.txt_fechaHasta_articulos.Location = new System.Drawing.Point(388, 62);
            this.txt_fechaHasta_articulos.Mask = "00/00/0000";
            this.txt_fechaHasta_articulos.Name = "txt_fechaHasta_articulos";
            this.txt_fechaHasta_articulos.Size = new System.Drawing.Size(108, 25);
            this.txt_fechaHasta_articulos.TabIndex = 51;
            // 
            // txt_fechaDesde_articulos
            // 
            this.txt_fechaDesde_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaDesde_articulos.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaDesde_articulos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaDesde_articulos.ForeColor = System.Drawing.Color.White;
            this.txt_fechaDesde_articulos.Location = new System.Drawing.Point(143, 62);
            this.txt_fechaDesde_articulos.Mask = "00/00/0000";
            this.txt_fechaDesde_articulos.Name = "txt_fechaDesde_articulos";
            this.txt_fechaDesde_articulos.Size = new System.Drawing.Size(108, 25);
            this.txt_fechaDesde_articulos.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estadísticas ventas por artículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(276, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Desde";
            // 
            // btn_cargarVentasArticulos
            // 
            this.btn_cargarVentasArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_cargarVentasArticulos.FlatAppearance.BorderSize = 0;
            this.btn_cargarVentasArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarVentasArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cargarVentasArticulos.ForeColor = System.Drawing.Color.White;
            this.btn_cargarVentasArticulos.Location = new System.Drawing.Point(526, 83);
            this.btn_cargarVentasArticulos.Name = "btn_cargarVentasArticulos";
            this.btn_cargarVentasArticulos.Size = new System.Drawing.Size(131, 30);
            this.btn_cargarVentasArticulos.TabIndex = 8;
            this.btn_cargarVentasArticulos.Text = "Generar Informe";
            this.btn_cargarVentasArticulos.UseVisualStyleBackColor = false;
            this.btn_cargarVentasArticulos.Click += new System.EventHandler(this.btn_cargarVentasArticulos_Click);
            // 
            // rv_ventasArticulos
            // 
            this.rv_ventasArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_ventasArticulos.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rv_ventasArticulos.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Estadisticas.Ventas.Ventas_Articulos_Periodo.rdlc";
            this.rv_ventasArticulos.Location = new System.Drawing.Point(6, 119);
            this.rv_ventasArticulos.Name = "rv_ventasArticulos";
            this.rv_ventasArticulos.ServerReport.BearerToken = null;
            this.rv_ventasArticulos.ShowBackButton = false;
            this.rv_ventasArticulos.ShowParameterPrompts = false;
            this.rv_ventasArticulos.ShowPromptAreaButton = false;
            this.rv_ventasArticulos.ShowRefreshButton = false;
            this.rv_ventasArticulos.ShowStopButton = false;
            this.rv_ventasArticulos.Size = new System.Drawing.Size(651, 562);
            this.rv_ventasArticulos.TabIndex = 3;
            // 
            // tab_ventasCliente
            // 
            this.tab_ventasCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tab_ventasCliente.Controls.Add(this.txt_fechaHasta_clientes);
            this.tab_ventasCliente.Controls.Add(this.txt_fechaDesde_clientes);
            this.tab_ventasCliente.Controls.Add(this.label2);
            this.tab_ventasCliente.Controls.Add(this.label6);
            this.tab_ventasCliente.Controls.Add(this.label1);
            this.tab_ventasCliente.Controls.Add(this.btn_cargarVentasClientes);
            this.tab_ventasCliente.Controls.Add(this.rv_ventasClientes);
            this.tab_ventasCliente.Location = new System.Drawing.Point(4, 22);
            this.tab_ventasCliente.Name = "tab_ventasCliente";
            this.tab_ventasCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ventasCliente.Size = new System.Drawing.Size(663, 687);
            this.tab_ventasCliente.TabIndex = 1;
            this.tab_ventasCliente.Text = "Ventas por clientes";
            // 
            // txt_fechaHasta_clientes
            // 
            this.txt_fechaHasta_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaHasta_clientes.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaHasta_clientes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaHasta_clientes.ForeColor = System.Drawing.Color.White;
            this.txt_fechaHasta_clientes.Location = new System.Drawing.Point(388, 62);
            this.txt_fechaHasta_clientes.Mask = "00/00/0000";
            this.txt_fechaHasta_clientes.Name = "txt_fechaHasta_clientes";
            this.txt_fechaHasta_clientes.Size = new System.Drawing.Size(108, 25);
            this.txt_fechaHasta_clientes.TabIndex = 55;
            // 
            // txt_fechaDesde_clientes
            // 
            this.txt_fechaDesde_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_fechaDesde_clientes.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_fechaDesde_clientes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fechaDesde_clientes.ForeColor = System.Drawing.Color.White;
            this.txt_fechaDesde_clientes.Location = new System.Drawing.Point(143, 62);
            this.txt_fechaDesde_clientes.Mask = "00/00/0000";
            this.txt_fechaDesde_clientes.Name = "txt_fechaDesde_clientes";
            this.txt_fechaDesde_clientes.Size = new System.Drawing.Size(108, 25);
            this.txt_fechaDesde_clientes.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fecha Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Fecha Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Estadísticas ventas por cliente";
            // 
            // btn_cargarVentasClientes
            // 
            this.btn_cargarVentasClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_cargarVentasClientes.FlatAppearance.BorderSize = 0;
            this.btn_cargarVentasClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarVentasClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cargarVentasClientes.ForeColor = System.Drawing.Color.White;
            this.btn_cargarVentasClientes.Location = new System.Drawing.Point(526, 83);
            this.btn_cargarVentasClientes.Name = "btn_cargarVentasClientes";
            this.btn_cargarVentasClientes.Size = new System.Drawing.Size(131, 30);
            this.btn_cargarVentasClientes.TabIndex = 11;
            this.btn_cargarVentasClientes.Text = "Generar Informe";
            this.btn_cargarVentasClientes.UseVisualStyleBackColor = false;
            this.btn_cargarVentasClientes.Click += new System.EventHandler(this.btn_cargarVentasClientes_Click);
            // 
            // rv_ventasClientes
            // 
            this.rv_ventasClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_ventasClientes.LocalReport.ReportEmbeddedResource = "CLASE05.Informes.Estadisticas.Ventas.Ventas_Clientes_Periodo.rdlc";
            this.rv_ventasClientes.Location = new System.Drawing.Point(6, 119);
            this.rv_ventasClientes.Name = "rv_ventasClientes";
            this.rv_ventasClientes.ServerReport.BearerToken = null;
            this.rv_ventasClientes.ShowBackButton = false;
            this.rv_ventasClientes.ShowParameterPrompts = false;
            this.rv_ventasClientes.ShowPromptAreaButton = false;
            this.rv_ventasClientes.ShowRefreshButton = false;
            this.rv_ventasClientes.ShowStopButton = false;
            this.rv_ventasClientes.Size = new System.Drawing.Size(651, 562);
            this.rv_ventasClientes.TabIndex = 10;
            // 
            // Frm_Estadisticas_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(675, 729);
            this.ControlBox = false;
            this.Controls.Add(this.tab_ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "Frm_Estadisticas_Ventas";
            this.Load += new System.EventHandler(this.Frm_Estadisticas_Ventas_Load);
            this.Controls.SetChildIndex(this.tab_ventas, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.tab_ventas.ResumeLayout(false);
            this.pag_ventasFecha.ResumeLayout(false);
            this.pag_ventasFecha.PerformLayout();
            this.tab_ventasCliente.ResumeLayout(false);
            this.tab_ventasCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ventas;
        private System.Windows.Forms.TabPage pag_ventasFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cargarVentasArticulos;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ventasArticulos;
        private System.Windows.Forms.TabPage tab_ventasCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cargarVentasClientes;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ventasClientes;
        public System.Windows.Forms.MaskedTextBox txt_fechaDesde_articulos;
        public System.Windows.Forms.MaskedTextBox txt_fechaHasta_articulos;
        public System.Windows.Forms.MaskedTextBox txt_fechaHasta_clientes;
        public System.Windows.Forms.MaskedTextBox txt_fechaDesde_clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}
