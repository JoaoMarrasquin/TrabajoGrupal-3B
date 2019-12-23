using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema.Clases
{
    public class Automovil
    {
        public Automovil(string nombre,float precio, string marca, string cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.cantidad = cantidad;
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string cantidad;

        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Mostrar()
        {
            return " " + Nombre + Precio + Marca + Cantidad;
        }
    }
}
