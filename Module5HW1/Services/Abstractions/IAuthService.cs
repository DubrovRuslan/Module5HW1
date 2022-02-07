using System.Threading.Tasks;

namespace Module5HW1.Services.Abstractions
{
    public interface IAuthService
    {
        public Task RegisterSuccessful();
        public Task RegisterUnSuccessful();
        public Task LoginSuccessful();
        public Task LoginUnsuccessful();
    }
}
