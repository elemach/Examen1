﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Motocicleta : Tipo
    {
        new public void Tipo_Vehiculo()
        {
            Console.WriteLine("Vehículo de dos ruedas");
        }
    }
}
