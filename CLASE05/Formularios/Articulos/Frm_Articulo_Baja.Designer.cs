﻿
namespace CLASE05.Formularios.Articulos
{
    partial class Frm_Articulo_Baja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Articulo_Baja));
            this.SuspendLayout();
            // 
            // txt_num_serie
            // 
            this.txt_num_serie.Enabled = false;
            // 
            // label2
            // 
            this.label2.Enabled = false;
            // 
            // cmb_paises
            // 
            this.cmb_paises._ComboSinSeleccion = false;
            this.cmb_paises.DisplayMember = "nombre_pais";
            this.cmb_paises.Enabled = false;
            this.cmb_paises.ValueMember = "id_pais";
            // 
            // cmb_rubros
            // 
            this.cmb_rubros._ComboSinSeleccion = false;
            this.cmb_rubros.DisplayMember = "nombre";
            this.cmb_rubros.Enabled = false;
            this.cmb_rubros.ValueMember = "id_rubro";
            // 

            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            // 
            // txt_tiempo_envio
            // 
            this.txt_tiempo_envio.Enabled = false;
            // 

            // 
            // txt_cod_articulo
            // 
            this.txt_cod_articulo.Enabled = false;
            // 
            // txt_plazo_pago
            // 
            this.txt_plazo_pago.Enabled = false;
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Text = "Borrar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
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
            // Frm_Articulo_Baja
            // 
            this._Titulo = "Baja de Artículo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 424);
            this.Name = "Frm_Articulo_Baja";
            this.Load += new System.EventHandler(this.Frm_Articulo_Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
