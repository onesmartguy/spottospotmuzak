using System.Threading.Tasks;
using SpotToSpotMuzik.Server.Middleware.Wrappers;
using SpotToSpotMuzik.Shared.Dto;
using SpotToSpotMuzik.Shared.Dto.Admin;
using Microsoft.AspNetCore.Mvc;

namespace SpotToSpotMuzik.Server.Managers
{
    public interface IAdminManager
    {
        Task<ApiResponse> GetUsers(int pageSize = 10, int pageNumber = 0);

        ApiResponse GetPermissions();

        Task<ApiResponse> GetRoles(int pageSize = 10,int pageNumber = 0);

        Task<ApiResponse> GetRoleAsync(string roleName);

        Task<ApiResponse> CreateRoleAsync(RoleDto newRole);

        Task<ApiResponse> UpdateRoleAsync([FromBody] RoleDto newRole);

        Task<ApiResponse> DeleteRoleAsync(string name);

    }
}
