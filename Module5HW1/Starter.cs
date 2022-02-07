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
            tasks.Add(_userService.PostCreateUser("morpheus", "leader"));
            tasks.Add(_userService.PutUpdateUser("morpheus", "zion resident"));
            tasks.Add(_userService.PatchUpdateUser("morpheus", "zion resident"));
            tasks.Add(_userService.DeleteUser());
            tasks.Add(_resourceService.GetListResource());
            tasks.Add(_resourceService.GetSingleResource());
            tasks.Add(_resourceService.GetSingleNotFoundResource());
            tasks.Add(_authService.RegisterSuccessful("eve.holt@reqres.in", "pistol"));
            tasks.Add(_authService.RegisterUnSuccessful("sydney@fife"));
            tasks.Add(_authService.LoginSuccessful("eve.holt@reqres.in", "cityslicka"));
            tasks.Add(_authService.LoginUnsuccessful("peter@klaven"));
            tasks.Add(_userService.GetDelayedListUsers());
            Task.WaitAll(tasks.ToArray());
            Console.ReadKey();
        }
    }
}
