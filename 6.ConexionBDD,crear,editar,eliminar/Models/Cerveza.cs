using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{

    class Cerveza: Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set;}

        //public int Alcohol = _Alcohol;

        public string? Marca { get; set;}

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10 botellas");
        }

        public Cerveza(int Cantidad, string Nombre = "Cerveza")
            :base(Nombre,Cantidad)
        {

        }
    }
}