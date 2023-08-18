using System.Threading.Tasks;
using Module5HW1.Configs;

namespace Module5HW1.Services.Abstractions
{
    public interface IConfigService
    {
        public Task<HttpServiceConfig> GetHttpServiceConfig();
        public Task<UserServiceReguest> GetUserServiceConfig();
        public Task<ResourceServiceReguest> GetResourceServiceConfig();
        public Task<AuthServiceReguest> GetAuthServiceConfig();
    }
}
