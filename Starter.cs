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
            var tasks = new List<Task>
            {
                _userService.GetListUsers(),
                _userService.GetSingleUser(),
                _userService.GetSingleUserNotFound(),
                _userService.PostCreateUser("morpheus", "leader"),
                _userService.PutUpdateUser("morpheus", "zion resident"),
                _userService.PatchUpdateUser("morpheus", "zion resident"),
                _userService.DeleteUser(),
                _resourceService.GetListResource(),
                _resourceService.GetSingleResource(),
                _resourceService.GetSingleNotFoundResource(),
                _authService.RegisterSuccessful("eve.holt@reqres.in", "pistol"),
                _authService.RegisterUnSuccessful("sydney@fife"),
                _authService.LoginSuccessful("eve.holt@reqres.in", "cityslicka"),
                _authService.LoginUnsuccessful("peter@klaven"),
                _userService.GetDelayedListUsers()
            };
            Task.WaitAll(tasks.ToArray());
            Console.ReadKey();
        }
    }
}
