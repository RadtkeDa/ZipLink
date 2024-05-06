using System.ComponentModel.DataAnnotations;

namespace ZipLink.Web.Areas.Identity.Models.AccountViewModels;

public class ExternalLoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}