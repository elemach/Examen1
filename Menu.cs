using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public static class Menu
    {
        public static void Menú()
        {
            byte opcion = 1;
            do
            {
                Console.WriteLine("Bienvenido al sistema de venta de vehículos");
                Console.WriteLine("Elija a qué apartado desesa ingresar" + "\n" + "1-Vehículos" + "\n" + "2-Ventas" + "\n" + "3-Reportes" + "\n" + "4-Salir");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: opcion1(); break;
                    case 2: opcion2(); break;
                    case 3: opcion3(); break;
                    case 4: Console.WriteLine("Gracias, adiós"); break;
                    default:break;
                }
            } while (opcion!=4);
            
        }
        public static void opcion1()
        {
            byte opcion = 1;
            Vehículos V = new Vehículos();
            do
            {
                Console.WriteLine("Dijite la opción que desea hacer en Vehiculos: " + "\n" + "1-Agregar" + "\n" + "2-Modificar" + "\n" + "3-Consultar" + "\n" + "4-Salir");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: V.agregar_vehiculo(); break;
                    case 2: V.Modificar_Vehiculo(); break;
                    case 3: V.Consultar_Articulos(); break;
                    case 4: Console.WriteLine("Gracias, adiós"); break;
                    default: break;
                }
            } while (opcion!=4);
        }
        public static void opcion2()
        {
            Vehículos V = new Vehículos();
            V.Consultar_Articulos();
            Console.WriteLine();
            Tipo T = new Tipo();
            T.Listado_Vehiculos();
            Console.WriteLine();
            Vendedor.BuscarVendedor(null);
            Console.ReadKey();
            Console.Clear();
        }
        public static void opcion3()
        {
            Vendedor.Listado_Vendedores();
            Console.WriteLine();
            Tipo.recorrer();
            Console.WriteLine();
            Vehículos V = new Vehículos();
            V.Consultar_Vehiculo();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
