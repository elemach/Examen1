using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vendedor1 : Vendedor, Ivendedor1
    {
        public void nombre()
        {
            Vendedor.BuscarVendedor("1");
        }
        public void VentasContado() { }
    }
}
