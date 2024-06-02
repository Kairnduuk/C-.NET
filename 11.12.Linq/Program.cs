using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;
using FundamentosCSHARP.Service;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Linq;

namespace FundamentosCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            //11. Primero listas antes de pasar a objetos más complejos
            /*List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza() { Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
                new Cerveza() { Alcohol=8, Cantidad=5, Nombre="Ticus", Marca="Colima"},
                new Cerveza() { Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
                new Cerveza() { Alcohol=6, Cantidad=100, Nombre="Piedra Lisa", Marca="Colima"}    
            };*/

            //12.para manipular y obtener objetos complejos con subconsultas
            List<Bar> bares = new List<Bar>()
            {
                cervezas = new List<Cerveza>()
                {
                new Cerveza() { Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
                new Cerveza() { Alcohol=8, Cantidad=5, Nombre="Ticus", Marca="Colima"},
                new Cerveza() { Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
                new Cerveza() { Alcohol=6, Cantidad=100, Nombre="Piedra Lisa", Marca="Colima"}    
                }
            };            
        }    
    }

}
