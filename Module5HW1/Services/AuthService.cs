using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Module5HW1.Configs;
using Module5HW1.Models.Request;
using Module5HW1.Models.Response;
using Module5HW1.Services.Abstractions;
using Newtonsoft.Json;

namespace Module5HW1.Services
{
    public class AuthService : IAuthService
    {
        private readonly string _url;
        private readonly IHttpService _httpService;
        private readonly AuthServiceReguest _reguests;
        public AuthService(IHttpService httpService, IConfigService configService)
        {
            _httpService = httpService;
            _url = configService.GetHttpServiceConfig().Result.Url;
            _reguests = configService.GetAuthServiceConfig().Result;
        }

        public async Task RegisterSuccessful()
        {
            var uri = new Uri($@"{_url}{_reguests.Register}");
            var login = new LoginlRequest { Email = "eve.holt@reqres.in", Password = "pistol" };
            var httpContent = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8);
            await _httpService.SendAsync<RegisterSuccessfulResponse>(uri, HttpMethod.Post, httpContent);
        }

        public async Task RegisterUnSuccessful()
        {
            var uri = new Uri($@"{_url}{_reguests.Register}");
            var login = new LoginlRequest { Email = "sydney@fife", Password = null };
            var httpContent = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8);
            await _httpService.SendAsync<RegisterUnsuccessfulResponse>(uri, HttpMethod.Post, httpContent);
        }

        public async Task LoginSuccessful()
        {
            var uri = new Uri($@"{_url}{_reguests.Login}");
            var login = new LoginlRequest { Email = "eve.holt@reqres.in", Password = "cityslicka" };
            var httpContent = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8);
            await _httpService.SendAsync<LoginSuccessfulResponse>(uri, HttpMethod.Post, httpContent);
        }

        public async Task LoginUnsuccessful()
        {
            var uri = new Uri($@"{_url}{_reguests.Login}");
            var login = new LoginlRequest { Email = "peter@klaven", Password = null };
            var httpContent = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8);
            await _httpService.SendAsync<LoginUnsuccessfulResponse>(uri, HttpMethod.Post, httpContent);
        }
    }
}
