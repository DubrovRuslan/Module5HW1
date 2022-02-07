using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Module5HW1.Services.Abstractions
{
    public interface IHttpService
    {
        public Task SendAsync<T>(Uri uri, HttpMethod httpMethod, StringContent? httpContent = null);
    }
}
