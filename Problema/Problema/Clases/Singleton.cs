using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema.Clases
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
                    Console.WriteLine("\nInstancia\n");
                    instancia = new Singleton();
                }
                return instancia;
            }
        }

        private List<Automovil> auto;

        public List<Automovil> Auto
        {
            get { return auto; }
            set { auto = value; }
        }

        private List<TodoTerreno> terreno;

        public List<TodoTerreno> Terreno
        {
            get { return terreno; }
            set { terreno = value; }
        }

        private List<Camion> camiones;

        public List<Camion> Camiones
        {
            get { return camiones; }
            set { camiones = value; }
        }

    }
}
