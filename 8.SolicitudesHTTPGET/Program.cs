using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Threading.Tasks;

namespace FundamentosCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url ="https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            /*var res = client.GetAsync(url);

            Console.WriteLine("mordí mi vegan nugget");

            await res;

            Console.WriteLine("beber cerveza");*/
            //ejemplo de espera

            var httpResponse = await client.GetAsync(url);

            if(httpResponse.IsSuccessStatusCode)
            {
                Console.WriteLine("beber cerveza");
                var content = await httpResponse.Content.ReadAsStringAsync();
                /*var jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }; 
                List<Post> posts = 
                    JsonSerializer.Deserialize<List<Post>>(content, jsonSerializerOptions);    */

                List<Models.Post> posts =
                    JsonSerializer.Deserialize<List<Models.Post>>(content);
            }   
        }    
    }

}
