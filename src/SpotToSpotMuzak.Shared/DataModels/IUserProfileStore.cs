﻿using SpotToSpotMuzak.Shared.Dto.Account;
using System;
using System.Threading.Tasks;

namespace SpotToSpotMuzak.Shared.DataModels
{
    public interface IUserProfileStore
    {
        Task<string> GetLastPageVisited(string username);

        Task<UserProfileDto> Get(Guid userId);

        Task Upsert(UserProfileDto userProfileDto);

        Task DeleteAllApiLogsForUser(Guid userId);
    }
}
