using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{

    class Cerveza: Bebida
    {
        public Cerveza(int Cantidad, string Nombre = "Cerveza")
            :base(Nombre,Cantidad)
        {

        }
    }
}