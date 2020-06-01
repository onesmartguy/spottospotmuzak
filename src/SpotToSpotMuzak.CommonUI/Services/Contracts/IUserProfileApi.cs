using System.Threading.Tasks;
using SpotToSpotMuzak.Shared.Dto;
using SpotToSpotMuzak.Shared.Dto.Account;

namespace SpotToSpotMuzak.CommonUI.Services.Contracts
{
    /// <summary>
    /// Access to User Profile information
    /// </summary>
    public interface IUserProfileApi
    {
        Task<ApiResponseDto> Upsert(UserProfileDto userProfile);
        Task<ApiResponseDto> Get();
    }
}
