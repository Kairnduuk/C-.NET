using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;
using FundamentosCSHARP.Service;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

namespace FundamentosCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cerveza = new Cerveza()
            { Alcohol = 5, Cantidad = 500, Marca = "Colima", Nombre = "Ticús"};

            Service.SendRequest<Cerveza> service = new Service.SendRequest<Cerveza>();
            var CervezaRespuesta = await service.Send(cerveza);

            //Ahora probamos con otro tipo en el generic, en este caso la clase Post
            var post = new Post()
            { body = "body", title = "hola", userId = 50};

            Service.SendRequest<Post> service2 = new Service.SendRequest<Post>();
            var PostRespuesta = await service2.Send(post);
        }    
    }

}
