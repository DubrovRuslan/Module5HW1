using System;
using System.Net.Http;
using System.Threading.Tasks;
using Module5HW1.Configs;
using Module5HW1.Models.Response;
using Module5HW1.Services.Abstractions;

namespace Module5HW1.Services
{
    public class ResourceService : IResourceService
    {
        private readonly string _url;
        private readonly IHttpService _httpService;
        private readonly ResourceServiceReguest _reguests;
        public ResourceService(IHttpService httpService, IConfigService configService)
        {
            _httpService = httpService;
            _url = configService.GetHttpServiceConfig().Result.Url;
            _reguests = configService.GetResourceServiceConfig().Result;
        }

        public async Task GetListResource()
        {
            var uri = new Uri($@"{_url}{_reguests.ListResource}");
            await _httpService.SendAsync<ListResourceResponse>(uri, HttpMethod.Get);
        }

        public async Task GetSingleResource()
        {
            var uri = new Uri($@"{_url}{_reguests.SingleResource}");
            await _httpService.SendAsync<SingleResourceResponse>(uri, HttpMethod.Get);
        }

        public async Task GetSingleNotFoundResource()
        {
            var uri = new Uri($@"{_url}{_reguests.SingleResourceNotFound}");
            await _httpService.SendAsync<NullResponse>(uri, HttpMethod.Get);
        }
    }
}
