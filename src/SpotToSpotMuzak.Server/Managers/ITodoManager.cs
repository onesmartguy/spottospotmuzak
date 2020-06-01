using System.Threading.Tasks;
using SpotToSpotMuzak.Server.Middleware.Wrappers;
using SpotToSpotMuzak.Shared.Dto.Sample;

namespace SpotToSpotMuzak.Server.Managers
{
    public interface ITodoManager
    {
        Task<ApiResponse> Get();
        Task<ApiResponse> Get(long id);
        Task<ApiResponse> Create(TodoDto todo);
        Task<ApiResponse> Update(TodoDto todo);
        Task<ApiResponse> Delete(long id);
    }
}