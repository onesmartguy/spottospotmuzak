using System;
using System.Threading.Tasks;
using SpotToSpotMuzak.Server.Middleware.Wrappers;
using SpotToSpotMuzak.Shared.DataModels;

namespace SpotToSpotMuzak.Server.Managers
{
    public interface IApiLogManager
    {
        Task Log(ApiLogItem apiLogItem);
        Task<ApiResponse> Get();
        Task<ApiResponse> GetByApplicationUserId(Guid applicationUserId);
    }
}