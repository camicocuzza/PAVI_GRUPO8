using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Negocios;
using CLASE05.Clases;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_BaseFactura : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public enum ResultadoBusqueda { encontre, no_encontre }
        public enum EstadoCarga { correcto, incorrecto }

        public NE_DetalleFactura_Articulos ne_detallearticulos = new NE_DetalleFactura_Articulos();
        public NE_DetalleFactura_EquiposEnsamblados ne_detalleensamblados = new  NE_DetalleFactura_EquiposEnsamblados();
        public NE_Articulos ne_articulos = new NE_Articulos();
        public NE_EquiposEnsamblados ne_ensamblados = new NE_EquiposEnsamblados();
        public NE_Facturas ne_facturas = new NE_Facturas();
        public NE_Clientes ne_clientes = new NE_Clientes();
        //public string id_perfil = "";
        public string cuit_cliente { get; set; }

        public Frm_BaseFactura()
        {
            InitializeComponent();
        }

        private void Frm_BaseFactura_Load(object sender, EventArgs e)
        {
            Inicio();
        }
        public void Inicio()
        {
            grid_articulos.Formatear("Id, 40, C; Artículo, 150, C; Cantidad, 70, D; Precio, 70, D");
            grid_ensamblados.Formatear("Id, 40, C; Equipo Ensamblado, 150, C; Cantidad, 70, D; Precio, 70, D");
            //ne_articulos.CargarCombo(ref cmb_articulos);
            //ne_ensamblados.CargarCombo(ref cmb_ensamblados);
            cmb_articulos._Cargar();
            cmb_ensamblados._Cargar();
        }
        public EstadoCarga RecuperarDatosCliente(string cuit)
        { 
            DataTable tabla = new DataTable();
            NE_Estados_Provincias ne_prov = new NE_Estados_Provincias();
            NE_Paises ne_pais = new NE_Paises();
            if (cuit == "")
            {
                MessageBox.Show("Falta ingresar CUIT de cliente");
                return EstadoCarga.incorrecto;
            }
            
            tabla = ne_clientes.RecuperarCliente(cuit);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("CUIT de cliente invalido", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return EstadoCarga.incorrecto;
            }
            string id_estado_provincia = tabla.Rows[0]["id_estado_provincia"].ToString();
            DataTable tabla_IdPais = ne_prov.RecuperarIdPais(id_estado_provincia);
            string id_pais = tabla_IdPais.Rows[0]["id_pais"].ToString();           
            txt_cuit_cliente.Text = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_razon_social._Text = tabla.Rows[0]["razon_social"].ToString();
            txt_limite._Text = tabla.Rows[0]["limite_credito"].ToString();  
            cmb_pais.SelectedValue = id_pais.ToString();
            cmb_estado_provincia.SelectedValue = int.Parse(tabla.Rows[0]["id_estado_provincia"].ToString());
            txt_ciudad._Text = tabla.Rows[0]["ciudad"].ToString();
            return EstadoCarga.correcto;
        }

        //private void grid_asingacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (MessageBox.Show("Esta seguro de borrar esta fila"
        //        , "Importante"
        //        , MessageBoxButtons.YesNo
        //        , MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        grid_asingacion.Rows.Remove(grid_asingacion.Rows[grid_asingacion.CurrentRow.Index]);
        //    }
        //}

        //private void grid_descuento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (MessageBox.Show("Esta seguro de borrar esta fila"
        //         , "Importante"
        //         , MessageBoxButtons.YesNo
        //         , MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        grid_descuento.Rows.Remove(grid_descuento.Rows[grid_descuento.CurrentRow.Index]);
        //    }
        //}
        //public void CalcularSueldoNeto()
        //{
        //    if (txt_sueldo_bruto._Text.Trim() == ".")
        //        return;

        //    double sumar = 0;
        //    double restar = 0;

        //    for (int i = 0; i < grid_asingacion.Rows.Count; i++)
        //    {
        //        sumar += double.Parse(grid_asingacion.Rows[i].Cells[2].Value.ToString().Replace(".", ","))
        //            * double.Parse(grid_asingacion.Rows[i].Cells[3].Value.ToString().Replace(".", ","));
        //    }
        //    for (int i = 0; i < grid_descuento.Rows.Count; i++)
        //    {
        //        restar += double.Parse(grid_descuento.Rows[i].Cells[2].Value.ToString().Replace(".", ","))
        //            * double.Parse(grid_descuento.Rows[i].Cells[3].Value.ToString().Replace(".", ","));
        //    }

        //    txt_sueldo_neto._Text = (double.Parse(txt_sueldo_bruto._Text.Replace(".", ",")) + sumar + restar).ToString();
        //}
        private void btn_agregar_articulo_Click(object sender, EventArgs e)
        {
            if (cmb_articulos.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_cantidad_articulo.Text == "")
            {
                MessageBox.Show("No ingresó cantidad del artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AgregarFilaGrillaArticulo();
            //CalcularSueldoNeto();
        }
        private void btn_quitar_articulo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de quitar la fila correspondiente al artículo '" + grid_articulos.CurrentRow.Cells[1] + "'?"
                , "Importante"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_articulos.Rows.Remove(grid_articulos.Rows[grid_articulos.CurrentRow.Index]);
            }

        }
        private void AgregarFilaGrillaArticulo()
        {
            if (BuscarRepetido(cmb_articulos.SelectedValue.ToString(), grid_articulos) == ResultadoBusqueda.encontre)
            {
                MessageBox.Show("Este artículo ya fue cargado. " +
                                "\nPara modificar, elimínelo de la grilla y vuelva a cargarlo");
                return;
            }
            grid_articulos.Rows.Add(cmb_articulos.SelectedValue.ToString()
                                     , cmb_articulos.Text
                                     , txt_cantidad_articulo.Text
                                     , txt_precio_articulo.Text);
        }
        private ResultadoBusqueda BuscarRepetido(string id, Grid01 Grid)
        {
            if (Grid.Rows.Count > 1)
            {
                for (int i = 0; i < Grid.Rows.Count-1; i++)
                {
                    if (Grid.Rows[i].Cells[0].Value.ToString() == id)
                    {
                        return ResultadoBusqueda.encontre;
                    }
                }
                return ResultadoBusqueda.no_encontre;
            }
            return ResultadoBusqueda.no_encontre;
        }

        private void cmb_articulos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_precio_articulo.Text = ne_articulos.RecuperarPrecioArticulo(cmb_articulos.SelectedValue.ToString());
        }


        private void cmb_ensamblados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_precio_ensamblado.Text = ne_ensamblados.RecuperarPrecioProdEnsamblado(cmb_ensamblados.SelectedValue.ToString());
        }

        private void btn_agregar_ensamblado_Click(object sender, EventArgs e)
        {
            if (cmb_ensamblados.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó un equipo ensamblado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_cantidad_ensamblado.Text == "")
            {
                MessageBox.Show("No ingresó cantidad del equipo ensamblado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AgregarFilaGrillaEnsamblados();
            //CalcularSueldoNeto();
        }
        private void btn_quitar_ensamblado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de quitar la fila correspondiente al equipo ensamblado '" + grid_ensamblados.CurrentRow.Cells[1] +"'?"
                , "Importante"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_ensamblados.Rows.Remove(grid_ensamblados.Rows[grid_ensamblados.CurrentRow.Index]);
            }
        }
        private void AgregarFilaGrillaEnsamblados()
        {
            if (BuscarRepetido(cmb_ensamblados.SelectedValue.ToString(), grid_ensamblados) == ResultadoBusqueda.encontre)
            {
                MessageBox.Show("Este equipo ensamblado ya fue cargado. " +
                                "\nPara modificar, elimínelo de la grilla y vuelva a cargarlo");
                return;
            }
            grid_ensamblados.Rows.Add(cmb_ensamblados.SelectedValue.ToString()
                                     , cmb_ensamblados.Text
                                     , txt_cantidad_ensamblado.Text
                                     , txt_precio_ensamblado.Text);
        }

    }
}
