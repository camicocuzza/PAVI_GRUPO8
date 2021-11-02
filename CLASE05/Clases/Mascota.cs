using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE05.Clases
{
    class Mascota
    {
        private string nombre;
        private bool sexo;

        public Mascota()
        {
            nombre = "bobby";
            if (nombre == null)
                throw new ApplicationException("");
        }

        public string pNombre
        {
            get { return nombre; }
        }
    }
}
