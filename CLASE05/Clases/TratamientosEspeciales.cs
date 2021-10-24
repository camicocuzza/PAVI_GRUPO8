using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CLASE05.Clases
{
    class TratamientosEspeciales
    {
        public enum RespuestaValidacion { Correcta, Error }

        public RespuestaValidacion Validar(Control.ControlCollection Controles)
        {
            foreach (var item in Controles)
            {
                if (item.GetType().Name == "LabelText02")
                {
                    if (((LabelText02)item)._Validable == true)
                    {
                        if (((LabelText02)item)._Text == string.Empty)
                        {
                            MessageBox.Show(((LabelText02)item)._MensajeError);
                            ((LabelText02)item).Focus();
                            return RespuestaValidacion.Error;
                        }
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item)._Validable == true)
                    {
                        if (((ComboBox01)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBox01)item)._MensajeError);
                            ((ComboBox01)item).Focus();
                            return RespuestaValidacion.Error;
                        }
                  }
                }
                if (item.GetType().Name == "MaskedTextBox")
                {
                    if (((MaskedTextBox)item).Text == string.Empty)
                    {
                        MessageBox.Show("Límite de crédito está vacío");
                        ((MaskedTextBox)item).Focus();
                        return RespuestaValidacion.Error;
                    }
                }
                if (item.GetType().Name == "MaskedTextBox")
                {                       
                    if (((MaskedTextBox)item).Text == string.Empty)
                    {
                        MessageBox.Show("Límite de crédito está vacío");
                        ((MaskedTextBox)item).Focus();
                        return RespuestaValidacion.Error;
                    }                    
                }             
            }
            return RespuestaValidacion.Correcta;
        }
        public RespuestaValidacion ValidarEmail (string email)
        {
            if (email.IndexOf("@") == -1)
                return RespuestaValidacion.Error;
            else
                return RespuestaValidacion.Correcta;
        }
        public RespuestaValidacion ValidarFecha(string fecha)
        {
            DateTime fechadev;

            if (DateTime.TryParseExact(fecha, "dd/mm/yyyy", null, DateTimeStyles.AssumeLocal, out fechadev))
                return RespuestaValidacion.Correcta;
            else
                return RespuestaValidacion.Error;
        }
        public RespuestaValidacion ValidarFecha1 (string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return RespuestaValidacion.Correcta;
            }
            catch (Exception)
            {
                return RespuestaValidacion.Error;
            }
        }
        public RespuestaValidacion ValidarCuit(string cuit)
        {
            if (cuit.Length < 13)
                return RespuestaValidacion.Error;
            else
                return RespuestaValidacion.Correcta;
        }
        public string RecuperarFechaSistema()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();

            string sql = "SELECT GETDATE()"; 
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }
        public string RecuperarAñoSistema()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();

            string sql = "SELECT YEAR(GETDATE())";
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }


        public string FormatearDato(string dato, string TipoDato)
        {
            switch (TipoDato)
            {
                case "texto":
                case "System.String":
                    return "'" + dato.Trim() + "'";
                case "numero":
                case "System.Int16":
                case "System.Int32":
                case "System.Int64":
                case "System.Double":
                    return dato.Replace(",", ".").Trim();
                case "fecha":
                case "System.DateTime":
                    return "convert(datetime, '" + dato + "', 103)";
                default:
                    return dato;
            }
        }
    }
}
