using System.Collections.Generic;
using System.Threading.Tasks;
using SpotToSpotMuzik.Shared.DataModels;
using SpotToSpotMuzik.Shared.Dto.Sample;

namespace SpotToSpotMuzik.Shared.DataInterfaces
{
    public interface IMessageStore
    {
        Task<Message> AddMessage(MessageDto messageDto);

        Task DeleteById(int id);

        List<MessageDto> GetMessages();
    }
}