﻿
namespace CLASE05.Formularios.Lotes
{
    partial class Frm_ABM_Lote_Entrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_lotes = new CLASE05.Clases.Grid01();
            this.rb_fecha_compra = new System.Windows.Forms.RadioButton();
            this.rb_n_remito = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_n_lote = new System.Windows.Forms.RadioButton();
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.Text = "Lotes";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_fecha_compra);
            this.groupBox1.Controls.Add(this.rb_n_remito);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_n_lote);
            this.groupBox1.Controls.Add(this.btn_blan_patron);
            this.groupBox1.Controls.SetChildIndex(this.btn_blan_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_n_lote, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_n_remito, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_fecha_compra, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_todos, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            // grid_lotes
            // 
            this.grid_lotes._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_lotes._tamannoLetraHeader = 9;
            this.grid_lotes.AllowUserToAddRows = false;
            this.grid_lotes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_lotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_lotes.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_lotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_lotes.Location = new System.Drawing.Point(12, 223);
            this.grid_lotes.Name = "grid_lotes";
            this.grid_lotes.ReadOnly = true;
            this.grid_lotes.Size = new System.Drawing.Size(645, 158);
            this.grid_lotes.TabIndex = 9;
            // 
            // rb_fecha_compra
            // 
            this.rb_fecha_compra.AutoSize = true;
            this.rb_fecha_compra.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_fecha_compra.Location = new System.Drawing.Point(262, 77);
            this.rb_fecha_compra.Name = "rb_fecha_compra";
            this.rb_fecha_compra.Size = new System.Drawing.Size(130, 21);
            this.rb_fecha_compra.TabIndex = 30;
            this.rb_fecha_compra.TabStop = true;
            this.rb_fecha_compra.Text = "Fecha de compra";
            this.rb_fecha_compra.UseVisualStyleBackColor = true;
            // 
            // rb_n_remito
            // 
            this.rb_n_remito.AutoSize = true;
            this.rb_n_remito.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_n_remito.Location = new System.Drawing.Point(135, 77);
            this.rb_n_remito.Name = "rb_n_remito";
            this.rb_n_remito.Size = new System.Drawing.Size(121, 21);
            this.rb_n_remito.TabIndex = 29;
            this.rb_n_remito.TabStop = true;
            this.rb_n_remito.Text = "Número remito";
            this.rb_n_remito.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Buscar por:";
            // 
            // rb_n_lote
            // 
            this.rb_n_lote.AutoSize = true;
            this.rb_n_lote.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_n_lote.Location = new System.Drawing.Point(25, 77);
            this.rb_n_lote.Name = "rb_n_lote";
            this.rb_n_lote.Size = new System.Drawing.Size(104, 21);
            this.rb_n_lote.TabIndex = 27;
            this.rb_n_lote.TabStop = true;
            this.rb_n_lote.Text = "Número lote";
            this.rb_n_lote.UseVisualStyleBackColor = true;
            // 
            // btn_blan_patron
            // 
            this.btn_blan_patron.BackColor = System.Drawing.Color.Transparent;
            this.btn_blan_patron.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__7_;
            this.btn_blan_patron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_blan_patron.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatAppearance.BorderSize = 0;
            this.btn_blan_patron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blan_patron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.Location = new System.Drawing.Point(293, 22);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_patron.TabIndex = 26;
            this.btn_blan_patron.TabStop = false;
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            this.btn_blan_patron.Click += new System.EventHandler(this.btn_blan_patron_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(158, 29);
            this.txt_patron.Mask = "aaaaaaaaaaaaaaaaaaaa";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 24;
            this.txt_patron.Click += new System.EventHandler(this.txt_patron_Click);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos.Location = new System.Drawing.Point(396, 77);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(64, 21);
            this.rb_todos.TabIndex = 31;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // Frm_ABM_Lote_Entrada
            // 
            this._FormularioMovil = true;
            this._titulo = "Lotes";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.grid_lotes);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_Lote_Entrada";
            this.Load += new System.EventHandler(this.Frm_ABM_Lote_Entrada_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_consultar, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.grid_lotes, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_lotes;
        private System.Windows.Forms.RadioButton rb_fecha_compra;
        private System.Windows.Forms.RadioButton rb_n_remito;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_n_lote;
        private System.Windows.Forms.Button btn_blan_patron;
        private System.Windows.Forms.RadioButton rb_todos;
    }
}
