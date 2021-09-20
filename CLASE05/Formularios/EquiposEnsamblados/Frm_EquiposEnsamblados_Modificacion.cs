using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;
using CLASE05.Formularios.Articulos;

namespace CLASE05.Formularios.EquiposEnsamblados
{
    public partial class Frm_EquiposEnsamblados_Modificacion : CLASE05.Formularios.EquiposEnsamblados.Frm_EquiposEnsamblados
    {
        public Frm_EquiposEnsamblados_Modificacion()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {

                NE_EquiposEnsamblados equipo = new NE_EquiposEnsamblados();

                equipo.cod_prod_ensamblado = txt_cod_p_ensamblado._Text;
                equipo.precio = txt_precio._Text;
                equipo.stock = txt_stock._Text;

                equipo.Modificar();
                MessageBox.Show("Se modificó correctamente el artículo " + txt_cod_p_ensamblado._Text, "Importante");
                this.Dispose();
            }
        }

        private void Frm_EquiposEnsamblados_Modificacion_Load(object sender, EventArgs e)
        {
            NE_EquiposEnsamblados equipo = new NE_EquiposEnsamblados();
            CargarFormulario(equipo.RecuperarEquipo(cod_prod_ensamblado));
            this.grid_articulos.Formatear("Código artículo, 100, C; Cantidad, 100, I");
            grid_articulos.Cargar(equipo.BuscarDetalles(cod_prod_ensamblado));
            cmb_articulo._Cargar();
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_cod_p_ensamblado._Text = tabla.Rows[0]["cod_prod_ensamblado"].ToString();
            txt_precio._Text = tabla.Rows[0]["precio"].ToString();
            txt_stock._Text = tabla.Rows[0]["stock"].ToString();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            NE_EquiposEnsamblados equipo = new NE_EquiposEnsamblados();
            equipo.cod_prod_ensamblado = txt_cod_p_ensamblado._Text;
            equipo.cod_articulo = cmb_articulo.SelectedValue.ToString();
            equipo.cantidad = txt_cantidad._Text;
            equipo.InsertarArticulo();
            MessageBox.Show("Se agregó correctamente", "Importante");
            grid_articulos.Cargar(equipo.BuscarDetalles(cod_prod_ensamblado));
            //this.Dispose();
        }

        private void btn_eliminar_a_Click(object sender, EventArgs e)
        {
            NE_EquiposEnsamblados equipo = new NE_EquiposEnsamblados();
            if (grid_articulos.Rows.Count == 0)
            {
                MessageBox.Show("No hay artículos agregados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_articulos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (MessageBox.Show("¿Está seguro de que desea eliminar el artículo ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                equipo.BorrarDetalle(grid_articulos.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Se eliminó correctamente el artículo", "Importante");
                grid_articulos.Cargar(equipo.BuscarDetalles(cod_prod_ensamblado));
                
            }
            else
                MessageBox.Show("Eliminación cancelada");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grid_articulos.Rows.Count == 0)
            {
                MessageBox.Show("No hay artículos agregados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_articulos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Articulo_Consulta frm_articulo = new Frm_Articulo_Consulta();
            frm_articulo.cod_articulo = grid_articulos.CurrentRow.Cells[0].Value.ToString();
            frm_articulo.ShowDialog();
        }
    }
}
