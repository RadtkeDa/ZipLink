using Microsoft.AspNetCore.Identity;

namespace ZipLink.Domain.Entities.Identity
{
    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
