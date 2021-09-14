namespace CLASE05.Formularios.FrmBASE
{
    partial class FrmBase_ABM_Entrada
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(634, 1);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackgroundImage = global::CLASE05.Properties.Resources.btn_minimizar;
            this.btn_minimizar.Enabled = false;
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(564, 1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Enabled = false;
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(599, 1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restricciones de Búsqueda";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ForeColor = System.Drawing.Color.Silver;
            this.btn_buscar.Location = new System.Drawing.Point(552, 100);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(85, 30);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // btn_alta
            // 
            this.btn_alta.BackColor = System.Drawing.Color.Transparent;
            this.btn_alta.BackgroundImage = global::CLASE05.Properties.Resources.btn_añadir__8_;
            this.btn_alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alta.Location = new System.Drawing.Point(487, 390);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(45, 45);
            this.btn_alta.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_alta, "Crear nuevo registro\r\n");
            this.btn_alta.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_modificar.BackgroundImage = global::CLASE05.Properties.Resources.btn_modificar__1_;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Location = new System.Drawing.Point(548, 390);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(45, 45);
            this.btn_modificar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_modificar, "Modificar registro");
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_borrar.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__2_;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Location = new System.Drawing.Point(605, 387);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(50, 50);
            this.btn_borrar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_borrar, "Eliminar registro");
            this.btn_borrar.UseVisualStyleBackColor = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.Transparent;
            this.btn_consultar.BackgroundImage = global::CLASE05.Properties.Resources.btn_consultar__3_;
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Location = new System.Drawing.Point(425, 389);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(47, 47);
            this.btn_consultar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_consultar, "Consultar registro\r\n");
            this.btn_consultar.UseVisualStyleBackColor = false;
            // 
            // FrmBase_ABM_Entrada
            // 
            this._FormularioMovil = true;
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(471, 76);
            this.Name = "FrmBase_ABM_Entrada";
            this.toolTip1.SetToolTip(this, "Permite ingresar al formulario de Altas de registros\r\n");
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_consultar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btn_alta;
        public System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.Button btn_borrar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_consultar;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn_buscar;
    }
}
