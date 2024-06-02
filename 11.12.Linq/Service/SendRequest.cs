using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;

namespace FundamentosCSHARP.Service
{

    public class SendRequest<T> //where T : IRequestable
        //<T, U> 
        //where U : IBebidaAlcoholica
    {
        private HttpClient _client = new HttpClient();

        public async Task<T> Send(T model)
        {
            string url ="https://jsonplaceholder.typicode.com/posts/99";

            var data = JsonSerializer.Serialize<T>(model);

            HttpContent content = 
                new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _client.PostAsync(url, content);

            if(httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                //Console.WriteLine("beber cerveza");
                var postResult = JsonSerializer.Deserialize<T>(result);
                return postResult;                
            }

            return default(T);
        }
    }
}