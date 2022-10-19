using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Automovil : Tipo
    {
        new public void Tipo_Vehiculo() 
        {
            Console.WriteLine("Vehículo de cuatro ruedas");
        }
    }
}
