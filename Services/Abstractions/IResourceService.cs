using System.Threading.Tasks;

namespace Module5HW1.Services.Abstractions
{
    public interface IResourceService
    {
        public Task GetListResource();
        public Task GetSingleResource();
        public Task GetSingleNotFoundResource();
    }
}
