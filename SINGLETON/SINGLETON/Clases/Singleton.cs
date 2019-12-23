using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINGLETON.Clases
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;
        public static Singleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    Console.WriteLine("Se instancia");
                    instancia = new Singleton();
                }

                return instancia;
            }
        }
        private List<Basededatos> basedatos;
        public List<Basededatos> Basedatos
        {
            get { return basedatos; }
            set { basedatos = value; }
        }
    }
}
