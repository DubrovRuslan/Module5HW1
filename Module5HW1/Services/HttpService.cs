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
        private ILoggerService _loggerService;

        public HttpService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

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
                    await _loggerService.LogWarningAsync($"Request Status Code: {result.StatusCode}");
                }
                else
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<T>(content);
                    if (response == null)
                    {
                        await _loggerService.LogInfoAsync("Not response");
                    }
                    else
                    {
                        if (response is not null)
                        {
                            await _loggerService.LogInfoAsync(response.ToString() !);
                        }
                    }
                }
            }
            catch (HttpRequestException e)
            {
                await _loggerService.LogErrorAsync($"nException Message :{e.Message} ");
            }
        }
    }
}
