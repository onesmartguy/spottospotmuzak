﻿using SpotToSpotMuzik.Server.Managers;
using SpotToSpotMuzik.Server.Middleware.Wrappers;
using SpotToSpotMuzik.Shared.Dto.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace SpotToSpotMuzik.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileManager _userProfileManager;

        public UserProfileController(IUserProfileManager userProfileManager)
        {
            _userProfileManager = userProfileManager;
        }

        // GET: api/UserProfile
        [HttpGet("Get")]
        public async Task<ApiResponse> Get()
            => await _userProfileManager.Get();

        // POST: api/UserProfile
        [HttpPost("Upsert")]
        public async Task<ApiResponse> Upsert(UserProfileDto userProfile)
            => ModelState.IsValid ?
                await _userProfileManager.Upsert(userProfile) :
                new ApiResponse(Status400BadRequest, "User Model is Invalid");
    }
}
