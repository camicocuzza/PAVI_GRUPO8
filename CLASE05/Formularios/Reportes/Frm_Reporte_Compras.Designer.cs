
namespace CLASE05.Formularios.Reportes
{
    partial class Frm_Reporte_Compras
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cargarComprasProveedor = new System.Windows.Forms.Button();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_proveedores = new CLASE05.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_mes = new CLASE05.Clases.LabelText02();
            this.txt_año = new CLASE05.Clases.LabelText02();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_cargarComprasFecha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage2.Controls.Add(this.btn_cargarComprasProveedor);
            this.tabPage2.Controls.Add(this.rv02);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmb_proveedores);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compras por proveedor";
            // 
            // btn_cargarComprasProveedor
            // 
            this.btn_cargarComprasProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_cargarComprasProveedor.FlatAppearance.BorderSize = 0;
            this.btn_cargarComprasProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarComprasProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cargarComprasProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_cargarComprasProveedor.Location = new System.Drawing.Point(501, 79);
            this.btn_cargarComprasProveedor.Name = "btn_cargarComprasProveedor";
            this.btn_cargarComprasProveedor.Size = new System.Drawing.Size(131, 30);
            this.btn_cargarComprasProveedor.TabIndex = 30;
            this.btn_cargarComprasProveedor.Text = "Generar Reporte";
            this.btn_cargarComprasProveedor.UseVisualStyleBackColor = false;
            this.btn_cargarComprasProveedor.Click += new System.EventHandler(this.btn_cargarComprasProveedor_Click);
            // 
            // rv02
            // 
            this.rv02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv02.Location = new System.Drawing.Point(6, 128);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(651, 554);
            this.rv02.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Proveedor";
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores._ComboSinSeleccion = true;
            this.cmb_proveedores._MensajeError = null;
            this.cmb_proveedores._Nombre_campo = null;
            this.cmb_proveedores._Nombre_tabla = null;
            this.cmb_proveedores._tabla_cargar_combo = "proveedor";
            this.cmb_proveedores._tabla_cargar_descriptor = "razon_social";
            this.cmb_proveedores._tabla_cargar_pk = "cuit_proveedor";
            this.cmb_proveedores._tabla_join = null;
            this.cmb_proveedores._tabla_join_pk = null;
            this.cmb_proveedores._Validable = true;
            this.cmb_proveedores.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmb_proveedores.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.cmb_proveedores.ForeColor = System.Drawing.Color.White;
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.Location = new System.Drawing.Point(131, 76);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Size = new System.Drawing.Size(207, 25);
            this.cmb_proveedores.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Reporte de compras por proveedor";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.txt_año);
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.btn_cargarComprasFecha);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_mes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compras por fecha";
            // 
            // txt_mes
            // 
            this.txt_mes._Ancho = 2;
            this.txt_mes._Decimales = 0;
            this.txt_mes._Etiqueta = "Mes";
            this.txt_mes._Mask = "99";
            this.txt_mes._MensajeError = null;
            this.txt_mes._Nombre_campo = null;
            this.txt_mes._Nombre_tabla = null;
            this.txt_mes._ReadOnly = false;
            this.txt_mes._StartEnCero = false;
            this.txt_mes._Text = "";
            this.txt_mes._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_mes._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_mes._Validable = true;
            this.txt_mes.BackColor = System.Drawing.Color.Transparent;
            this.txt_mes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_mes.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_mes.Location = new System.Drawing.Point(199, 75);
            this.txt_mes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(228, 30);
            this.txt_mes.TabIndex = 29;
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
            this.txt_año._StartEnCero = false;
            this.txt_año._Text = "";
            this.txt_año._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_año._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_año._Validable = true;
            this.txt_año.BackColor = System.Drawing.Color.Transparent;
            this.txt_año.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_año.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_año.Location = new System.Drawing.Point(0, 75);
            this.txt_año.Margin = new System.Windows.Forms.Padding(4);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(228, 30);
            this.txt_año.TabIndex = 28;
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(6, 128);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(651, 554);
            this.rv01.TabIndex = 27;
            // 
            // btn_cargarComprasFecha
            // 
            this.btn_cargarComprasFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btn_cargarComprasFecha.FlatAppearance.BorderSize = 0;
            this.btn_cargarComprasFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarComprasFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cargarComprasFecha.ForeColor = System.Drawing.Color.White;
            this.btn_cargarComprasFecha.Location = new System.Drawing.Point(501, 75);
            this.btn_cargarComprasFecha.Name = "btn_cargarComprasFecha";
            this.btn_cargarComprasFecha.Size = new System.Drawing.Size(131, 30);
            this.btn_cargarComprasFecha.TabIndex = 9;
            this.btn_cargarComprasFecha.Text = "Generar Reporte";
            this.btn_cargarComprasFecha.UseVisualStyleBackColor = false;
            this.btn_cargarComprasFecha.Click += new System.EventHandler(this.btn_cargarComprasFecha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Reporte de compras por mes y año";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 714);
            this.tabControl1.TabIndex = 2;
            // 
            // Frm_Reporte_Compras
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(675, 729);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Reporte_Compras";
            this.Load += new System.EventHandler(this.Frm_Reporte_Compras_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.Button btn_cargarComprasFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private Clases.LabelText02 txt_mes;
        private Clases.LabelText02 txt_año;
        private Clases.ComboBox01 cmb_proveedores;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
        private System.Windows.Forms.Button btn_cargarComprasProveedor;
    }
}
