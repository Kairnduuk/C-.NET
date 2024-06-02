using System;

namespace FundamentosCSHARP
{

    class Program
    {

        static void Main(string[] args)
        {
        int numero = new int();    
        Console.WriteLine(numero.ToString()); //devuelve valor por defecto en c# = 0

        int? numero2 = null; //con el ? transformamos en nullable y ya no devuelve valor por defecto
        Console.WriteLine(numero2.ToString());

        var nombre = "Santi"; //Asigna el tipo automaticamente y este ya no cambia
        //nombre = 1; generaría un error
        Console.WriteLine(nombre);

        var persona =
            new { nombre = "Héctor", apellido="De León", edad=50};
        Console.WriteLine(persona.edad);
        

        }
    }
}
