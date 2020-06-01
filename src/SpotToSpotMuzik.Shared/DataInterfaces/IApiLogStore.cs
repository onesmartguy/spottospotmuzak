using SpotToSpotMuzik.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpotToSpotMuzik.Shared.DataInterfaces
{
    public interface IApiLogStore
    {
        Task<List<ApiLogItemDto>> Get(); 

        Task<List<ApiLogItemDto>> GetByUserId(Guid userId);
    }
}