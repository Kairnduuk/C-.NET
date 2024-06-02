using System;
using FundamentosCSHARP.Models;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Coca-Cola", 1000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);
            Cerveza cerveza = new Cerveza(500, "Stout");
            cerveza.Beberse(200);
            Console.WriteLine(cerveza.Cantidad);
            Console.WriteLine(cerveza.Nombre);
        }
    }

}


