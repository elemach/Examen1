using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Tipo
    {
        public void Tipo_Vehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de vehículos");
        }
        static string[] vehiculos = new string[] { "Motocicleta", "Automóvil", "Dron" };
        public void Listado_Vehiculos()
        {
            Console.WriteLine("Digite el tipo de vehiculo que desea buscar");
            String Buscar = Console.ReadLine();
            bool respuesta = false;
            for (int i = 0; i < vehiculos.Length; i++)
            {
                if (Buscar == vehiculos[i])
                {
                    respuesta = true;
                }
            }
            if (respuesta == true)
            {
                Console.WriteLine("El tipo de vehiculo existe");
            }
            else Console.WriteLine("El tipo de vehiculo no existe");
        }
        public static void recorrer()
        {
            foreach (string s in vehiculos)
            {
                Console.WriteLine(s);
            }
        }
    }
}
