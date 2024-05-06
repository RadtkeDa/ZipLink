using System.ComponentModel.DataAnnotations;

namespace ZipLink.Web.Areas.Identity.Models.AccountViewModels;

public class ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}