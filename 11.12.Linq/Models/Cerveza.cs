using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{

    public class Cerveza: Bebida, IBebidaAlcoholica , IRequestable
    {
        public int Alcohol { get; set;}

        //public int Alcohol = _Alcohol;

        public string? Marca { get; set;}

        public int Id { get; set;}

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10 botellas");
        }

        public Cerveza() : base(null,0)
        {

        }

        public Cerveza(int Cantidad, string Nombre = "Cerveza")
            :base(Nombre,Cantidad)
        {

        }
    }
}