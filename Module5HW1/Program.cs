using Microsoft.Extensions.DependencyInjection;
using Module5HW1;
using Module5HW1.Services;
using Module5HW1.Services.Abstractions;

var serviceProvider = new ServiceCollection()
                .AddSingleton<IHttpService, HttpService>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<IResourceService, ResourceService>()
                .AddTransient<IAuthService, AuthService>()
                .AddTransient<IConfigService, ConfigService>()
                .AddTransient<IConsoleNotificator, ConsoleNotificator>()
                .AddTransient<ILoggerService, LoggerService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

var start = serviceProvider.GetService<Starter>();
start!.Run();