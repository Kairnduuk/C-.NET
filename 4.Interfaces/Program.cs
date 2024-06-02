using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {            
            var bebidaAlcoholica = new Vino(100);            
            MostrarRecomendacion(bebidaAlcoholica);

            var bebidaAlcoholica2 = new Cerveza(100);            
            MostrarRecomendacion(bebidaAlcoholica2);
        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }
    }

}

