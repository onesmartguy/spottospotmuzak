using AutoMapper.Configuration;
using SpotToSpotMuzik.Shared.DataModels;
using SpotToSpotMuzik.Shared.Dto;
using SpotToSpotMuzik.Shared.Dto.Account;
using SpotToSpotMuzik.Shared.Dto.Sample;
using ApiLogItem = SpotToSpotMuzik.Shared.DataModels.ApiLogItem;
using Message = SpotToSpotMuzik.Shared.DataModels.Message;
using UserProfile = SpotToSpotMuzik.Shared.DataModels.UserProfile;

namespace SpotToSpotMuzik.Storage.Mapping
{
    public class MappingProfile : MapperConfigurationExpression
    {
        /// <summary>
        /// Create automap mapping profiles
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Todo, TodoDto>().ReverseMap();           
            CreateMap<UserProfile, UserProfileDto>().ReverseMap();
            CreateMap<ApiLogItem, ApiLogItemDto>().ReverseMap();
            CreateMap<Message, MessageDto>().ReverseMap();
        }
    }
}
