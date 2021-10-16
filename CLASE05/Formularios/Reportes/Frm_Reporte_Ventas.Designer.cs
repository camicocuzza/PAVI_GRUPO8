
namespace CLASE05.Formularios.Reportes
{
    partial class Frm_Reporte_Ventas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cargarVentasFecha = new System.Windows.Forms.Button();
            this.cmb_año = new CLASE05.Clases.ComboBox01();
            this.cmb_mes = new CLASE05.Clases.ComboBox01();
            this.rv_ventasFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab_ventasCliente = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cargarVentasCliente = new System.Windows.Forms.Button();
            this.rv_ventasCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_clientes = new CLASE05.Clases.ComboBox01();
            this.tab_ventas.SuspendLayout();
            this.pag_ventasFecha.SuspendLayout();
            this.tab_ventasCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(722, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(652, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(687, 2);
            // 
            // tab_ventas
            // 
            this.tab_ventas.Controls.Add(this.pag_ventasFecha);
            this.tab_ventas.Controls.Add(this.tab_ventasCliente);
            this.tab_ventas.Location = new System.Drawing.Point(1, 2);
            this.tab_ventas.Name = "tab_ventas";
            this.tab_ventas.SelectedIndex = 0;
            this.tab_ventas.Size = new System.Drawing.Size(756, 656);
            this.tab_ventas.TabIndex = 2;
            this.tab_ventas.Tag = "";
            // 
            // pag_ventasFecha
            // 
            this.pag_ventasFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pag_ventasFecha.Controls.Add(this.label3);
            this.pag_ventasFecha.Controls.Add(this.label5);
            this.pag_ventasFecha.Controls.Add(this.label4);
            this.pag_ventasFecha.Controls.Add(this.btn_cargarVentasFecha);
            this.pag_ventasFecha.Controls.Add(this.cmb_año);
            this.pag_ventasFecha.Controls.Add(this.cmb_mes);
            this.pag_ventasFecha.Controls.Add(this.rv_ventasFecha);
            this.pag_ventasFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pag_ventasFecha.Location = new System.Drawing.Point(4, 22);
            this.pag_ventasFecha.Name = "pag_ventasFecha";
            this.pag_ventasFecha.Padding = new System.Windows.Forms.Padding(3);
            this.pag_ventasFecha.Size = new System.Drawing.Size(748, 630);
            this.pag_ventasFecha.TabIndex = 0;
            this.pag_ventasFecha.Text = "Ventas por fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Reporte de ventas por mes y año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Año";
            // 
            // btn_cargarVentasFecha
            // 
            this.btn_cargarVentasFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_cargarVentasFecha.FlatAppearance.BorderSize = 0;
            this.btn_cargarVentasFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarVentasFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cargarVentasFecha.ForeColor = System.Drawing.Color.White;
            this.btn_cargarVentasFecha.Location = new System.Drawing.Point(605, 80);
            this.btn_cargarVentasFecha.Name = "btn_cargarVentasFecha";
            this.btn_cargarVentasFecha.Size = new System.Drawing.Size(131, 30);
            this.btn_cargarVentasFecha.TabIndex = 8;
            this.btn_cargarVentasFecha.Text = "Generar Reporte";
            this.btn_cargarVentasFecha.UseVisualStyleBackColor = false;
            this.btn_cargarVentasFecha.Click += new System.EventHandler(this.btn_cargarVentasFecha_Click);
            // 
            // cmb_año
            // 
            this.cmb_año._ComboSinSeleccion = true;
            this.cmb_año._MensajeError = null;
            this.cmb_año._Nombre_campo = null;
            this.cmb_año._Nombre_tabla = null;
            this.cmb_año._tabla_cargar_combo = null;
            this.cmb_año._tabla_cargar_descriptor = null;
            this.cmb_año._tabla_cargar_pk = null;
            this.cmb_año._tabla_join = null;
            this.cmb_año._tabla_join_pk = null;
            this.cmb_año._Validable = true;
            this.cmb_año.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmb_año.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_año.ForeColor = System.Drawing.Color.White;
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmb_año.Location = new System.Drawing.Point(107, 64);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(124, 25);
            this.cmb_año.TabIndex = 5;
            // 
            // cmb_mes
            // 
            this.cmb_mes._ComboSinSeleccion = true;
            this.cmb_mes._MensajeError = null;
            this.cmb_mes._Nombre_campo = null;
            this.cmb_mes._Nombre_tabla = null;
            this.cmb_mes._tabla_cargar_combo = null;
            this.cmb_mes._tabla_cargar_descriptor = null;
            this.cmb_mes._tabla_cargar_pk = null;
            this.cmb_mes._tabla_join = null;
            this.cmb_mes._tabla_join_pk = null;
            this.cmb_mes._Validable = true;
            this.cmb_mes.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmb_mes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mes.ForeColor = System.Drawing.Color.White;
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_mes.Location = new System.Drawing.Point(368, 64);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(129, 25);
            this.cmb_mes.TabIndex = 4;
            // 
            // rv_ventasFecha
            // 
            this.rv_ventasFecha.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rv_ventasFecha.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Ventas.Reporte_Ventas_Fecha.rdlc";
            this.rv_ventasFecha.Location = new System.Drawing.Point(12, 116);
            this.rv_ventasFecha.Name = "rv_ventasFecha";
            this.rv_ventasFecha.ServerReport.BearerToken = null;
            this.rv_ventasFecha.ShowBackButton = false;
            this.rv_ventasFecha.ShowParameterPrompts = false;
            this.rv_ventasFecha.ShowPromptAreaButton = false;
            this.rv_ventasFecha.ShowRefreshButton = false;
            this.rv_ventasFecha.ShowStopButton = false;
            this.rv_ventasFecha.Size = new System.Drawing.Size(724, 507);
            this.rv_ventasFecha.TabIndex = 3;
            // 
            // tab_ventasCliente
            // 
            this.tab_ventasCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tab_ventasCliente.Controls.Add(this.label2);
            this.tab_ventasCliente.Controls.Add(this.label1);
            this.tab_ventasCliente.Controls.Add(this.btn_cargarVentasCliente);
            this.tab_ventasCliente.Controls.Add(this.rv_ventasCliente);
            this.tab_ventasCliente.Controls.Add(this.cmb_clientes);
            this.tab_ventasCliente.Location = new System.Drawing.Point(4, 22);
            this.tab_ventasCliente.Name = "tab_ventasCliente";
            this.tab_ventasCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ventasCliente.Size = new System.Drawing.Size(748, 630);
            this.tab_ventasCliente.TabIndex = 1;
            this.tab_ventasCliente.Text = "Ventas por cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Reporte de ventas por cliente";
            // 
            // btn_cargarVentasCliente
            // 
            this.btn_cargarVentasCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_cargarVentasCliente.FlatAppearance.BorderSize = 0;
            this.btn_cargarVentasCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarVentasCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cargarVentasCliente.ForeColor = System.Drawing.Color.White;
            this.btn_cargarVentasCliente.Location = new System.Drawing.Point(605, 80);
            this.btn_cargarVentasCliente.Name = "btn_cargarVentasCliente";
            this.btn_cargarVentasCliente.Size = new System.Drawing.Size(131, 30);
            this.btn_cargarVentasCliente.TabIndex = 11;
            this.btn_cargarVentasCliente.Text = "Generar Reporte";
            this.btn_cargarVentasCliente.UseVisualStyleBackColor = false;
            this.btn_cargarVentasCliente.Click += new System.EventHandler(this.btn_cargarVentasCliente_Click);
            // 
            // rv_ventasCliente
            // 
            this.rv_ventasCliente.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Ventas.Reporte_Ventas_Cliente.rdlc";
            this.rv_ventasCliente.Location = new System.Drawing.Point(12, 116);
            this.rv_ventasCliente.Name = "rv_ventasCliente";
            this.rv_ventasCliente.ServerReport.BearerToken = null;
            this.rv_ventasCliente.ShowBackButton = false;
            this.rv_ventasCliente.ShowParameterPrompts = false;
            this.rv_ventasCliente.ShowPromptAreaButton = false;
            this.rv_ventasCliente.ShowRefreshButton = false;
            this.rv_ventasCliente.ShowStopButton = false;
            this.rv_ventasCliente.Size = new System.Drawing.Size(724, 507);
            this.rv_ventasCliente.TabIndex = 10;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes._ComboSinSeleccion = true;
            this.cmb_clientes._MensajeError = null;
            this.cmb_clientes._Nombre_campo = null;
            this.cmb_clientes._Nombre_tabla = null;
            this.cmb_clientes._tabla_cargar_combo = "cliente";
            this.cmb_clientes._tabla_cargar_descriptor = "razon_social";
            this.cmb_clientes._tabla_cargar_pk = "cuit_cliente";
            this.cmb_clientes._tabla_join = null;
            this.cmb_clientes._tabla_join_pk = null;
            this.cmb_clientes._Validable = true;
            this.cmb_clientes.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmb_clientes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clientes.ForeColor = System.Drawing.Color.White;
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(119, 62);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(224, 25);
            this.cmb_clientes.TabIndex = 9;
            // 
            // Frm_Reporte_Ventas
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(759, 659);
            this.Controls.Add(this.tab_ventas);
            this.Name = "Frm_Reporte_Ventas";
            this.Load += new System.EventHandler(this.Frm_Reporte_Ventas_Load);
            this.Controls.SetChildIndex(this.tab_ventas, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.tab_ventas.ResumeLayout(false);
            this.pag_ventasFecha.ResumeLayout(false);
            this.pag_ventasFecha.PerformLayout();
            this.tab_ventasCliente.ResumeLayout(false);
            this.tab_ventasCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ventas;
        private System.Windows.Forms.TabPage pag_ventasFecha;
        private System.Windows.Forms.TabPage tab_ventasCliente;
        private Clases.ComboBox01 cmb_mes;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ventasFecha;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ventasCliente;
        private Clases.ComboBox01 cmb_clientes;
        private System.Windows.Forms.Button btn_cargarVentasFecha;
        private System.Windows.Forms.Button btn_cargarVentasCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_año;
    }
}
