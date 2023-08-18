using System.Threading.Tasks;

namespace Module5HW1.Services.Abstractions
{
    public interface IAuthService
    {
        public Task RegisterSuccessful(string email, string password);
        public Task RegisterUnSuccessful(string email, string? password = null);
        public Task LoginSuccessful(string email, string password);
        public Task LoginUnsuccessful(string email, string? password = null);
    }
}
