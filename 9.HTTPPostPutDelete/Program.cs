using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;

namespace FundamentosCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //CASO POST
            /*string url ="https://jsonplaceholder.typicode.com/posts";
            var client = new HttpClient();

            Post post = new Post()
            {
                userId = 50,
                body = "hola soy un body",
                title = "título de saludo"                
            };

            var data = JsonSerializer.Serialize<Post>(post);
            //tambien se puede hacer con newtonsoft 
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync(url, content);

            if(httpResponse.IsSuccessStatusCode)
            {
                //Console.WriteLine("beber cerveza");
                var result = await httpResponse.Content.ReadAsStringAsync();
                
                var postResult =
                    JsonSerializer.Deserialize<Post>(result);
            }  */
            //CASO PUT
            /*string url ="https://jsonplaceholder.typicode.com/posts/99";
            var client = new HttpClient();

            Post post = new Post()
            {
                userId = 50,
                body = "hola soy un body",
                title = "título de saludo"                
            };

            var data = JsonSerializer.Serialize<Post>(post);
            //tambien se puede hacer con newtonsoft 
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PutAsync(url, content);

            if(httpResponse.IsSuccessStatusCode)
            {
                //Console.WriteLine("beber cerveza");
                var result = await httpResponse.Content.ReadAsStringAsync();
                
                var postResult =
                    JsonSerializer.Deserialize<Post>(result);
            }*/
            //CASO DELETE
            string url ="https://jsonplaceholder.typicode.com/posts/99";
            var client = new HttpClient();

            //

            //var data = JsonSerializer.Serialize<Post>(post);
            //AQUI NO NECESITA OBJETOS 
            //HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.DeleteAsync(url);

            if(httpResponse.IsSuccessStatusCode)
            {
                //Console.WriteLine("beber cerveza");
                var result = await httpResponse.Content.ReadAsStringAsync();
            }
        }    
    }

}
