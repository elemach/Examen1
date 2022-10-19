using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vendedor
    {
        private static Dictionary<string, string>lista = new Dictionary<string, string>()
        {
           {"1", "Vendedor1"},
           {"2", "Vendedor2"}
        };
        public Vendedor() { }
        public static void Listado_Vendedores()
        {
            foreach (var persona in lista)
            {
                Console.WriteLine("Codigo: " + persona.Key + "\n" + "Nombre: " + persona.Value);
            }
        }
        public static String BuscarVendedor (string value)
        {
            Boolean cont = false;
            Console.WriteLine("Cual es el codigo del vendedor a buscar?");
            value = Console.ReadLine();
            foreach (var persona in lista)
            {
                if (value == persona.Key)
                {
                    Console.WriteLine(persona.Value);
                    cont = true;
                }
            }
            if (cont == false)
            {
                Console.WriteLine("Vendedor no encontrado");
            }

            return value;
        }
    }
}
