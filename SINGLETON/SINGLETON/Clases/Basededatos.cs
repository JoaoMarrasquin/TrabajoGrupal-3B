using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINGLETON.Clases
{
    public class Basededatos
    {
        public Basededatos(string datos)
        {
            Datos = datos;
        }

        private string datos;
        public string Datos
        {
            get { return datos; }
            set { datos = value; }
        }

        public string Mostrar()
        {
            return "\n" + Datos;
        }
    }
}
