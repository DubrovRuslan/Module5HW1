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
    public class UserService : IUserService
    {
        private readonly string _url;
        private readonly IHttpService _httpService;
        private readonly UserServiceReguest _reguests;

        public UserService(IHttpService httpService, IConfigService configService)
        {
            _httpService = httpService;
            _url = configService.GetHttpServiceConfig().Result.Url;
            _reguests = configService.GetUserServiceConfig().Result;
        }

        public async Task GetListUsers()
        {
            var uri = new Uri($@"{_url}{_reguests.ListUsers}");
            await _httpService.SendAsync<ListUsersResponse>(uri, HttpMethod.Get);
        }

        public async Task GetDelayedListUsers()
        {
            var uri = new Uri($@"{_url}{_reguests.DelayedResponse}");
            await _httpService.SendAsync<ListUsersResponse>(uri, HttpMethod.Get);
        }

        public async Task GetSingleUser()
        {
            var uri = new Uri($@"{_url}{_reguests.SingleUser}");
            await _httpService.SendAsync<SingleUserResponse>(uri, HttpMethod.Get);
        }

        public async Task GetSingleUserNotFound()
        {
            var uri = new Uri($@"{_url}{_reguests.SingleUserNotFound}");
            await _httpService.SendAsync<NullResponse>(uri, HttpMethod.Get);
        }

        public async Task PostCreateUser(string name, string job)
        {
            var uri = new Uri($@"{_url}{_reguests.Create}");
            var user = new UserRequest { Name = name, Job = job };
            var httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8);
            await _httpService.SendAsync<CreateResponse>(uri, HttpMethod.Post, httpContent);
        }

        public async Task PutUpdateUser(string name, string job)
        {
            var uri = new Uri($@"{_url}{_reguests.Update}");
            var user = new UserRequest { Name = name, Job = job };
            var httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8);
            await _httpService.SendAsync<UpdateResponse>(uri, HttpMethod.Put, httpContent);
        }

        public async Task PatchUpdateUser(string name, string job)
        {
            var uri = new Uri($@"{_url}{_reguests.Update}");
            var user = new UserRequest { Name = name, Job = job };
            var httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8);
            await _httpService.SendAsync<UpdateResponse>(uri, HttpMethod.Patch, httpContent);
        }

        public async Task DeleteUser()
        {
            var uri = new Uri($@"{_url}{_reguests.Update}");
            await _httpService.SendAsync<NullResponse>(uri, HttpMethod.Delete);
        }
    }
}
