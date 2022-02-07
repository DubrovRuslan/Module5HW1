using System;
using System.IO;
using System.Threading.Tasks;
using Module5HW1.Configs;
using Module5HW1.Services.Abstractions;
using Newtonsoft.Json;

namespace Module5HW1.Services
{
    public class ConfigService : IConfigService
    {
        private readonly string _configPath = @"Configs/Config.json";
        private readonly string _usersRequestsPath = @"Configs/UsersRequests.json";
        private readonly string _resourceRequestsPath = @"Configs/ResourceRequests.json";
        private readonly string _authRequestsPath = @"Configs/AuthRequests.json";

        public async Task<HttpServiceConfig> GetHttpServiceConfig()
        {
            try
            {
                var configFile = await File.ReadAllTextAsync(_configPath);
                var config = JsonConvert.DeserializeObject<HttpServiceConfig>(configFile);
                return config!;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return default!;
        }

        public async Task<UserServiceReguest> GetUserServiceConfig()
        {
            try
            {
                var configFile = await File.ReadAllTextAsync(_usersRequestsPath);
                var config = JsonConvert.DeserializeObject<UserServiceReguest>(configFile);
                return config!;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return default!;
        }

        public async Task<ResourceServiceReguest> GetResourceServiceConfig()
        {
            try
            {
                var configFile = await File.ReadAllTextAsync(_resourceRequestsPath);
                var config = JsonConvert.DeserializeObject<ResourceServiceReguest>(configFile);
                return config!;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return default!;
        }

        public async Task<AuthServiceReguest> GetAuthServiceConfig()
        {
            try
            {
                var configFile = await File.ReadAllTextAsync(_authRequestsPath);
                var config = JsonConvert.DeserializeObject<AuthServiceReguest>(configFile);
                return config!;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return default!;
        }
    }
}
