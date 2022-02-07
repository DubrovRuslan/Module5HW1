using System.Threading.Tasks;
using Module5HW1.Models.Request;

namespace Module5HW1.Services.Abstractions
{
    public interface IUserService
    {
        public Task GetListUsers();
        public Task GetSingleUser();
        public Task GetSingleUserNotFound();
        public Task PostCreateUser(string name, string job);
        public Task PutUpdateUser(string name, string job);
        public Task PatchUpdateUser(string name, string job);
        public Task DeleteUser();
        public Task GetDelayedListUsers();
    }
}
