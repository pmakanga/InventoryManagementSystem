using IMS.Application.DTO.Request.Identity;
using IMS.Application.DTO.Response;
using IMS.Application.DTO.Response.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Application.Interface.Identity
{
    public interface IAccount
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
        Task<IEnumerable<GetUserWithClaimsResponseDTO>> GetUserWithClaimsAsync();
        Task SetupAsync();
        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);
       // Task SaveActivityAsync(ActivityTrackerRequestDTO model);
        // Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();
    }
}
