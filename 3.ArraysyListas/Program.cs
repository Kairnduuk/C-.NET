using System;
using FundamentosCSHARP.Models;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 1,2,3,4,5,6,7,8,9,0};

            for (int i= 0; i<numeros.Length; i++)
            {
                Console.WriteLine("Iteración: "+i+" - "+numeros[i]);
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("*********");

            List<int> lista = new List<int>() { 1,2,3,4,5,6,7,8};
            lista.Add(9);
            lista.Remove(0);

            foreach (var numero in lista)
            {
                Console.WriteLine("Elemento: "+numero);
            }

            List<Cerveza> cervezas = new List<Cerveza>()
            {new Cerveza(10,"Premium")};
            cervezas.Add(new Cerveza(500));
            Cerveza erdinger = new Cerveza(500,"de trigo");
            cervezas.Add(erdinger);

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine("Cerveza: "+cerveza.Nombre);
            }
        }
    }

}
