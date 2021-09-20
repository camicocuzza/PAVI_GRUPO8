namespace CLASE05.Formularios.InicioSistema
{
    partial class Frm_Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Escritorio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeSistemaConLoginActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ensambladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosEstadísticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aBMToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.gráficosEstadísticosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirDeSistemaConLoginActivoToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirDeSistemaConLoginActivoToolStripMenuItem
            // 
            this.salirDeSistemaConLoginActivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.salirDeSistemaConLoginActivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.salirDeSistemaConLoginActivoToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.salirDeSistemaConLoginActivoToolStripMenuItem.Name = "salirDeSistemaConLoginActivoToolStripMenuItem";
            this.salirDeSistemaConLoginActivoToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.salirDeSistemaConLoginActivoToolStripMenuItem.Text = "Cerrar sesión";
            this.salirDeSistemaConLoginActivoToolStripMenuItem.Click += new System.EventHandler(this.salirDeSistemaConLoginActivoToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.lotesToolStripMenuItem});
            this.aBMToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aBMToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ensambladosToolStripMenuItem,
            this.especialesToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // ensambladosToolStripMenuItem
            // 
            this.ensambladosToolStripMenuItem.Name = "ensambladosToolStripMenuItem";
            this.ensambladosToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.ensambladosToolStripMenuItem.Text = "Ensamblados";
            this.ensambladosToolStripMenuItem.Click += new System.EventHandler(this.ensambladosToolStripMenuItem_Click);
            // 
            // especialesToolStripMenuItem
            // 
            this.especialesToolStripMenuItem.Name = "especialesToolStripMenuItem";
            this.especialesToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.especialesToolStripMenuItem.Text = "Especiales";
            this.especialesToolStripMenuItem.Click += new System.EventHandler(this.especialesToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reporteToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // gráficosEstadísticosToolStripMenuItem
            // 
            this.gráficosEstadísticosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gráficosEstadísticosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.gráficosEstadísticosToolStripMenuItem.Name = "gráficosEstadísticosToolStripMenuItem";
            this.gráficosEstadísticosToolStripMenuItem.Size = new System.Drawing.Size(163, 25);
            this.gráficosEstadísticosToolStripMenuItem.Text = "Gráficos Estadísticos";
            // 
            // lotesToolStripMenuItem
            // 
            this.lotesToolStripMenuItem.Name = "lotesToolStripMenuItem";
            this.lotesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.lotesToolStripMenuItem.Text = "Lotes";
            this.lotesToolStripMenuItem.Click += new System.EventHandler(this.lotesToolStripMenuItem_Click);
            // 
            // Frm_Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::CLASE05.Properties.Resources.Luxury_Business_Presentation5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 373);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Escritorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Escritorio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosEstadísticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeSistemaConLoginActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ensambladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotesToolStripMenuItem;
    }
}

