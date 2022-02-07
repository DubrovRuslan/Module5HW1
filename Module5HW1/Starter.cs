using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Module5HW1.Services.Abstractions;

namespace Module5HW1
{
    public class Starter
    {
        private readonly IUserService _userService;
        private readonly IResourceService _resourceService;
        private readonly IAuthService _authService;

        public Starter(IUserService userService, IResourceService resourceService, IAuthService authService)
        {
            _userService = userService;
            _resourceService = resourceService;
            _authService = authService;
        }

        public void Run()
        {
            var tasks = new List<Task>();
            tasks.Add(_userService.GetListUsers());
            tasks.Add(_userService.GetSingleUser());
            tasks.Add(_userService.GetSingleUserNotFound());
            tasks.Add(_userService.PostCreateUser());
            tasks.Add(_userService.PutUpdateUser());
            tasks.Add(_userService.PatchUpdateUser());
            tasks.Add(_userService.DeleteUser());
            tasks.Add(_resourceService.GetListResource());
            tasks.Add(_resourceService.GetSingleResource());
            tasks.Add(_resourceService.GetSingleNotFoundResource());
            tasks.Add(_authService.RegisterSuccessful());
            tasks.Add(_authService.RegisterUnSuccessful());
            tasks.Add(_authService.LoginSuccessful());
            tasks.Add(_authService.LoginUnsuccessful());
            tasks.Add(_userService.GetDelayedListUsers());
            Task.WaitAll(tasks.ToArray());
            Console.ReadKey();
        }
    }
}
