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
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public enum ResultadoBusqueda { encontre, no_encontre }
        public enum EstadoCarga { correcto, incorrecto }

        public NE_DetalleFactura_Articulos ne_detallearticulos = new NE_DetalleFactura_Articulos();
        public NE_DetalleFactura_EquiposEnsamblados ne_detalleensamblados = new  NE_DetalleFactura_EquiposEnsamblados();
        public NE_Articulos ne_articulos = new NE_Articulos();
        public NE_EquiposEnsamblados ne_ensamblados = new NE_EquiposEnsamblados();
        public NE_Facturas ne_facturas = new NE_Facturas();
        public NE_Clientes ne_clientes = new NE_Clientes();

        NE_Stock_Ensamblados ne_stock_ens = new NE_Stock_Ensamblados();
        NE_Stock ne_stock = new NE_Stock();
      
        public string cuit_cliente { get; set; }
        public string num_factura { get; set; }
        public string id_tipo_factura { get; set; }
        public string fecha { get; set; }
        public Frm_BaseFactura()
        {
            InitializeComponent();
        }

        private void Frm_BaseFactura_Load(object sender, EventArgs e)
        {
            Inicio();
            this._FormularioMovil = true;
        }
        public void Inicio()
        {
            grid_articulos.Formatear("Id, 40, C; Artículo, 150, I; Cantidad, 70, C; Precio, 70, C; Subtotal, 90, C");
            grid_ensamblados.Formatear("Id, 40, C; Equipo Ensamblado, 150, I; Cantidad, 70, C; Precio, 70, C; Subtotal, 90, C");
            cmb_articulos._Cargar_Ordenado_x_Columna("id_rubro");
            cmb_ensamblados._Cargar();
            cmb_tipo_factura._Cargar();
            cmb_pais._Cargar();
            cmb_estado_provincia._Cargar();
            cmb_cliente._Cargar();
            txt_fechaActual.Text = _TE.RecuperarFechaSistema().Substring(0,10);
        }

        public void RecuperarDatosFormulario()
        {
            RecuperarDatosCliente(cuit_cliente);
            RecuperarDatosVenta(num_factura, id_tipo_factura);

        }
        public EstadoCarga RecuperarDatosCliente(string cuit_cliente)
        { 
            DataTable tabla = new DataTable();
            NE_Estados_Provincias ne_prov = new NE_Estados_Provincias();
            NE_Paises ne_pais = new NE_Paises();
            if (cuit_cliente == "")
            {
                MessageBox.Show("Falta ingresar CUIT de cliente");
                return EstadoCarga.incorrecto;
            }
            
            tabla = ne_clientes.RecuperarCliente(cuit_cliente);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("CUIT de cliente invalido", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return EstadoCarga.incorrecto;
            }            
            string id_estado_provincia = tabla.Rows[0]["id_estado_provincia"].ToString();
            DataTable tabla_IdPais = ne_prov.RecuperarIdPais(id_estado_provincia);
            string id_pais = tabla_IdPais.Rows[0]["id_pais"].ToString();           
            txt_cuit_cliente.Text = tabla.Rows[0]["cuit_cliente"].ToString();
            //txt_razon_social._Text = tabla.Rows[0]["razon_social"].ToString();
            cmb_cliente.SelectedValue = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_limite._Text = tabla.Rows[0]["limite_credito"].ToString();
            txt_legajo_empleado.Text = tabla.Rows[0]["legajo_empleado"].ToString();
            cmb_pais.SelectedValue = id_pais.ToString();
            cmb_estado_provincia.SelectedValue = int.Parse(tabla.Rows[0]["id_estado_provincia"].ToString());
            txt_ciudad._Text = tabla.Rows[0]["ciudad"].ToString();

            return EstadoCarga.correcto;
        }
        public void RecuperarDatosVenta(string num_factura, string id_tipo_factura)
        {
            DataTable tabla_detallesArticulos = ne_facturas.RecuperarDetallesArticulos(num_factura, id_tipo_factura);
            DataTable tabla_detallesEnsamblados = ne_facturas.RecuperarDetallesEnsamblados(num_factura, id_tipo_factura);

            //d.cod_prod_ensamblado, a.cod_prod_ensamblado, d.cantidad, d.precio, d.cantidad* d.precio as subtotal
            for (int i = 0; i < tabla_detallesArticulos.Rows.Count; i++)
            {
                grid_articulos.Rows.Add(tabla_detallesArticulos.Rows[i]["cod_articulo"].ToString()
                                         , tabla_detallesArticulos.Rows[i]["nombre"].ToString()
                                         , tabla_detallesArticulos.Rows[i]["cantidad"].ToString()
                                         , tabla_detallesArticulos.Rows[i]["precio"].ToString()
                                         , tabla_detallesArticulos.Rows[i]["subtotal"].ToString());
            }
            for (int i = 0; i < tabla_detallesEnsamblados.Rows.Count; i++)
            {
                grid_ensamblados.Rows.Add(tabla_detallesEnsamblados.Rows[i]["cod_prod_ensamblado"].ToString()
                                         , tabla_detallesEnsamblados.Rows[i]["nombre"].ToString()
                                         , tabla_detallesEnsamblados.Rows[i]["cantidad"].ToString()
                                         , tabla_detallesEnsamblados.Rows[i]["precio"].ToString()
                                         , tabla_detallesEnsamblados.Rows[i]["subtotal"].ToString());
            }
            cmb_tipo_factura.SelectedValue = id_tipo_factura;
            txt_num_factura.Text = num_factura;
            CalcularTotalVenta();
        }
        public void CalcularTotalVenta()
        {
            double sumarArticulos = 0;
            double sumarEnsamblados = 0;

            for (int i = 0; i < grid_articulos.Rows.Count-1; i++)
            {   
                sumarArticulos += double.Parse(grid_articulos.Rows[i].Cells[2].Value.ToString().Replace(".", ","))
                * double.Parse(grid_articulos.Rows[i].Cells[3].Value.ToString().Replace(".", ","));
            }
            for (int i = 0; i < grid_ensamblados.Rows.Count-1; i++)
            {
                sumarEnsamblados += double.Parse(grid_ensamblados.Rows[i].Cells[2].Value.ToString().Replace(".", ","))
                * double.Parse(grid_ensamblados.Rows[i].Cells[3].Value.ToString().Replace(".", ","));
            }
            txt_total_venta.Text = "$"+ (sumarArticulos + sumarEnsamblados).ToString();
        }
        private void btn_agregar_articulo_Click(object sender, EventArgs e)
        {
            if (cmb_articulos.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_cantidad_articulo.Text == "" || txt_cantidad_articulo.Text == "0")
            {
                MessageBox.Show("No ingresó cantidad del artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txt_stock_articulo.Text == "0")
            {
                MessageBox.Show("No hay stock disponible del artículo seleccionado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (int.Parse(txt_stock_articulo.Text) < int.Parse(txt_cantidad_articulo.Text) )
            {
                MessageBox.Show("No hay stock suficiente para la cantidad ingresada", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AgregarFilaGrillaArticulo();
            CalcularTotalVenta();
        }
        private void btn_quitar_articulo_Click(object sender, EventArgs e)
        {
            if(grid_articulos.CurrentRow == null)
            {
                MessageBox.Show("No se seleccionó fila a eliminar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(grid_articulos.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("No se seleccionó fila a eliminar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("¿Está seguro de quitar la fila correspondiente al artículo '" + grid_articulos.CurrentRow.Cells[1].Value.ToString() + "'?"
                , "Importante"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_articulos.Rows.Remove(grid_articulos.Rows[grid_articulos.CurrentRow.Index]);
            }
            CalcularTotalVenta();

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
                                     , txt_precio_articulo.Text
                                     , double.Parse(txt_cantidad_articulo.Text) * double.Parse(txt_precio_articulo.Text));
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
            string cod_articulo = cmb_articulos.SelectedValue.ToString();
            txt_precio_articulo.Text = ne_articulos.RecuperarPrecioArticulo(cmb_articulos.SelectedValue.ToString());
            txt_stock_articulo.Text = ne_stock.ObtenerStock(cod_articulo).Rows[0][0].ToString();
        }
        private void cmb_ensamblados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string cod_prod_ensamblado = cmb_ensamblados.SelectedValue.ToString();
            txt_precio_ensamblado.Text = ne_ensamblados.RecuperarPrecioProdEnsamblado(cmb_ensamblados.SelectedValue.ToString());
            txt_stock_ensamblado.Text = ne_stock_ens.ObtenerStock(cod_prod_ensamblado).Rows[0][0].ToString();            
        }
        private void btn_agregar_ensamblado_Click(object sender, EventArgs e)
        {
            if (cmb_ensamblados.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó un equipo ensamblado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_cantidad_ensamblado.Text == "" || txt_cantidad_ensamblado.Text == "0")
            {
                MessageBox.Show("No ingresó cantidad del equipo ensamblado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_stock_ensamblado.Text == "0")
            {
                MessageBox.Show("No hay stock disponible del equipo seleccionado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (int.Parse(txt_stock_ensamblado.Text) < int.Parse(txt_cantidad_ensamblado.Text))
            {
                MessageBox.Show("No hay stock suficiente para la cantidad ingresada", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AgregarFilaGrillaEnsamblados();
            CalcularTotalVenta();
        }

        private void btn_quitar_ensamblado_Click(object sender, EventArgs e)
        {
            if (grid_ensamblados.CurrentRow == null)
            {
                MessageBox.Show("No se seleccionó fila a eliminar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (grid_ensamblados.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("No se seleccionó fila a eliminar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("¿Está seguro de quitar la fila correspondiente al equipo ensamblado '" + grid_ensamblados.CurrentRow.Cells[1].Value.ToString() + "'?"
                , "Importante"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_ensamblados.Rows.Remove(grid_ensamblados.Rows[grid_ensamblados.CurrentRow.Index]);
            }
            CalcularTotalVenta();
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
                                     , txt_precio_ensamblado.Text
                                     , double.Parse(txt_cantidad_ensamblado.Text) * double.Parse(txt_precio_ensamblado.Text));
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cmb_cliente.SelectedIndex = -1;
        }
        private void txt_cantidad_ensamblado_Click(object sender, EventArgs e)
        {
            txt_cantidad_ensamblado.SelectionStart = txt_cantidad_ensamblado.Text.Length;
        }
        private void txt_cantidad_articulo_Click(object sender, EventArgs e)
        {
            txt_cantidad_articulo.SelectionStart = txt_cantidad_articulo.Text.Length;
        }

        private void txt_cuit_cliente_Click(object sender, EventArgs e)
        {
            txt_cuit_cliente.SelectionStart = 0;
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            limpiarformulario();
        }

        protected void limpiarformulario()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "MaskedTextBox")
                {
                    ((MaskedTextBox)item).Text = "";
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    ((ComboBox01)item).SelectedIndex = -1;
                }
                if (item.GetType().Name == "Grid01")
                {
                    ((Grid01)item).Rows.Clear();
                }
                if (item.GetType().Name == "LabelText02")
                {
                    ((LabelText02)item)._Text = "";
                }
            }
            txt_total_venta.Text = "$0";
            txt_fechaActual.Text = _TE.RecuperarFechaSistema();
        }

        private void cmb_cliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_cliente.SelectedIndex != -1)
            {
                RecuperarDatosCliente(cmb_cliente.SelectedValue.ToString());
            }
        }
    }
}

