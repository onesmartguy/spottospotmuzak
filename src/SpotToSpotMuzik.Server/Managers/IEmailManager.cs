using System.Collections.Generic;
using System.Threading.Tasks;
using SpotToSpotMuzik.Server.Middleware.Wrappers;
using SpotToSpotMuzik.Shared;
using SpotToSpotMuzik.Shared.Dto;
using SpotToSpotMuzik.Shared.Dto.Email;

namespace SpotToSpotMuzik.Server.Managers
{
    public interface IEmailManager
    {
        Task<ApiResponse> Send(EmailDto parameters);
        Task<ApiResponse> Receive();
        Task<ApiResponse> SendEmailAsync(EmailMessageDto emailMessage);
        List<EmailMessageDto> ReceiveEmail(int maxCount = 10);
        Task<ApiResponse> ReceiveMailImapAsync();
        Task<ApiResponse> ReceiveMailPopAsync(int min = 0, int max = 0);
        void Send(EmailMessageDto emailMessage);
    }
}