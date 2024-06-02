using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;
using System.Text.Json;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //A partir de un objeto creamos un archivo en formato JSON
            
            Cerveza cerveza = new Cerveza(10, "Cerveza");
            string miJson = JsonSerializer.Serialize(cerveza);
            File.WriteAllText("objeto.txt", miJson);
            
            //Ahora a la inversa
            string miJson2 = File.ReadAllText("objeto.txt");//debe existir o nos manda una excepción
            Cerveza cerveza2 = JsonSerializer.Deserialize<Cerveza>(miJson2);
        }    
    }

}
