using Microsoft.AspNetCore.Identity;

namespace ZipLink.Domain.Entities.Identity
{
    public class ApplicationUserToken : IdentityUserToken<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
