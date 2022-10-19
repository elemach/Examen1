using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Vehículos
    {
        int indice = 0; 
        static private string[] codigo = new string[5];
        static private string[] marca = new string[5];
        static private float[] costo = new float[5];
        static private string[] modelo = new string[5];
        
        public Vehículos() { }

        public Vehículos(string[] codigo, string[] marca, float[] costo, string[] modelo)
        {
         
        }

        public void agregar_vehiculo()
        {
                Console.WriteLine("Digite el código del vehiculo: "); 
                codigo[indice] = Console.ReadLine();
                Console.WriteLine("Digite la marca del vehiculo: "); 
                marca[indice] = Console.ReadLine();  
                Console.WriteLine("Digite el costo del vehiculo: "); 
                costo[indice] = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el modelo del vehiculo: "); 
                modelo[indice] = Console.ReadLine();
                indice++;
        }

        public void Modificar_Vehiculo()
        {
            string Codigo = "";
            Boolean buscar = false;
            Console.WriteLine("Digite el codigo del vehiculo a modificar: ");
            Codigo = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (Codigo == codigo[i])
                {
                    Console.WriteLine("Digite la marca del vehiculo");
                    marca[i] = Console.ReadLine();
                    Console.WriteLine("Digite el costo del vehiculo");
                    costo[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el modelo del vehiculo");
                    modelo[i] = Console.ReadLine();
                    buscar = true;
                }
            }
            if (!buscar)
            {
                Console.WriteLine("El vehiculo solicitado no se encuentra en el sistena");
            }
        }

        public void Consultar_Articulos()
        {
            string Codigo = "";
            Boolean buscar = false;
            Console.WriteLine("Digite el codigo del vehiculo a buscar");
            Codigo = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (Codigo == codigo[i])
                {
                    Console.WriteLine("Marca: " + marca[i]);
                    Console.WriteLine("Costo: " + costo[i]);
                    Console.WriteLine("Modelo: " + modelo[i]);
                    buscar = true;
                }
            }
            if (!buscar)
            {
                Console.WriteLine("El vehiculo a buscar no se encuentra en el sistena");
            }

        }
        public void Consultar_Vehiculo()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Marca: " + marca[i]);
                Console.WriteLine("Costo: " + costo[i]);
                Console.WriteLine("Modelo: " + modelo[i]);
            }
        }
    }
}
