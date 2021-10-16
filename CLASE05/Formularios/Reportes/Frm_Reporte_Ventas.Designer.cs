
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
            this.btn_cargarVentasFecha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_año = new CLASE05.Clases.ComboBox01();
            this.cmb_mes = new CLASE05.Clases.ComboBox01();
            this.rv_ventasFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab_ventasCliente = new System.Windows.Forms.TabPage();
            this.btn_cargarVentasCliente = new System.Windows.Forms.Button();
            this.rv_ventasCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_clientes = new CLASE05.Clases.ComboBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_ventas.SuspendLayout();
            this.pag_ventasFecha.SuspendLayout();
            this.tab_ventasCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(805, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(735, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(770, 2);
            // 
            // tab_ventas
            // 
            this.tab_ventas.Controls.Add(this.pag_ventasFecha);
            this.tab_ventas.Controls.Add(this.tab_ventasCliente);
            this.tab_ventas.Location = new System.Drawing.Point(6, 4);
            this.tab_ventas.Name = "tab_ventas";
            this.tab_ventas.SelectedIndex = 0;
            this.tab_ventas.Size = new System.Drawing.Size(793, 644);
            this.tab_ventas.TabIndex = 2;
            this.tab_ventas.Tag = "";
            // 
            // pag_ventasFecha
            // 
            this.pag_ventasFecha.BackColor = System.Drawing.Color.DimGray;
            this.pag_ventasFecha.Controls.Add(this.btn_cargarVentasFecha);
            this.pag_ventasFecha.Controls.Add(this.label2);
            this.pag_ventasFecha.Controls.Add(this.label1);
            this.pag_ventasFecha.Controls.Add(this.cmb_año);
            this.pag_ventasFecha.Controls.Add(this.cmb_mes);
            this.pag_ventasFecha.Controls.Add(this.rv_ventasFecha);
            this.pag_ventasFecha.Location = new System.Drawing.Point(4, 22);
            this.pag_ventasFecha.Name = "pag_ventasFecha";
            this.pag_ventasFecha.Padding = new System.Windows.Forms.Padding(3);
            this.pag_ventasFecha.Size = new System.Drawing.Size(785, 618);
            this.pag_ventasFecha.TabIndex = 0;
            this.pag_ventasFecha.Text = "Ventas por fecha";
            // 
            // btn_cargarVentasFecha
            // 
            this.btn_cargarVentasFecha.Location = new System.Drawing.Point(502, 45);
            this.btn_cargarVentasFecha.Name = "btn_cargarVentasFecha";
            this.btn_cargarVentasFecha.Size = new System.Drawing.Size(75, 23);
            this.btn_cargarVentasFecha.TabIndex = 8;
            this.btn_cargarVentasFecha.Text = "Cargar";
            this.btn_cargarVentasFecha.UseVisualStyleBackColor = true;
            this.btn_cargarVentasFecha.Click += new System.EventHandler(this.btn_cargarVentasFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Año";
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
            this.cmb_año.Location = new System.Drawing.Point(105, 47);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(121, 21);
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
            this.cmb_mes.Location = new System.Drawing.Point(338, 47);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 4;
            // 
            // rv_ventasFecha
            // 
            this.rv_ventasFecha.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Ventas.Reporte_Ventas_Fecha.rdlc";
            this.rv_ventasFecha.Location = new System.Drawing.Point(37, 112);
            this.rv_ventasFecha.Name = "rv_ventasFecha";
            this.rv_ventasFecha.ServerReport.BearerToken = null;
            this.rv_ventasFecha.ShowBackButton = false;
            this.rv_ventasFecha.ShowParameterPrompts = false;
            this.rv_ventasFecha.ShowPromptAreaButton = false;
            this.rv_ventasFecha.ShowRefreshButton = false;
            this.rv_ventasFecha.ShowStopButton = false;
            this.rv_ventasFecha.Size = new System.Drawing.Size(710, 490);
            this.rv_ventasFecha.TabIndex = 3;
            // 
            // tab_ventasCliente
            // 
            this.tab_ventasCliente.BackColor = System.Drawing.Color.DimGray;
            this.tab_ventasCliente.Controls.Add(this.btn_cargarVentasCliente);
            this.tab_ventasCliente.Controls.Add(this.rv_ventasCliente);
            this.tab_ventasCliente.Controls.Add(this.cmb_clientes);
            this.tab_ventasCliente.Controls.Add(this.label3);
            this.tab_ventasCliente.Location = new System.Drawing.Point(4, 22);
            this.tab_ventasCliente.Name = "tab_ventasCliente";
            this.tab_ventasCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ventasCliente.Size = new System.Drawing.Size(785, 618);
            this.tab_ventasCliente.TabIndex = 1;
            this.tab_ventasCliente.Text = "Ventas por cliente";
            // 
            // btn_cargarVentasCliente
            // 
            this.btn_cargarVentasCliente.Location = new System.Drawing.Point(304, 34);
            this.btn_cargarVentasCliente.Name = "btn_cargarVentasCliente";
            this.btn_cargarVentasCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_cargarVentasCliente.TabIndex = 11;
            this.btn_cargarVentasCliente.Text = "Cargar";
            this.btn_cargarVentasCliente.UseVisualStyleBackColor = true;
            this.btn_cargarVentasCliente.Click += new System.EventHandler(this.btn_cargarVentasCliente_Click);
            // 
            // rv_ventasCliente
            // 
            this.rv_ventasCliente.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.VentaFactura.rdlc";
            this.rv_ventasCliente.Location = new System.Drawing.Point(31, 100);
            this.rv_ventasCliente.Name = "rv_ventasCliente";
            this.rv_ventasCliente.ServerReport.BearerToken = null;
            this.rv_ventasCliente.ShowBackButton = false;
            this.rv_ventasCliente.ShowParameterPrompts = false;
            this.rv_ventasCliente.ShowPromptAreaButton = false;
            this.rv_ventasCliente.ShowRefreshButton = false;
            this.rv_ventasCliente.ShowStopButton = false;
            this.rv_ventasCliente.Size = new System.Drawing.Size(710, 490);
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
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(101, 36);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(121, 21);
            this.cmb_clientes.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente";
            // 
            // Frm_Reporte_Ventas
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(842, 675);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_año;
        private Clases.ComboBox01 cmb_mes;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ventasFecha;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ventasCliente;
        private Clases.ComboBox01 cmb_clientes;
        private System.Windows.Forms.Button btn_cargarVentasFecha;
        private System.Windows.Forms.Button btn_cargarVentasCliente;
    }
}
