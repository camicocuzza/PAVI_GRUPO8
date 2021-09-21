using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;


namespace CLASE05.Formularios.EquiposEspeciales
{
    public partial class Frm_EquiposEspeciales_Alta : CLASE05.Formularios.EquiposEspeciales.Frm_EquiposEspeciales
    {
        public Frm_EquiposEspeciales_Alta()
        {
            InitializeComponent();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            ofdSeleccionar.InitialDirectory = "c:\\";
            ofdSeleccionar.Filter = "Imagenes jpg (*.jpg)|*.jpg|Imagenes png (*.png)|*.png";
            ofdSeleccionar.FilterIndex = 1;
            ofdSeleccionar.RestoreDirectory = true;

            //OpenFileDialog ofdeSeleccionar = new OpenFileDialog();
            //ofdeSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            //ofdeSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //ofdeSeleccionar.Title = "Seleccionar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = ofdSeleccionar.FileName;
            }
        }

        private void Frm_EquiposEspeciales_Alta_Load(object sender, EventArgs e)
        {
            cmb_clientes._Cargar();
            cmb_equipos._Cargar();


        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                if(txt_file.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Falta cargar el logo");
                    return;
                }

                byte[] file = null;
                Stream myStream = ofdSeleccionar.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();
                }
               
                // GRABAR NUEVO REGISTRO
                NE_EquiposEspeciales equipo = new NE_EquiposEspeciales();

                equipo.cod_prod_ensamblado = cmb_equipos.SelectedValue.ToString();
                equipo.cuit_cliente = cmb_clientes.SelectedValue.ToString();
                equipo.logo_cliente = file;
                

                equipo.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }
    }
}
