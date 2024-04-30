using IMS.Application.DTO.Request.Identity;
using IMS.Application.DTO.Response;
using IMS.Application.DTO.Response.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Application.Service
{
    public interface IAccountService
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
        Task<IEnumerable<GetUserWithClaimsResponseDTO>> GetUserWithClaimsAsync();
        Task SetUpAsync();
        Task<ServiceResponse>UpdateUserAsync(ChangeUserClaimRequestDTO model);

        // Task SaveActivityAsync(ActivityTrackerRequestDTO model);
        // Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();

    }
}
