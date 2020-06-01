using System.Collections.Generic;
using System.Threading.Tasks;
using SpotToSpotMuzak.Server.Middleware.Wrappers;
using SpotToSpotMuzak.Shared.Dto;
using SpotToSpotMuzak.Shared.Dto.Sample;

namespace SpotToSpotMuzak.Server.Managers
{
    public interface IMessageManager
    {
        Task<ApiResponse> Create(MessageDto messageDto);
        List<MessageDto> GetList();
        Task<ApiResponse> Delete(int id);
    }
}