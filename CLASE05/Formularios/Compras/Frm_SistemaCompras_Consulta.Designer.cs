
namespace CLASE05.Formularios.Compras
{
    partial class Frm_SistemaCompras_Consulta
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
            this.SuspendLayout();
            // 
            // btn_eliminar_a
            // 
            this.btn_eliminar_a.Visible = false;
            // 
            // cmb_articulo
            // 
            this.cmb_articulo.Enabled = false;
            this.cmb_articulo.Visible = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Visible = false;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Visible = false;
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.Enabled = false;
            // 
            // txt_fecha
            // 
            this.txt_fecha._Etiqueta = "Fecha ";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.Text = "Artículos";
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(640, 422);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(686, 417);
            this.txt_total.Text = "$0";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(353, 422);
            this.btn_grabar.Text = "Aceptar";
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // label2
            // 
            this.label2.Visible = false;
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
            // Frm_SistemaCompras_Consulta
            // 
            this._Titulo = "Datos de la compra";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(823, 467);
            this.Name = "Frm_SistemaCompras_Consulta";
            this.Load += new System.EventHandler(this.Frm_SistemaCompras_Consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
