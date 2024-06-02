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
            CervezaBD cervezaBD = new CervezaBD();
            
            //insertamos nueva cerveza
            {
                Cerveza cerveza = new Cerveza(15, "Pale ale");
                cerveza.Marca="Minerva";
                cerveza.Alcohol=5;
                cervezaBD.Edit(cerveza, 5);
            }

            //eliminamos una cerveza
            {
                cervezaBD.Delete(5);
            }

            //obterner todas las cervezas
            var cervezas = cervezaBD.Get();

            foreach (var cerveza in  cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }
        }

    }

}
