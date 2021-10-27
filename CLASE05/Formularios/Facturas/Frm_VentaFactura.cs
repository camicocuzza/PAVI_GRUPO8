using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE05.Informes.Reportes.Ventas;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Facturas
{
    public partial class Frm_VentaFactura : CLASE05.Formularios.FrmBASE.FrmBase
    {
        NE_Facturas ne_factura = new NE_Facturas();
        public string num_factura;
        public IList<string> parametros = new List<string>();
        public Frm_VentaFactura()
        {
            InitializeComponent();
        }

        private void Frm_VentaFactura_Load(object sender, EventArgs e)
        {
            ReportDataSource reporteArt = new ReportDataSource("DataFacturaArt", ne_factura.DataSourceArt(num_factura));
            ReportDataSource reporteEns = new ReportDataSource("DataFacturaEns", ne_factura.DataSourceEns(num_factura));
            IList<ReportParameter> param = new List<ReportParameter>
            {                
                new ReportParameter("mes", parametros[0].ToString()),
                new ReportParameter("año", parametros[1].ToString()),
                new ReportParameter("cuit", parametros[2].ToString())        
            };

            this.rvListado.LocalReport.ReportEmbeddedResource = "CLASE05.Reportes.Ventas.VentaFactura.rdlc";
            this.rvListado.LocalReport.DataSources.Clear();
            this.rvListado.LocalReport.DataSources.Add(reporteArt);
            this.rvListado.LocalReport.DataSources.Add(reporteEns);
            this.rvListado.LocalReport.SetParameters(param);
            this.rvListado.RefreshReport();
        }       

        public Frm_VentaFactura(string num_factura, IList<string> parametros)
        {
            this.num_factura = num_factura;
            this.parametros = parametros;
            InitializeComponent();
        }

        private void CargarInforme(string mensaje, bool estado, bool defecto)
        {
            if (defecto)
            {
                lblInformes.BackColor = System.Drawing.Color.LightGray;
                lblInformes.ForeColor = System.Drawing.Color.Black;
                lblInformes.Text = mensaje;
            }
            else
            {
                if (!estado)
                {
                    lblInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
                    lblInformes.ForeColor = System.Drawing.Color.White;
                    lblInformes.Text = mensaje;
                }
                else
                {
                    lblInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
                    lblInformes.ForeColor = System.Drawing.Color.White;
                    lblInformes.Text = mensaje;
                }
            }
        }

        private bool ValidarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                return (Regex.Replace(email, expresion, String.Empty).Length == 0);
            }

            return false;
        }        
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (this.rvListado.PrintDialog() == DialogResult.OK)
            {
                CargarInforme("DOCUMENTO ENVIADO A COLA DE IMPRESIÓN", true, false);
            }
            else
            {
                CargarInforme("OPERACIÓN CANCELADA", false, false);
            }
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            //Byte[] bytes = this.rvListado.LocalReport.Render("PDF");
            var deviceInfo = @"<DeviceInfo>
                            <EmbedFonts>None</EmbedFonts>
                            </DeviceInfo>";

            byte[] bytes = rvListado.LocalReport.Render("PDF", deviceInfo);
            SaveFileDialog guardar = new SaveFileDialog
            {
                FileName = "Factura [" + num_factura.ToString() + "]",
                DefaultExt = ".pdf",
                Filter = "PDF (*.pdf)|*.pdf"
            };

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Create(guardar.FileName);
                file.Write(bytes, 0, bytes.Length);
                file.Flush();
                file.Close();

                CargarInforme("DOCUMENTO PDF GENERADO CON ÉXITO", true, false);
            }
            else
            {
                CargarInforme("OPERACIÓN CANCELADA", false, false);
            }
        }       
        private void BtnEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Correo Electrónico")
            {
                CargarInforme("DATO OBLIGATORIO: CORREO ELECTRÓNICO", false, false);
                txtEmail.Text = "";
                txtEmail.Focus();

                return;
            }

            if (ValidarEmail(txtEmail.Text))
            {
                //Byte[] bytes = this.rvListado.LocalReport.Render("PDF");
                var deviceInfo = @"<DeviceInfo>
                                <EmbedFonts>None</EmbedFonts>
                                </DeviceInfo>";

                byte[] bytes = rvListado.LocalReport.Render("PDF", deviceInfo);
                string nombreRemitente = "Mayortic Tecnologías";
                string emailRemitente = "mayortic.cba@gmail.com";
                string claveRemitente = "mayortic123";

                string emailDestinatario = txtEmail.Text;

                MailMessage correo = new MailMessage { From = new MailAddress(emailRemitente, nombreRemitente) };
                correo.To.Add(new MailAddress(emailDestinatario));
                correo.Subject = "Factura Número " + num_factura.ToString();
                correo.Attachments.Add(new Attachment(new MemoryStream(bytes), "Factura [" + num_factura.ToString() + "].pdf"));
                correo.Body = "Estimad@, se le adjunta la factura correspondiente a su compra. ¡Saludos!";

                try
                {
                    SmtpClient smtpCliente = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        EnableSsl = true,
                        Port = 587,
                        Credentials = new System.Net.NetworkCredential(emailRemitente, claveRemitente)
                    };

                    smtpCliente.Send(correo);

                    CargarInforme("DOCUMENTO PDF ENVIADO CON ÉXITO", true, false);
                }
                catch (Exception)
                {
                    CargarInforme("ERROR DE SERVIDOR AL ENVIAR DOCUMENTO PDF", false, false);
                }
            }
            else
            {
                CargarInforme("FORMATO DE EMAIL INCORRECTO\nFORMATO ADMITIDO: usuario@dominio.com", false, false);
                txtEmail.Focus();

                return;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Correo Electrónico";
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Correo Electrónico")
            {
                txtEmail.Text = "";
            }
        }
    }
}

