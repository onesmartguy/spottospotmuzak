using System.Collections.Generic;
using System.Threading.Tasks;
using SpotToSpotMuzak.Shared.DataModels;
using SpotToSpotMuzak.Shared.Dto.Sample;

namespace SpotToSpotMuzak.Shared.DataInterfaces
{
    public interface IMessageStore
    {
        Task<Message> AddMessage(MessageDto messageDto);

        Task DeleteById(int id);

        List<MessageDto> GetMessages();
    }
}