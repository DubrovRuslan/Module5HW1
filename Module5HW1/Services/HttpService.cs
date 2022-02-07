using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Module5HW1.Services.Abstractions;
using Newtonsoft.Json;

namespace Module5HW1.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task SendAsync<T>(Uri uri, HttpMethod httpMethod, StringContent? httpContent = null)
        {
            var httpMessage = new HttpRequestMessage();
            httpMessage.Content = httpContent;
            httpMessage.RequestUri = uri;
            httpMessage.Method = httpMethod;
            try
            {
                var result = await _httpClient.SendAsync(httpMessage);
                if (!result.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Request Status Code: {result.StatusCode}");
                }
                else
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<T>(content);
                    if (response == null)
                    {
                        Console.WriteLine("Not response");
                    }
                    else
                    {
                        Console.WriteLine(response);
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
