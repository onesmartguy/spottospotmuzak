using AutoMapper.Configuration;
using SpotToSpotMuzak.Shared.DataModels;
using SpotToSpotMuzak.Shared.Dto;
using SpotToSpotMuzak.Shared.Dto.Account;
using SpotToSpotMuzak.Shared.Dto.Sample;
using ApiLogItem = SpotToSpotMuzak.Shared.DataModels.ApiLogItem;
using Message = SpotToSpotMuzak.Shared.DataModels.Message;
using UserProfile = SpotToSpotMuzak.Shared.DataModels.UserProfile;

namespace SpotToSpotMuzak.Storage.Mapping
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
