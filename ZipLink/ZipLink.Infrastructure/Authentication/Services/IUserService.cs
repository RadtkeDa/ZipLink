using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZipLink.Domain.DTOs.Authentication;
using ZipLink.Domain.Entities.Identity;

namespace ZipLink.Infrastructure.Authentication.Services
{
    public interface IUserService
    {
        Task<AuthenticateResponse?> Authenticate(AuthenticateRequest model);
        Task<ApplicationUser?> GetById(string id);
    }
}
