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
        public async Task<HttpServiceConfig> GetHttpServiceConfig()
        {
            try
            {
                var configFile = await File.ReadAllTextAsync("Configs/Config.json");
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
                var configFile = await File.ReadAllTextAsync("Configs/UsersRequests.json");
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
                var configFile = await File.ReadAllTextAsync("Configs/ResourceRequests.json");
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
                var configFile = await File.ReadAllTextAsync("Configs/AuthRequests.json");
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
