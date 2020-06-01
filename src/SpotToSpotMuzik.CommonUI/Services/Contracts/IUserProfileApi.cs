using System.Threading.Tasks;
using SpotToSpotMuzik.Shared.Dto;
using SpotToSpotMuzik.Shared.Dto.Account;

namespace SpotToSpotMuzik.CommonUI.Services.Contracts
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
