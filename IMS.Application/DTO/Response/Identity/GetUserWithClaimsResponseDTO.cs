using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Application.DTO.Response.Identity
{
    public class GetUserWithClaimsResponseDTO : BaseUserClaimsDTO
    {
        public string Email { get; set; }
    }
}
