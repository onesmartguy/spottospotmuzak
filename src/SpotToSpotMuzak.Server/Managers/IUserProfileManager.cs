using System.Threading.Tasks;
using SpotToSpotMuzak.Server.Middleware.Wrappers;
using SpotToSpotMuzak.Shared.Dto.Account;

namespace SpotToSpotMuzak.Server.Managers
{
    public interface IUserProfileManager
    {
        Task<ApiResponse> Get();
        Task<ApiResponse> Upsert(UserProfileDto userProfile);
        Task<string> GetLastPageVisited(string userName);
    }
}