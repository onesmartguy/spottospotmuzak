using System.Collections.Generic;
using System.Threading.Tasks;
using SpotToSpotMuzak.Server.Middleware.Wrappers;
using SpotToSpotMuzak.Shared;
using SpotToSpotMuzak.Shared.Dto;
using SpotToSpotMuzak.Shared.Dto.Email;

namespace SpotToSpotMuzak.Server.Managers
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