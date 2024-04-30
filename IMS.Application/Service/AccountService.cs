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
    public class AccountService(IAccountService account) : IAccountService
    {
        public async Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model)
            => await account.CreateUserAsync(model);

        public Task<IEnumerable<GetUserWithClaimsResponseDTO>> GetUserWithClaimsAsync()
            => account.GetUserWithClaimsAsync();

        public Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model) 
            => account.LoginAsync(model);

        public Task SetUpAsync()
            => account.SetUpAsync();

        public Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model)
            => account.UpdateUserAsync(model);
    }
}
