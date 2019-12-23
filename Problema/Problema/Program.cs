using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema.Clases;
using Problema.Interface;
namespace Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            AñoVehiculo año = new AñoVehiculo(vehiculo);
            ModeloVehiculo mod = new ModeloVehiculo(año);
            Console.WriteLine("El vehículo tiene las siguientes caracteristicas\n ");
            Console.WriteLine(mod.Descripcion());

            Automovil auto1 = new Automovil("Spart GT - " , 16000 , " - Marca: Chevrolet ", " - Disponibles: 4 " );
            Automovil auto2 = new Automovil("Rio Sedan - " , 19000 , " - Marca: Kia ", " - Disponibles: 2 ");
            Automovil auto3 = new Automovil("Sail - " , 15000 , " - Marca: Chevrolet", " - Disponibles: 10 ");
            Singleton.Instancia.Auto = new List<Automovil>();
            Singleton.Instancia.Auto.Add(auto1);
            Singleton.Instancia.Auto.Add(auto2);
            Singleton.Instancia.Auto.Add(auto3);

            Camion cami1 = new Camion("Volvo FMX84R - " , 40000 , " - Marca: Volvo ", " - Disponibles: 5 ");
            Camion cami2 = new Camion("NLR - " , 26000 , " - Marca: Chevrolet ", " - Disponibles: 1 ");
            Camion cami3 = new Camion("HD45 - " , 27000 , " - Marca: Hyundai ", " - Disponibles: 7 ");
            Singleton.Instancia.Camiones = new List<Camion>();
            Singleton.Instancia.Camiones.Add(cami1);
            Singleton.Instancia.Camiones.Add(cami2);
            Singleton.Instancia.Camiones.Add(cami3);

            TodoTerreno todo1 = new TodoTerreno("F-150 - " , 45000 , " - Marca: Ford ", " - Disponibles: 15 ");
            TodoTerreno todo2 = new TodoTerreno("D-MAX - " , 43000 , " - Marca: Chevrolet ", " - Disponibles: 20 ");
            TodoTerreno todo3 = new TodoTerreno("Hilux - " , 40000 , " - Marca: Toyota ", " - Disponibles: 5 ");
            Singleton.Instancia.Terreno = new List<TodoTerreno>();
            Singleton.Instancia.Terreno.Add(todo1);
            Singleton.Instancia.Terreno.Add(todo2);
            Singleton.Instancia.Terreno.Add(todo3);

            Console.WriteLine("--------- LISTA DE VEHÍCULOS DISPONIBLES ---------");

            Console.WriteLine(" AUTOMOVILES: \n");
            foreach (Automovil item in Singleton.Instancia.Auto)
            {
                Console.WriteLine(item.Mostrar());
            }
            Console.WriteLine(" \nCAMIONES: ");
            foreach (Camion item1 in Singleton.Instancia.Camiones)
            {
                Console.WriteLine(item1.Mostrar());
            }
            Console.WriteLine(" \nTODOTERRENO: ");
            foreach (TodoTerreno item2 in Singleton.Instancia.Terreno)
            {
                Console.WriteLine(item2.Mostrar());
            }
            Console.ReadKey();
        }
    }
}
